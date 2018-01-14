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
            //gebruik altijd amerikaanse notatie voor datums (want database gebruikt deze voor datums)
            Application.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
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
            //veroorzaakt anders problemen bij een lege DB
            try
            {
                dateTimePicker1.MinDate = meeting.GetOudsteMeeting().Datum();
                dateTimePicker1.MaxDate = dateTimePicker2.Value;

                dateTimePicker2.MinDate = dateTimePicker1.Value;
                dateTimePicker2.MaxDate = meeting.GetNieuwsteMeeting().Datum();

                UpdateChart();
            }
            catch
            {
            }
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

//-----Genereer Meetingen-----//
    //-----datums-----//
        private void dtpGenereerVan_ValueChanged(object sender, EventArgs e)
        {
            //tel het aantal datums tussen dtpVan en dtpTot en update de tekstbox
            //wordt afgerond naar int
            int aantalDagen = (int)((dtpGenereerTot.Value - dtpGenereerVan.Value).TotalDays + 1);
            tbGeneerDatums.Text = aantalDagen.ToString();

            //zet de minimum en maximum waarden van de datetimepickers
            dtpGenereerVan.MaxDate = dtpGenereerTot.Value;
            dtpGenereerTot.MinDate = dtpGenereerVan.Value;
        }

        private void tbGeneerDatums_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    dtpGenereerTot.Value = dtpGenereerVan.Value.AddDays(Convert.ToInt32(tbGeneerDatums.Text) - 1);
                }
                catch (Exception)
                {
                }
            }
        }
    //-----interval------//
        private void cbTijdsEenheid_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMeetingenPerDag();
        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {
            UpdateMeetingenPerDag();
        }

        private void UpdateMeetingenPerDag()
        {
            //een onjuiste input bij Interval kan het niet laten werken, vandaar try
            try
            {
                switch (cbTijdsEenheid.SelectedIndex)
                {
                    //seconden
                    case 0:
                        //aantal seconden in dag*interval
                        tbMeetingenPerDag.Text = (60 * 60 * 24 * Convert.ToDouble(tbInterval.Text)).ToString();
                        break;
                    //minuut
                    case 1:
                        //aantal minuten in dag*interval
                        tbMeetingenPerDag.Text = (60 * 24 * Convert.ToDouble(tbInterval.Text)).ToString();
                        break;
                    //uur
                    case 2:
                        //aantal uur in dag*interval
                        tbMeetingenPerDag.Text = (24 * Convert.ToDouble(tbInterval.Text)).ToString();
                        break;
                    //dag
                    case 3:
                        //is hier gelijk
                        tbMeetingenPerDag.Text = (Convert.ToDouble(tbInterval.Text)).ToString();
                        break;
                    //week
                    case 4:
                        //interval / dagen in een week
                        tbMeetingenPerDag.Text = (Convert.ToDouble(tbInterval.Text) / 7).ToString();
                        break;
                    //maand
                    case 5:
                        //interval / dagen in maand
                        tbMeetingenPerDag.Text = (Convert.ToDouble(tbInterval.Text) / (365 / 12)).ToString();
                        break;
                    //jaar
                    case 6:
                        //interval / dagen in jaar
                        tbMeetingenPerDag.Text = (Convert.ToDouble(tbInterval.Text) / 365).ToString();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    //-----genereer-----//
        //bereken totaal aantal meetingen
        private void tbMeetingenPerDag_TextChanged(object sender, EventArgs e)
        {
            //ja dit is niet het meest nauwkeurig
            tbGenereerTotaalAantalMeetingen.Text = Convert.ToInt32((Convert.ToDouble(tbGeneerDatums.Text) * Convert.ToDouble(tbMeetingenPerDag.Text))).ToString();
        }

        private void btnGenereerMeetingen_Click(object sender, EventArgs e)
        {
            try
            {
                //database moet eerst geleegd worden
                if (cbVervangDB.Checked == true)
                {
                    meeting.LeegDB();
                }
                int interval = Convert.ToInt32(tbInterval.Text);

                //genereer de random data
                meeting.GenereerRandomMeetingen(dtpGenereerVan.Value, dtpGenereerTot.Value, interval, cbTijdsEenheid.SelectedIndex, Convert.ToInt32(nudMinLichtintensiteit.Value), Convert.ToInt32(nudMaxLichtintensiteit.Value), Convert.ToInt32(nudADLichtintensiteit.Value), Convert.ToInt32(nudMinTemperatuur.Value), Convert.ToInt32(nudMaxTemperatuur.Value), Convert.ToInt32(nudADTemperatuur.Value), Convert.ToInt32(nudMinLuchtvochtigheid.Value), Convert.ToInt32(nudMaxLuchtvochtigheid.Value), Convert.ToInt32(nudADLuchtvochtigheid.Value), Convert.ToInt32(nudMinGrondvochtigheid.Value), Convert.ToInt32(nudMaxGrondvochtigheid.Value), Convert.ToInt32(nudADGrondvochtigheid.Value));

                MessageBox.Show(meeting.meetingLijst.Count() + " Meetingen toegevoegd!");
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
