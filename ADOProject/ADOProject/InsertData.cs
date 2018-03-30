using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOProject
{
    class InsertData
    {
        public static void Insert()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source=.\RAZISQL;persist security info=true;user id=sa;password=gb2266");

                SqlCommand cmd1 = new SqlCommand("insert into employee(id, name, email, join_date)values('102', 'Murali', 'murali@gmail.com', '03/12/2018')", con);
                SqlCommand cmd2 = new SqlCommand("insert into employee(id, name, email, join_date)values('103', 'Yashwant', 'yashwant@yahoo.com', '04/15/2018')", con);

                con.Open();

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                Console.WriteLine("record inserted successfully");
            }
            catch(Exception ex)
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
            Insert();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
