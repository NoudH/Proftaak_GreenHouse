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
        private float lichtintensiteit;
        private float temperatuur;
        private float luchtvochtigheid;
        private float grondvochtigheid1;
        private float grondvochtigheid2;

        //connection string
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Meetingen.mdf;Integrated Security=True";
        //database connectie
        private SqlConnection connection = new SqlConnection(connectionString);

        //lijst met alle meetingen
        public List<Meeting> meetingLijst = new List<Meeting>();

        public void ZetEigenschappen(DateTime _datum, float _lichtIntensiteit, float _temperatuur, float _luchtvochtigheid, float _grondvochtigheid1, float _grondvochtigheid2)
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

        public float Lichtintensiteit()
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
                    m.ZetEigenschappen(reader.GetDateTime(0), (float)reader.GetDouble(1), (float)reader.GetDouble(2), (float)reader.GetDouble(3), (float)reader.GetDouble(4), (float)reader.GetDouble(5));

                    //voeg mod toe aan modlijst
                    meetingLijst.Add(m);
                }
            }

            //sluit de verbinding
            connection.Close();
        }

        public void AddMeetingDB(DateTime datumTijd, float lichtintensiteit, float temperatuur, float luchtvochtigheid, float grondvochtigheid1, float grondvochtigheid2)
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
                MessageBox.Show("Fout bij het toevoegen van Meeting aan DB: " + e.Message);
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

            float totaalAantalUur = (float)(eindDatum - startDatum).TotalHours;

            float meetingenPerDag = 1.897F;
            //om te weten of het minimum gevonden is
            bool indexGevonden = false;
            //wordt gebruikt voor de switch bij het toevoegen van de tijdseenheid
            int indexIntervalTussenMeetingen = 0;

            //bereken het aantal meetingen per dag
            //try was al gebruikt bij de input
            switch (tijdseenheidIndex)
            {
                //seconden
                case 0:
                    //aantal seconden in dag*interval
                    meetingenPerDag = 60 * 60 * 24 * interval;
                    break;
                //minuut
                case 1:
                    //aantal minuten in dag*interval
                    meetingenPerDag = 60 * 24 * interval;
                    break;
                //uur
                case 2:
                    //aantal uur in dag*interval
                    meetingenPerDag = 24 * interval;
                    break;
                //dag
                case 3:
                    //is hier gelijk
                    meetingenPerDag = interval;
                    break;
                //week
                case 4:
                    //interval / dagen in een week
                    meetingenPerDag = interval / 7;
                    break;
                //maand
                case 5:
                    //interval / dagen in een maand
                    meetingenPerDag = (interval / (365 / 12));
                    break;
                //jaar
                case 6:
                    //interval / dagen in een jaar
                    meetingenPerDag = interval / 365;
                    break;
            }

            //vergelijk het aantal meetingen dat per dag gedaan moet worden, met de beschikbare tijdseenheden in een dag
            //als het aantal meetingen per dag > aantal milliseconden in een dag, kan de meeting niet gedaan worden
            if (meetingenPerDag > 24 * 60 * 60 * 1000)
            {
                MessageBox.Show("Een dag heeft niet genoeg milliseconden om unieke meetingen te genereren, verlaag het aantal meetingen per dag en probeer opnieuw.");
                return;
            }
            //jaren
            //if #meetingen per dag <= #jaar per dag => voeg jaren toe
            //kleiner of gelijk aan, omdat het nog net past bij gelijk aan
            if (meetingenPerDag <= 1 / 365 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 0;
                indexGevonden = true;
            }
            //maanden
            //if #meetingen per dag <= #maanden per dag => voeg maanden toe
            if (meetingenPerDag <= 1 / (365 / 12) && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 0;
                indexGevonden = true;
            }
            //weken
            //if #meetingen per dag <= #weken per dag => voeg weken toe
            if (meetingenPerDag <= 1 / (365 / 12) && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 0;
                indexGevonden = true;
            }
            //dagen
            //if #meetingen per dag <= #dagen per dag => voeg dagen toe
            if (meetingenPerDag <= 1 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 0;
                indexGevonden = true;
            }
            //uren
            //if #meetingen per dag <= #uren per dag => voeg uren toe
            if (meetingenPerDag <= 24 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 1;
                indexGevonden = true;
            }
            //minuten
            //if #meetingen per dag <= #minuten per dag => voeg minuten toe
            if (meetingenPerDag <= 24 * 60 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 2;
                indexGevonden = true;
            }
            //seconden
            //if #meetingen per dag <= #seconden per dag => voeg seconden toe
            if (meetingenPerDag <= 24 * 60 * 60 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 3;
                indexGevonden = true;
            }
            //milliseconden
            //if #meetingen per dag <= #ms per dag => voeg milliseconden toe
            if (meetingenPerDag <= 24 * 60 * 60 * 60 && indexGevonden == false)
            {
                indexIntervalTussenMeetingen = 4;
                indexGevonden = true;
            }

            //genereer de meetingen
            while (huidigeDatum <= eindDatum)
            {
                //de grondvochtigheid wordt 2x random bepaald
                AddMeetingDB(huidigeDatum, GenereerGetal(LIMin, LIMax, LIAD), GenereerGetal(TMin, TMax, TAD), GenereerGetal(LVMin, LVMax, LVAD), GenereerGetal(GVMin, GVMax, GVAD), GenereerGetal(GVMin, GVMax, GVAD));

                switch (indexIntervalTussenMeetingen)
                {
                    //OOK BIJ JAREN, WEKEN EN MAANDEN GWN DAGEN TOEVOEGEN
                    case 0:
                        huidigeDatum = huidigeDatum.AddDays(1 / meetingenPerDag);
                        break;
                    //uren
                    case 1:
                        huidigeDatum = huidigeDatum.AddHours(24 / meetingenPerDag);
                        break;
                    //minuten
                    case 2:
                        huidigeDatum = huidigeDatum.AddMinutes((24 * 60) / meetingenPerDag);
                        break;
                    //seconden
                    case 3:
                        huidigeDatum = huidigeDatum.AddSeconds((24 * 60 * 60) / meetingenPerDag);
                        break;
                    //milliseconden
                    case 4:
                        huidigeDatum = huidigeDatum.AddMilliseconds((24 * 60 * 60 * 60) / meetingenPerDag);
                        break;
                }
            }
        }

        //genereer een willekeurig getal met een aantal decimalen
        private float GenereerGetal(int min, int max, int aantalDecimalen)
        {
            Random random = new Random();
            //bv: 47.
            string Getal = random.Next(min, max).ToString() + ".";

            for (int i = 0; i < aantalDecimalen; i++)
            {
                Getal += random.Next(0, 9).ToString();
            }
            //bv: 47.21735
            return (float)Convert.ToDouble(Getal);
        }
    }
}