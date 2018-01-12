using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_Greenhouse
{
    class DatabaseIO
    {
        private DateTime datumtijd;
        private float lichtintensietijd;
        private float temperatuur;
        private float luchtvochtigheid;
        private float grondvochtigheidp1;
        private float grondvochtigheidp2;

        List<DateTime> datumtijdls = new List<DateTime>();
        List<float> lichtintensietijdls = new List<float>();
        List<float> temperatuurls = new List<float>();
        List<float> luchtvochtigheidls = new List<float>();
        List<float> grondvochtigheidp1ls = new List<float>();
        List<float> grondvochtigheidp2ls = new List<float>();


        const string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=../../Database1.mdf;Integrated Security=True";


        public DatabaseIO(float Temperatuur, float Luchtvochtigheid, float Grondvochtigheidp1, float Grondvochtigheidp2, DateTime DatumTijd, float Lichtintensietijd)
        {
            temperatuur = Temperatuur;
            luchtvochtigheid = Luchtvochtigheid;
            grondvochtigheidp1 = Grondvochtigheidp1;
            grondvochtigheidp2 = Grondvochtigheidp2;
            datumtijd = DatumTijd;
            lichtintensietijd = Lichtintensietijd;
        }

        private void Opslaan()
        {
            try{
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "insert into Meetgegevens ([Lichtintensietijd],[Temperatuur],[Luchtvochtigheid],[Grondvochtigheidp1],[Grondvochtigheidp2]) values (@lichtintensietijd,@temperatuur,@luchtvochtigheid,@grondvochtigheidp1,@grondvochtigheidp2)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Lichtintensietijd", lichtintensietijd);
                        cmd.Parameters.AddWithValue("@Temperatuur", temperatuur);
                        cmd.Parameters.AddWithValue("@Luchtvochtigheid", luchtvochtigheid);
                        cmd.Parameters.AddWithValue("@Grondvochtigheidp1", grondvochtigheidp1);
                        cmd.Parameters.AddWithValue("@Grondvochtigheidp2", grondvochtigheidp2);
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Data added to database");
                    }
                }
            }
            catch (Exception ex)
            {
                    Console.WriteLine("Error: " + ex);
            }
        }
        private void Leesgegevens()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from [Meetgegevens] where DateTime = " + DateTime.Today.ToLongDateString() + "order by Datetime ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datumtijdls.Add(reader.GetDateTime(0));
                            lichtintensietijdls.Add(reader.GetFloat(1));
                            temperatuurls.Add(reader.GetFloat(2));
                            luchtvochtigheidls.Add(reader.GetFloat(3));
                            grondvochtigheidp1ls.Add(reader.GetFloat(4));
                            grondvochtigheidp2ls.Add(reader.GetFloat(5));

                            Console.WriteLine("Dataline saved");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
