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

namespace Project_Greenhouse
{
    public partial class Form1 : Form
    {
        #region Variabelen
        private SerialMessenger serialMessenger;
        private Logging log;
        List<Plant> plantenLijst = new List<Plant>();
        List<PlantSoort> soortenLijst = new List<PlantSoort>();
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
                catch
                {

                }
            }
        }

        void ReadPlantFile()
        {
            if (File.Exists("PlantFile.txt"))
            {
                try
                {                    
                    string[] data = File.ReadAllLines("PlantFile.txt");
                    for (int i = 0; i < data.Length; i += 4)
                    {
                        Plant p = new Plant(data[i], int.Parse(data[i + 1]), data[i + 2]);
                        plantenLijst.Add(p);
                        //TvPlanten.Nodes.Add(p.ToString());
                        TvPlanten.Nodes.Find(p.Soort, false).First().Nodes.Add(p.ToString());
                        log.WriteLog(String.Format("Added {0} of type {1}.", p.ToString(), p.Soort));
                    }
                }
                catch
                {
                    
                }
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

                File.AppendAllLines("PlantFile.txt", new string[] { String.Format("{0}\n{1}\n{2}\n", TxtPlantnaam.Text, ((int)NudWater.Value).ToString(), CbPlantsoort.Text) });
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
                    FileContent = File.ReadAllLines("PlantFile.txt").ToList();
                    int index = FileContent.FindIndex(delegate (string g)
                    {
                        return g == TvPlanten.SelectedNode.Text;
                    });

                    FileContent.RemoveRange(index, 4);
                    File.WriteAllLines("PlantFile.txt", FileContent);

                    log.WriteLog("Removed Plant " + FindPlant(TvPlanten.SelectedNode.Text).ToString());

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

        //TODO: Voeg waardes toe aan database
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
                DateTime date = DateTime.Parse(message.Substring(message.IndexOf(":") + 1, message.Length - (message.IndexOf(":") + 1)));
                File.AppendAllText("Data.txt", date.ToString() + "\n\n");
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

        #region Graphs
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
            else
            {
                MessageBox.Show("No file selected!", "Error!");
                log.WriteLog("Failed to draw charts, no file was selected!");
            }
        }
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
