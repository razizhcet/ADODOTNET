using System;
using System.Data;
using System.Data.SqlClient;
namespace ADOProject
{
    /// <summary>
    /// This is a Class
    /// "T:ADOProject.DataSet"
    /// </summary>
    class Dataset
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Dataset));

        /// <summary>
        /// "M:ADOProject.DataSet.Connecting()"
        /// </summary>
        public void Connecting()
        {
            try
            {
                Console.Write("Enter Table Name : ");
                string tname = Console.ReadLine();

                string constring = @"Data Source=.\RAZISQL;"
                                   + "Persist Security Info=True;User ID=sa;Password=gb2266";

                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter ad = new SqlDataAdapter("Select * from " + tname, con);
                DataSet ds = new DataSet();
                ad.Fill(ds, tname);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            object item = row[column];
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine("");
                    }
                }
            }
            catch (SqlException ex)
            {
                log.Error(ex.Message);
            }




        }

        /// <summary>
        /// This is a main method entry point of Program
        /// "M:ADOProject.DataSet.Main(system.string)"
        /// </summary>
        /// <param name="args"> it is string array</param>
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            new Dataset().Connecting();
            Console.ReadKey();
        }
    }
}