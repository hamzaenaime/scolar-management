﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProfApp.Controllers {
    public abstract class Mysql {
        private string BD;
        private string Pass;
        private string User;
        private string server;
        private MySqlConnection con;
        private MySqlCommand st;
        private MySqlDataReader rs;


        protected Mysql(string server, string BD, string User, string Pass) {
            this.BD = BD;
            this.Pass = Pass;
            this.User = User;
            this.server = server;
            Initialize();
        }


        public virtual List<Dictionary<string, string>> Get(string sql) {


            if (OpenConnection() == true) {
                try {
                    DataTable schemaTable;
                    //create mysql command
                    st = new MySqlCommand(sql, con);
                    //Assign the query using CommandText
                    //st.CommandText = sql;
                    //Assign the connection using Connection
                    //st.Connection = con;

                    //result 

                    List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();


                    //Execute query
                    rs = st.ExecuteReader();

                    //Retrieve column schema into a DataTable.
                    schemaTable = rs.GetSchemaTable();

                    while (rs.Read()) {
                        int i = 0;
                        Dictionary<string, string> column = new Dictionary<string, string>();
                        foreach (DataRow myField in schemaTable.Rows) {
                            column.Add(myField["ColumnName"].ToString(), rs[i].ToString());
                            i++;


                        }
                        result.Add(column);


                    }
                    //close connection
                    CloseConnection();

                    return result;


                } catch (Exception e) {
                    //MessageBox.Show(e.Message);
                }

            }
            return null;
        }

        public int Up(string sql) {
            if (OpenConnection() == true) {
                try {
                    //create mysql command
                    st = new MySqlCommand(sql, con);
                    //Assign the query using CommandText



                    //Execute query
                    int c = st.ExecuteNonQuery();

                    //close connection
                    CloseConnection();
                    return c;

                    //return result;



                } catch (Exception e) {
                    //MessageBox.Show(e.Message);
                }

            }
            return 0;

        }

        private void Initialize() {
            string connectionString;
            connectionString = @"Server=" + server + ";Database=" + BD + ";Uid=" + User + ";Pwd=" + Pass + ";";

            con = new MySqlConnection(connectionString);
        }

        private bool OpenConnection() {
            try {
                con.Open();
                return true;
            } catch (MySqlException ex) {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number) {
                    case 0:
                        //MessageBox.Show(ex.Message);
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection() {
            try {
                con.Close();
                return true;
            } catch (MySqlException ex) {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


    }



}

