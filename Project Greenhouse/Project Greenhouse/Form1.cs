using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//voor cultrure info
using System.Globalization;

namespace Project_Greenhouse
{
    public partial class Form1 : Form
    {
        #region Variabelen
        private SerialMessenger serialMessenger;
        private Logging log;
        List<Plant> plantenLijst = new List<Plant>();
        List<PlantSoort> soortenLijst = new List<PlantSoort>();
        //meeting object met actuele meetinglijst
        Meeting meeting = new Meeting();
        #endregion

        #region Form Related        
        public Form1()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');

            serialMessenger = new SerialMessenger("COM4", 115200, messageBuilder);
            log = new Logging(TxtLogging);

            PopulateTreeView();
            ReadPlantFile();                        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialMessenger.Disconnect();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gebruik altijd amerikaanse notatie voor datums (want database gebruikt deze voor datums)
            Application.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            //importeer metingen uit de DB
            meeting.ImporteerMeetingenDB();
        }
        #endregion

        #region Treeview + Filereading
        void PopulateTreeView()
        {
            log.WriteLog("Populating treeview:");

            TvPlanten.Nodes.Add("Undefined", "Undefined");

            if (File.Exists("Plantsoorten.txt"))
            {
                try
                {
                    string[] data = File.ReadAllLines("Plantsoorten.txt");
                    for (int i = 0; i < data.Length; i++)
                    {
                        PlantSoort p = new PlantSoort(data[i]);
                        soortenLijst.Add(p);
                        TvPlanten.Nodes.Add(p.ToString(),p.ToString());
                        CbPlantsoort.Items.Add(p.ToString());
                        log.WriteLog("Added " + data[i] + " as a \"Plantsoort\"");
                    }
                }
                catch (Exception ex)
                {
                    log.WriteLog(ex.Message);
                }
            }
        }

        void ReadPlantFile()
        {
            /*if (File.Exists("PlantFile.txt"))
            {
                try
                {                    
                    string[] data = File.ReadAllLines("PlantFile.txt");
                    for (int i = 0; i < data.Length; i += 4)
                    {
                        Plant p = new Plant(data[i], int.Parse(data[i + 1]), data[i + 2]);
                        plantenLijst.Add(p);
                        //TvPlanten.Nodes.Add(p.ToString());
                        
                        log.WriteLog(String.Format("Added {0} of type {1}.", p.ToString(), p.Soort));
                    }
                }
                catch
                {
                    
                }
            }*/
            try
            {
                DatabaseIO database = new DatabaseIO();
                database.ReadPlant();
                for (int i = 0; i < database.plantnaamls.Count(); i++)
                {
                    Plant p = new Plant(database.plantnaamls[i], (int)database.benodigdwaterdagmlls[i], database.plantsoortls[i]);
                    plantenLijst.Add(p);
                    TvPlanten.Nodes.Find(p.Soort, false).First().Nodes.Add(p.ToString());
                    log.WriteLog(String.Format("Added {0} of type {1}.", p.ToString(), p.Soort));
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(ex.Message);
            }

        }

        private void TvPlanten_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TvPlanten.SelectedNode.Parent != null)
            {
                TxtPlantnaam.Text = FindPlant(TvPlanten.SelectedNode.Text).Naam;
                NudWater.Value = FindPlant(TvPlanten.SelectedNode.Text).Water;
                CbPlantsoort.Text = FindPlant(TvPlanten.SelectedNode.Text).Soort;
            }
        }
        #endregion

        #region Planten
        private void BtnAddPlant_Click(object sender, EventArgs e)
        {
            if (TvPlanten.Nodes.Find(TxtPlantnaam.Text, true).Count() == 0)
            {
                Plant p = new Plant(TxtPlantnaam.Text, (int)NudWater.Value, CbPlantsoort.Text);
                plantenLijst.Add(p);
                TvPlanten.Nodes.Find(p.Soort, false).First().Nodes.Add(p.ToString(), p.ToString());

                //File.AppendAllLines("PlantFile.txt", new string[] { String.Format("{0}\n{1}\n{2}\n", TxtPlantnaam.Text, ((int)NudWater.Value).ToString(), CbPlantsoort.Text) });
                DatabaseIO database = new DatabaseIO(TxtPlantnaam.Text, (float)NudWater.Value, CbPlantsoort.Text);
                database.OpslaanPlant();
                log.WriteLog(String.Format("Added plant with properties: Naam:{0}, Grondvochtigheid:{1}, Soort:{2}", p.Naam, p.Water, p.Soort));
            }
            else
            {
                log.WriteLog("User tried to make a duplicate item.");
                MessageBox.Show("Je kunt geen twee items met dezelfde naam aanmaken.", "Error!");
            }
        }

        private void BtnRemovePlant_Click(object sender, EventArgs e)
        {
            if (TvPlanten.SelectedNode.Nodes.Count < 1)
            {
                List<string> FileContent = new List<string>();

                if (TvPlanten.SelectedNode.Parent == null)
                {
                    FileContent = File.ReadAllLines("Plantsoorten.txt").ToList();
                    int index = FileContent.FindIndex(delegate (string g)
                    {
                        return g == TvPlanten.SelectedNode.Text;
                    });

                    FileContent.RemoveRange(index, 1);
                    File.WriteAllLines("Plantsoorten.txt", FileContent);

                    log.WriteLog("Removed Plantsoort " + FindPlantsoort(TvPlanten.SelectedNode.Text).ToString());

                    CbPlantsoort.Items.RemoveAt(index + 1);
                    soortenLijst.Remove(FindPlantsoort(TvPlanten.SelectedNode.Text));
                    TvPlanten.Nodes.Remove(TvPlanten.SelectedNode);
                }
                else
                {
                    DatabaseIO database = new DatabaseIO();
                    database.DeletePlant(TvPlanten.SelectedNode.Text);

                    plantenLijst.Remove(FindPlant(TvPlanten.SelectedNode.Text));
                    TvPlanten.Nodes.Remove(TvPlanten.SelectedNode);
                }                
            }
            else
            {
                //prevent batman from existing
                MessageBox.Show("You cannot delete an item that has children.\nRemove the children first.", "Error!");
            }
            
        }
        #endregion

        #region Plantsoort
        private void BtnAddPlantsoort_Click(object sender, EventArgs e)
        {
            if (TvPlanten.Nodes.Find(TxtPlantsoortNaam.Text, false).Count() == 0)
            {
                PlantSoort p = new PlantSoort(TxtPlantsoortNaam.Text);
                soortenLijst.Add(p);
                File.AppendAllText("Plantsoorten.txt", TxtPlantsoortNaam.Text + "\n");
                CbPlantsoort.Items.Add(p.ToString());
                TvPlanten.Nodes.Add(p.ToString(), p.ToString());
                log.WriteLog("Added plantsoort with Naam: " + TxtPlantsoortNaam.Text);
            }
            else
            {
                log.WriteLog("User tried to make a duplicate item.");
                MessageBox.Show("Je kunt geen twee items met dezelfde naam aanmaken.", "Error!");
            }
        }
        #endregion

        #region Serialmessaging
        private void readMessageTimer_Tick(object sender, EventArgs e)
        {
            string[] messages = serialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    processReceivedMessage(message);
                }
            }
        }

        private void processReceivedMessage(string message)
        {
            if (message.StartsWith("temp:"))
            {
                int value = getParamValue(message);
                File.AppendAllText("Data.txt", value.ToString() +"\n");
            }
            else if (message.StartsWith("licht:"))
            {
                int value = getParamValue(message);
                File.AppendAllText("Data.txt", value.ToString() + "\n");
            }
            else if (message.StartsWith("plant1:"))
            {
                int value = getParamValue(message);
                File.AppendAllText("Data.txt", value.ToString() + "\n");
            }
            else if (message.StartsWith("plant2:"))
            {
                int value = getParamValue(message);
                File.AppendAllText("Data.txt", value.ToString() + "\n");
            }
            else if (message.StartsWith("date:"))
            {
                try
                {
                    DateTime date = DateTime.Parse(message.Substring(message.IndexOf(":") + 1, message.Length - (message.IndexOf(":") + 1)));
                    string[] data = File.ReadAllLines("Data.txt");
                    File.AppendAllText("Data.txt", date.ToString() + "\n\n");

                    DatabaseIO database = new DatabaseIO(float.Parse(data[data.Length - 4]), float.Parse(data[data.Length - 3]), float.Parse(data[data.Length - 2]), float.Parse(data[data.Length - 1]), date);
                    database.Opslaan();                    
                }
                catch (Exception ex)
                {
                    log.WriteLog(ex.Message);
                }
            }
        }

        private int getParamValue(string message)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string param = message.Substring(colonIndex + 1);
                int value;
                bool done = int.TryParse(param, out value);
                if (done)
                {
                    return value;
                }
            }
            throw new ArgumentException("message contains no value parameter");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (BtnConnect.Text == "Connect to Arduino")
            {
                serialMessenger.Connect();
                BtnSendPlant.Enabled = true;
                BtnDataArduino.Enabled = true;
                BtnConnect.Text = "Disconnect Arduino";
            }
            else
            {
                serialMessenger.Disconnect();
                BtnSendPlant.Enabled = false;
                BtnDataArduino.Enabled = false;
                BtnConnect.Text = "Connect to Arduino";
            }

        }

        private void BtnSendPlant_Click(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("groep" + CbPlantNummer.Text + ":" + (int)NudWater.Value);
        }

        private void BtnDataArduino_Click(object sender, EventArgs e)
        {
            serialMessenger.SendMessage("Go");
        }
        #endregion

        #region GraphsFile
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OfdDatafile.Filter = "Text file (*.txt) | *.txt";
            OfdDatafile.ShowDialog();
            log.WriteLog("File " + OfdDatafile.FileName + " selected");
        }

        private void DtpGraphs_ValueChanged(object sender, EventArgs e)
        {
            ChartTemp.Series[0].Points.Clear();
            ChartHumidity.Series[0].Points.Clear();
            ChartMoisture.Series[0].Points.Clear();
            ChartMoisture.Series[1].Points.Clear();

            if (OfdDatafile.FileName != "")
            {
                try
                {
                    string[] data = File.ReadAllLines(OfdDatafile.FileName);
                    for (int i = 0; i < data.Length; i += 6)
                    {
                        if (DateTime.Parse(data[i + 4]).ToShortDateString() == DtpGraphs.Value.ToShortDateString())
                        {
                            ChartTemp.Series[0].Points.AddXY(DateTime.Parse(data[i + 4]).ToShortTimeString(), double.Parse(data[i]));
                            ChartHumidity.Series[0].Points.AddXY(DateTime.Parse(data[i + 4]).ToShortTimeString(), double.Parse(data[i + 1]));
                            ChartMoisture.Series[0].Points.AddXY(DateTime.Parse(data[i + 4]).ToShortTimeString(), double.Parse(data[i + 2]));
                            ChartMoisture.Series[1].Points.AddXY(DateTime.Parse(data[i + 4]).ToShortTimeString(), double.Parse(data[i + 3]));
                        }
                    }
                    log.WriteLog("Succesfully drawn charts with date: " + DtpGraphs.Value.ToString());
                }
                catch (Exception ex)
                {
                    log.WriteLog(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No file selected!", "Error!");
                log.WriteLog("Failed to draw charts, no file was selected!");
            }

            /*DatabaseIO database = new DatabaseIO();
            database.Leesgegevens(DateTime.Parse(DtpGraphs.Value.ToShortDateString()));

            for (int i = 0; i < database.datumtijdls.Count(); i++)
            {

                ChartTemp.Series[0].Points.AddXY(database.datumtijdls[i].ToShortTimeString(), (double)database.temperatuurls[i]);
                ChartHumidity.Series[0].Points.AddXY(database.datumtijdls[i].ToShortTimeString(), (double)database.lichtintensietijdls[i]);
                ChartMoisture.Series[0].Points.AddXY(database.datumtijdls[i].ToShortTimeString(), (double)database.grondvochtigheidp1ls[i]);
                ChartMoisture.Series[1].Points.AddXY(database.datumtijdls[i].ToShortTimeString(), (double)database.grondvochtigheidp2ls[i]);

            }
            log.WriteLog("Succesfully drawn charts with date: " + DtpGraphs.Value.ToString());*/
        }
        #endregion

        #region Metingen
        #region GenereerMetingen
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
        
        //bereken totaal aantal meetingen
        private void tbMeetingenPerDag_TextChanged(object sender, EventArgs e)
        {
            //ja dit is niet het meest nauwkeurig
            tbGenereerTotaalAantalMeetingen.Text = Convert.ToInt32(((float)Convert.ToDouble(tbGeneerDatums.Text) * (float)Convert.ToDouble(tbMeetingenPerDag.Text))).ToString();
        }
        private void tbGeneerDatums_TextChanged(object sender, EventArgs e)
        {
            tbGenereerTotaalAantalMeetingen.Text = Convert.ToInt32(((float)Convert.ToDouble(tbGeneerDatums.Text) * (float)Convert.ToDouble(tbMeetingenPerDag.Text))).ToString();
        }

        private void btnGenereerMeetingen_Click(object sender, EventArgs e)
        {
            if (tbGenereerTotaalAantalMeetingen.Text != "0" && tbGenereerTotaalAantalMeetingen.Text != "")
            {
                try
                {
                    //huidig aantal meetingen in de database
                    int meetinglijstAantalOud = meeting.meetingLijst.Count();

                    //database moet eerst geleegd worden
                    if (cbVervangDB.Checked == true)
                    {
                        meeting.LeegDB();
                    }
                    int interval = Convert.ToInt32(tbInterval.Text);

                    //genereer de random data
                    meeting.GenereerRandomMeetingen(dtpGenereerVan.Value, dtpGenereerTot.Value, interval, cbTijdsEenheid.SelectedIndex, Convert.ToInt32(nudMinLichtintensiteit.Value), Convert.ToInt32(nudMaxLichtintensiteit.Value), Convert.ToInt32(nudADLichtintensiteit.Value), Convert.ToInt32(nudMinTemperatuur.Value), Convert.ToInt32(nudMaxTemperatuur.Value), Convert.ToInt32(nudADTemperatuur.Value), Convert.ToInt32(nudMinGrondvochtigheid.Value), Convert.ToInt32(nudMaxGrondvochtigheid.Value), Convert.ToInt32(nudADGrondvochtigheid.Value));

                    //herlees de database
                    meeting.ImporteerMeetingenDB();

                    if (cbVervangDB.Checked)
                    {
                        MessageBox.Show(meeting.meetingLijst.Count() + " Metingen toegevoegd en " + meetinglijstAantalOud.ToString() + " metingen verwijderd.");
                    }
                    else MessageBox.Show((meeting.meetingLijst.Count() - meetinglijstAantalOud).ToString() + " Metingen toegevoegd, dit brengt het totaal op " + meeting.meetingLijst.Count().ToString());


                    //zet het min en max van de datetimepickers (in Graph) goed op basis van de nieuwe metingen
                    dtpGraphVan.MinDate = meeting.GetOudsteMeeting().Datum();
                    dtpGraphTot.MaxDate = meeting.GetNieuwsteMeeting().Datum();
                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }
            else MessageBox.Show("Het aantal metingen kan niet 0 zijn.", "Error");
        }
        #endregion
        #region MeetingGraphs
        private void cbLichtintensiteit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void dtpGraphVan_ValueChanged(object sender, EventArgs e)
        {
            //veroorzaakt anders problemen bij een lege DB
            try
            {
                dtpGraphVan.MinDate = meeting.GetOudsteMeeting().Datum();
                dtpGraphVan.MaxDate = dtpGraphTot.Value;

                dtpGraphTot.MinDate = dtpGraphVan.Value;
                dtpGraphTot.MaxDate = meeting.GetNieuwsteMeeting().Datum();

                UpdateChart();
            }
            catch
            {
            }
        }

        public void UpdateChart()
        {
            //lichtintensiteit
            if (cbLichtintensiteit.Checked)
            {
                chartMetingen.Series[0].Points.Clear();
                foreach (Meeting m in meeting.meetingLijst)
                {
                    //als meetpunt binnen de datum valt
                    if (m.Datum() > dtpGraphVan.Value && m.Datum() < dtpGraphTot.Value)
                    {
                        chartMetingen.Series[0].Points.AddXY(m.Datum(), m.Lichtintensiteit());
                    }
                }
            }
            else
            {
                chartMetingen.Series[0].Points.Clear();
            }

            //temperatuur
            if (cbTemperatuur.Checked)
            {
                chartMetingen.Series[1].Points.Clear();
                foreach (Meeting m in meeting.meetingLijst)
                {
                    //als meetpunt binnen de datum valt
                    if (m.Datum() > dtpGraphVan.Value && m.Datum() < dtpGraphTot.Value)
                    {
                        chartMetingen.Series[1].Points.AddXY(m.Datum(), m.Temperatuur());
                    }
                }
            }
            else
            {
                chartMetingen.Series[1].Points.Clear();
            }

            //grondvochtigheid1
            if (cbGrondvochtigheid1.Checked)
            {
                chartMetingen.Series[2].Points.Clear();
                foreach (Meeting m in meeting.meetingLijst)
                {
                    //als meetpunt binnen de datum valt
                    if (m.Datum() > dtpGraphVan.Value && m.Datum() < dtpGraphTot.Value)
                    {
                        chartMetingen.Series[2].Points.AddXY(m.Datum(), m.Grondvochtigheid1());
                    }
                }
            }
            else
            {
                chartMetingen.Series[2].Points.Clear();
            }

            //grondvochtigheid2
            if (cbGrondvochtigheid2.Checked)
            {
                chartMetingen.Series[3].Points.Clear();
                foreach (Meeting m in meeting.meetingLijst)
                {
                    //als meetpunt binnen de datum valt
                    if (m.Datum() > dtpGraphVan.Value && m.Datum() < dtpGraphTot.Value)
                    {
                        chartMetingen.Series[3].Points.AddXY(m.Datum(), m.Grondvochtigheid2());
                    }
                }
            }
            else
            {
                chartMetingen.Series[3].Points.Clear();
            }
        }
        #endregion
        #endregion

        #region Functies
        private Plant FindPlant(string _naam)
        {
            return plantenLijst.Find(delegate (Plant p)
            {
                return p.Naam == _naam;
            });
        }

        private PlantSoort FindPlantsoort(string _naam)
        {
            return soortenLijst.Find(delegate (PlantSoort p)
            {
                return p.Naam == _naam;
            });
        }
        #endregion
    }
}