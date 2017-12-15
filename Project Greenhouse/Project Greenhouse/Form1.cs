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
        private SerialMessenger serialMessenger;
        List<Plant> plantenLijst = new List<Plant>();

        public Form1()
        {
            InitializeComponent();
            ReadPlantFile();
            

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM4", 115200, messageBuilder);

            //TODO: Zet dit in een button
            //serialMessenger.Connect();            
        }        

        void ReadPlantFile()
        {
            if (File.Exists("PlantFile.txt"))
            {
                string[] data = File.ReadAllLines("PlantFile.txt");
                for (int i = 0; i < data.Length; i+=3)
                {
                    Plant p = new Plant(data[i], int.Parse(data[i + 1]));
                    plantenLijst.Add(p);
                    LbPlanten.Items.Add(p.Naam);
                }
            }
            
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

        private void WriteLog(string _message)
        {
            TxtLogging.Text += String.Format("[{0}] {1}\n", DateTime.Now.ToString(), _message);
        }

        private void BtnAddPlant_Click(object sender, EventArgs e)
        {
            Plant p = new Plant(TxtPlantnaam.Text, (int)NudWater.Value);
            plantenLijst.Add(p);
            LbPlanten.Items.Add(p.Naam);

            File.AppendAllLines("PlantFile.txt", new string[] { String.Format("{0}\n{1}\n", TxtPlantnaam.Text, (int)NudWater.Value) });
        }

        private void LbPlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TxtPlantnaam.Text = FindPlant(LbPlanten.SelectedItem.ToString()).Naam;
                NudWater.Value = FindPlant(LbPlanten.SelectedItem.ToString()).Water;
            }
            catch 
            {

            }            
        }

        private Plant FindPlant(string _naam)
        {
            return plantenLijst.Find(delegate (Plant p)
            {
                return p.Naam == _naam;
            });
        }

        private void BtnSendPlant_Click(object sender, EventArgs e)
        {
            serialMessenger.Connect();
            serialMessenger.SendMessage(FindPlant(LbPlanten.SelectedItem.ToString()).Water.ToString());
        }

        private void BtnRemovePlant_Click(object sender, EventArgs e)
        {
            List<string> FileContent = new List<string>();
            FileContent = File.ReadAllLines("PlantFile.txt").ToList();
            int index = FileContent.IndexOf(LbPlanten.SelectedItem.ToString());

            FileContent.RemoveRange(index, 3);

            File.WriteAllLines("PlantFile.txt", FileContent);
            plantenLijst.Remove(FindPlant(LbPlanten.SelectedItem.ToString()));
            LbPlanten.Items.RemoveAt(LbPlanten.SelectedIndex);
        }
    }
}
