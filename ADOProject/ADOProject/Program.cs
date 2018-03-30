using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOProject
{
    /// <summary>
    /// This is a Class
    /// "T:ADOProject.Program"
    /// </summary>
    class Program
    {
        /// <summary>
        /// "M:ADOProject.Program.CreateTable()"
        /// </summary>
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(@"data source=.\RAZISQL; Persist Security Info=true; User ID=sa; Password=gb2266");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table employee(id int not null, name varchar(100), email varchar(50), join_date date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        // <summary>
        /// This is a main method entry point of Program
        /// "M:ADOProject.Program.Main(system.string)"
        /// </summary>
        /// <param name="args"> it is string array</param>
        static void Main(string[] args)
        {
            Program pgm = new Program();
            pgm.CreateTable();
            Console.ReadKey();
        }
    }
}
