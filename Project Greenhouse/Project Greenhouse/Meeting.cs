using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//nodig voor SQL
using System.Data.SqlClient;
//nodig voor "Application.StartupPath"
using System.Windows.Forms;

namespace Project_Greenhouse
{
    class Meeting
    {
        private DateTime datum;
        private decimal lichtintensiteit;
        private decimal temperatuur;
        private decimal luchtvochtigheid;
        private decimal grondvochtigheid1;
        private decimal grondvochtigheid2;

        //connection string
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Meetingen.mdf;Integrated Security=True";
        //database connectie
        private SqlConnection connection = new SqlConnection(connectionString);

        //lijst met alle meetingen
        public List<Meeting> meetingLijst = new List<Meeting>();

        public void ZetEigenschappen(DateTime _datum, decimal _lichtIntensiteit, decimal _temperatuur, decimal _luchtvochtigheid, decimal _grondvochtigheid1, decimal _grondvochtigheid2)
        {
            datum = _datum;
            lichtintensiteit = _lichtIntensiteit;
            temperatuur = _temperatuur;
            luchtvochtigheid = _lichtIntensiteit;
            grondvochtigheid1 = _grondvochtigheid1;
            grondvochtigheid2 = _grondvochtigheid2;
        }

        public DateTime Datum()
        {
            return datum;
        }

        public decimal Lichtintensiteit()
        {
            return lichtintensiteit;
        }

        public void ImporteerMeetingenDB()
        {
            //clear de meetinglijst
            meetingLijst.Clear();

            //de query om de meetingen te importeren
            string query = "SELECT * FROM [Meeting]";

            //open connectie
            connection.Open();
            //maak command aan
            SqlCommand command = new SqlCommand(query, connection);

            //doorloop de resultaten van de querry
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //maak mod aan
                    Meeting m = new Meeting();
                    m.ZetEigenschappen(reader.GetDateTime(0), reader.GetDecimal(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetDecimal(5));

                    //voeg mod toe aan modlijst
                    meetingLijst.Add(m);
                }
            }

            //sluit de verbinding
            connection.Close();
        }

        public void AddMeetingDB(DateTime datumTijd, decimal lichtintensiteit, decimal temperatuur, decimal luchtvochtigheid, decimal grondvochtigheid1, decimal grondvochtigheid2)
        {
            //de query om de meetingen te importeren
            string query = "INSERT INTO Meeting (DatumTijd, Lichtintensiteit, Temperatuur, Luchtvochtigheid, Grondvochtigheid1, Grondvochtigheid2) VALUES (";
            //voeg de meeting values toe aan de query
            query += "'" + datumTijd.ToString() + "', '" + lichtintensiteit.ToString() + "', '" + temperatuur.ToString() + "', '" + luchtvochtigheid.ToString() + "', '" + grondvochtigheid1.ToString() + "', '" + grondvochtigheid2.ToString() + "')";

            //open connectie
            connection.Open();
            //maak command aan
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                //voer de query uit
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }            

            //sluit de verbinding
            connection.Close();
        }

        public void RandomMeeting(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                Random random = new Random();
                AddMeetingDB(DateTime.Now.AddDays(i), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
            }
        }

        public Meeting GetOudsteMeeting()
        {
            Meeting oudsteDatumMeeting = new Meeting();
            oudsteDatumMeeting.datum = DateTime.Now;
            foreach (Meeting m in meetingLijst)
            {
                if (m.datum < oudsteDatumMeeting.datum)
                {
                    oudsteDatumMeeting = m;
                }
            }
            return oudsteDatumMeeting;
        }

        public Meeting GetNieuwsteMeeting()
        {
            Meeting nieuwsteDatumMeeting = new Meeting();
            nieuwsteDatumMeeting.datum = DateTime.Now;
            foreach (Meeting m in meetingLijst)
            {
                if (m.datum > nieuwsteDatumMeeting.datum)
                {
                    nieuwsteDatumMeeting = m;
                }
            }
            return nieuwsteDatumMeeting;
        }
    }
}