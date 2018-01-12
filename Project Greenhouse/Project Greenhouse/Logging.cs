using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Greenhouse
{
    class Logging
    {
        private RichTextBox TxtLogging;

        public Logging(RichTextBox _TextBox)
        {
            TxtLogging = _TextBox;

            WriteLog("Log started.");
        }


        public void WriteLog(string _message)
        {
            string text = String.Format("[{0}] {1}\n", DateTime.Now.ToString(), _message);
            TxtLogging.Text += text;
            File.AppendAllText("Log.txt",text);
        }
    }
}
