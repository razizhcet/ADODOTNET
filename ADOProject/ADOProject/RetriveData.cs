using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOProject
{
    class RetriveData
    {
        public static void Retrive()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source=.\RAZISQL;persist security info=true;user id=sa;password=gb2266");

                SqlCommand cmd = new SqlCommand("select * from employee", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while(sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["join_date"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            Retrive();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
