using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADOProject
{
    class DeleteData
    {
        public static void Delete()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source=.\RAZISQL;persist security info=true;user id=sa;password=gb2266");

                SqlCommand cmd = new SqlCommand("delete from employee where id = '103'", con);

                con.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("record deleted successfully");
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
            Delete();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
