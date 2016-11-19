using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.DB
{
    public static class Db_misc
    {

        public static void test1()
        {
            using (var conn = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=Garda.CashTrackNG.Data.CashTrak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                var dt = new DataTable();

                using (var cmd = new SqlCommand())
                {
                    cmd.Parameters.AddWithValue("@ID", 1);
                   cmd.CommandText = "Select * From route WHERE ID=@ID";
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                }
            }
        }
    }
}
