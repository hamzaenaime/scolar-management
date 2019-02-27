using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNotes;
using MySql.Data.MySqlClient;

namespace AppAdmin
{
    class Program
    {
        public static string connectionString = @"server=192.168.1.4;user id=root;database=project";
        public static MySqlConnection con = new MySqlConnection(connectionString);

        private static  bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show(ex.Message);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Container());

            RequestCondition RQ = new RequestCondition();
            string connectionString;
            string server = "192.168.1.4";
            string BD = "project";
            string User = "root";
            Object[] t = { "haha",2,3,4};
            connectionString = @"server=192.168.1.4;user id=root;database=project";
            string sql = "select * from Filieres where codef "+ RQ.Equal("g3ei");
            Console.WriteLine(sql);
            if (OpenConnection())
            {
                Console.WriteLine("connecion open");
            }
            //create mysql command
            //MySqlCommand st = new MySqlCommand();
            ////Assign the query using CommandText
            //st.CommandText = sql;
            ////Assign the connection using Connection
            //st.Connection = con;


            //Execute query
            //MySqlDataReader rs = st.ExecuteReader();

            Console.WriteLine(sql);
            //while (rs.Read())
            //{
            //int i = 0;
            //Dictionary<string, string> column = new Dictionary<string, string>();
            //foreach (DataRow myField in schemaTable.Rows)
            //{
            //    Console.WriteLine(myField["ColumnName"].ToString(), rs[i].ToString());
            //    i++;


        


            }

    }
}
