using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Greenhouse
{
    class DatabaseIO
    {
        //Metingen Veriabele
        private DateTime datumtijd;
        private float lichtintensietijd;
        private float temperatuur;
        private float grondvochtigheidp1;
        private float grondvochtigheidp2;

        public List<DateTime> datumtijdls = new List<DateTime>();
        public List<float> lichtintensietijdls = new List<float>();
        public List<float> temperatuurls = new List<float>();
        public List<float> grondvochtigheidp1ls = new List<float>();
        public List<float> grondvochtigheidp2ls = new List<float>();


        //Plant Variabele
        private string plantnaam;
        private float benodigdwaterdagml;
        private string plantsoort;

        public List<string> plantnaamls = new List<string>();
        public List<float> benodigdwaterdagmlls = new List<float>();
        public List<string> plantsoortls = new List<string>();


        //Connectionstring database
        const string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";

        public DatabaseIO(float Temperatuur, float Lichtintensietijd, float Grondvochtigheidp1, float Grondvochtigheidp2, DateTime DatumTijd)
        {
            //Set globale variabele naar een lokale
            temperatuur = Temperatuur;
            grondvochtigheidp1 = Grondvochtigheidp1;
            grondvochtigheidp2 = Grondvochtigheidp2;
            datumtijd = DatumTijd;
            lichtintensietijd = Lichtintensietijd;
        }

        public DatabaseIO(string Naam, float Benodigdwaterdagml, string Plantsoort)
        {
            //Set globale variabele naar een lokale
            plantnaam = Naam;
            benodigdwaterdagml = Benodigdwaterdagml;
            plantsoort = Plantsoort;
        }

        public DatabaseIO()
        {

        }

        public void Opslaan()
        {
            //Gegeven data vanuit eerste constructor op slaan in tabel "Meetgegevens"
            try{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "insert into Meetgegevens ([datetime], [lichtintensietijd],[temperatuur],[grondvochtigheidp1],[grondvochtigheidp2]) values (@datetime, @lichtintensietijd, @temperatuur, @grondvochtigheidp1, @grondvochtigheidp2)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@datetime", datumtijd);
                        cmd.Parameters.AddWithValue("@lichtintensietijd", lichtintensietijd);
                        cmd.Parameters.AddWithValue("@temperatuur", temperatuur);
                        cmd.Parameters.AddWithValue("@grondvochtigheidp1", grondvochtigheidp1);
                        cmd.Parameters.AddWithValue("@grondvochtigheidp2", grondvochtigheidp2);
                        cmd.ExecuteNonQuery();                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DeletePlant(string _Plantnaam)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "delete from Plant where Naam = " + _Plantnaam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void OpslaanPlant()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int id = 0;
                    string queryId = "select max(id) from Plant";
                    using (SqlCommand scmd = new SqlCommand(queryId, conn))
                    {
                        using (SqlDataReader reader = scmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    id = reader.GetInt32(0) + 1;
                                }
                                catch 
                                {

                                }
                                
                            }
                        }
                    }


                    string query = "insert into Plant ([Id], [Naam], [Benodigdwaterdagml], [Plantsoort]) values (@Id, @Naam, @Benodigdwaterdagml, @Plantsoort)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Naam", plantnaam);
                        cmd.Parameters.AddWithValue("@Benodigdwaterdagml", benodigdwaterdagml);
                        cmd.Parameters.AddWithValue("@Plantsoort", plantsoort);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Leesgegevens(DateTime _DateTime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //Select alle data met huidige datum
                    string query = "select * from [Meetgegevens] where DateTime = " + _DateTime.ToShortDateString() + " order by Datetime ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datumtijdls.Add(reader.GetDateTime(0));
                            lichtintensietijdls.Add(reader.GetFloat(1));
                            temperatuurls.Add(reader.GetFloat(2));
                            grondvochtigheidp1ls.Add(reader.GetFloat(3));
                            grondvochtigheidp2ls.Add(reader.GetFloat(4));

                            Console.WriteLine("Dataline saved");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReadPlant()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select Naam, Benodigdwaterdagml, Plantsoort from [Plant]";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            plantnaamls.Add(reader.GetString(0));
                            benodigdwaterdagmlls.Add((float)reader.GetDouble(1));
                            plantsoortls.Add(reader.GetString(2));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
