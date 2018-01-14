using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//voor bestanden te lezen
using System.IO;
//voor sql
using System.Data.SqlClient;
//voor cultrure info
using System.Globalization;

namespace Project_Greenhouse
{
    public partial class Form1 : Form
    {
        //connection string
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Meetingen.mdf;Integrated Security=True";
        //database connectie
        private SqlConnection connection = new SqlConnection(connectionString);

        //meeting object met actuele meetinglijst
        Meeting meeting = new Meeting();


        public Form1()
        {
            InitializeComponent();
            //gebruik altijd amerikaanse notatie voor datums
            Application.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");


            meeting.RandomMeeting(1000);
            meeting.ImporteerMeetingenDB();
            foreach (Meeting m in meeting.meetingLijst)
            {
                listBox1.Items.Add(m.ToString());
            }
        }

        private void btnScanFiles_Click(object sender, EventArgs e)
        {
            List<string> tekstBestandenLijst = new List<string>();

            string tekstBestandenPath = "@D:\\School\\Proftaak_GreenHouse\\Project Greenhouse\\TextFilesArduino";
            DirectoryInfo path = new DirectoryInfo(tekstBestandenPath);


            foreach (var file in path.GetFiles("*.txt"))
            {
                tekstBestandenLijst.Add(file.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //checkbox lichtintensiteit
        private void cbLichtintensiteit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        //chart datums veranderd
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = meeting.GetOudsteMeeting().Datum();
            dateTimePicker1.MaxDate = dateTimePicker2.Value;

            dateTimePicker2.MinDate = dateTimePicker1.Value;
            dateTimePicker2.MaxDate = meeting.GetNieuwsteMeeting().Datum();

            UpdateChart();
        }

        public void UpdateChart()
        {
            if (cbLichtintensiteit.Enabled == true)
            {
                chartMeetingen.Series.Clear();
                Series s = new Series();
                chartMeetingen.Series.Add("Lichtintensiteit");
                chartMeetingen.Series[0].XValueType = ChartValueType.DateTime;
                chartMeetingen.Series[0].YValueType = ChartValueType.Double;
                chartMeetingen.Series[0].ChartType = SeriesChartType.Spline;
                foreach (Meeting m in meeting.meetingLijst)
                {
                    //als meetpunt binnen de datum valt
                    if (m.Datum() > dateTimePicker1.Value && m.Datum() < dateTimePicker2.Value)
                    {
                        chartMeetingen.Series[0].Points.AddXY(m.Datum(), m.Lichtintensiteit());
                    }
                }
            }
        }
    }
}
