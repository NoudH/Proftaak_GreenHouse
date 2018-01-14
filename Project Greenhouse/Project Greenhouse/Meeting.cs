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
        private double lichtintensiteit;
        private double temperatuur;
        private double luchtvochtigheid;
        private double grondvochtigheid1;
        private double grondvochtigheid2;

        //connection string
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Meetingen.mdf;Integrated Security=True";
        //database connectie
        private SqlConnection connection = new SqlConnection(connectionString);

        //lijst met alle meetingen
        public List<Meeting> meetingLijst = new List<Meeting>();

        public void ZetEigenschappen(DateTime _datum, double _lichtIntensiteit, double _temperatuur, double _luchtvochtigheid, double _grondvochtigheid1, double _grondvochtigheid2)
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

        public double Lichtintensiteit()
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
                    m.ZetEigenschappen(reader.GetDateTime(0), (double)reader.GetDecimal(1), (double)reader.GetDecimal(2), (double)reader.GetDecimal(3), (double)reader.GetDecimal(4), (double)reader.GetDecimal(5));

                    //voeg mod toe aan modlijst
                    meetingLijst.Add(m);
                }
            }

            //sluit de verbinding
            connection.Close();
        }

        public void AddMeetingDB(DateTime datumTijd, double lichtintensiteit, double temperatuur, double luchtvochtigheid, double grondvochtigheid1, double grondvochtigheid2)
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
                connection.Close();
            }            

            //sluit de verbinding
            connection.Close();
        }

        public void LeegDB()
        {
            //leeg de meetinglijst
            meetingLijst.Clear();

            //de query om alle meetingen te verwijderen
            string query = "DELETE FROM [Meeting]";
            
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
                connection.Close();
            }

            //sluit de verbinding
            connection.Close();
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

        //series returnen met switch

        //random uitbreiden
        public void GenereerRandomMeetingen(DateTime startDatum, DateTime eindDatum, int interval, int tijdseenheidIndex, int LIMin, int LIMax, int LIAD, int TMin, int TMax, int TAD, int LVMin, int LVMax, int LVAD, int GVMin, int GVMax, int GVAD)
        {
            //datum waaraan tijdseenheden worden toegevoegd
            DateTime huidigeDatum = startDatum;

            while (huidigeDatum < eindDatum)
            {
                //de grondvochtigheid wordt 2x random bepaald
                AddMeetingDB(huidigeDatum, GenereerGetal(LIMin, LIMax, LIAD), GenereerGetal(TMin, TMax, TAD), GenereerGetal(LVMin, LVMax, LVAD), GenereerGetal(GVMin, GVMax, GVAD), GenereerGetal(GVMin, GVMax, GVAD));

                //TRAPJE! 5 meetingen per dag = ...uur toevoegen
                //        5 meetingen per week = ...dagen toevoegen
                //        5 meetingen per seconde = ... milliseconden toevoegen

                switch (tijdseenheidIndex)
                {
                    //seconden
                    case 0:
                        //1000 ms / #meetingen / per seconde
                        huidigeDatum = huidigeDatum.AddMilliseconds(1000 / interval);
                        break;
                    //minuut
                    case 1:
                        //60 seconden / #meetingen per minuut
                        huidigeDatum = huidigeDatum.AddSeconds(60 / interval);
                        break;
                    //uur
                    case 2:
                        //60 minuten / #meetingen per uur
                        huidigeDatum = huidigeDatum.AddMinutes(60 / interval);
                        break;
                    //dag
                    case 3:
                        //24 uur / #meetingen per dag
                        huidigeDatum = huidigeDatum.AddHours(24 / interval);
                        break;
                    //week
                    case 4:
                        //24*7 uur / #meetingen per week
                        huidigeDatum = huidigeDatum.AddHours((24 * 7) / interval);
                        break;
                    //maand
                    case 5:
                        //365/12 / #meetingen per maand.............
                        huidigeDatum = huidigeDatum.AddDays(interval);
                        break;
                    //jaar
                    case 6:
                        huidigeDatum = huidigeDatum.AddYears(interval);
                        break;
                }
            }
            //importeer de items
            ImporteerMeetingenDB();
        }

        //genereer een willekeurig getal met een aantal decimalen
        private double GenereerGetal(int min, int max, int aantalDecimalen)
        {
            Random random = new Random();
            //bv: 47.
            string Getal = random.Next(min, max).ToString() + ".";

            for (int i = 0; i < aantalDecimalen; i++)
            {
                Getal += random.Next(0, 9).ToString();
            }
            //bv: 47.21735
            return Convert.ToDouble(Getal);
        }
    }
}