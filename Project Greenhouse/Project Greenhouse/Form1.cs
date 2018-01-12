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
        public Form1()
        {
            InitializeComponent();
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
    }
}
