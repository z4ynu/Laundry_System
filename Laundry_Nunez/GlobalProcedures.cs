using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PrjLaundry
{
    internal class GlobalProcedures
    {
        //global variable
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;

        public MySqlConnection conLaundry; //variable na mag gunit sa connection
        public MySqlCommand sqlCommand; // variable na mag gunit sa mga sql stats
        public string strConnection;

        // packages and classes

        public MySqlDataAdapter sqlLaundryAdapter;
        public DataTable datLaundry;

        public GlobalProcedures()
        {
            
        }

        public bool fncConnectToDatabase()
        {
            try
            {
                servername = "localhost";
                databasename = "laundry";
                username = "root";
                password = "139564";
                port = "3306";

                //implement connection
                strConnection = "Server=" + servername + ";" +
                       "Database=" + databasename + ";" +
                       "User=" + username + ";" +
                       "Password=" + password + ";" +
                       "Port=" + port + ";" +
                       "Convert Zero Datetime = true";

                conLaundry = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conLaundry);
                if (conLaundry.State == System.Data.ConnectionState.Closed)
                {
                    sqlCommand.Connection = conLaundry;
                    conLaundry.Open();
                    return true;
                }
                else
                {
                    conLaundry.Close();
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message" + err.Message);
            }
            return false;
        }

        public void checkDatabaseConnection()
        {
            GlobalProcedures proc = new GlobalProcedures();
            if (proc.fncConnectToDatabase().Equals("False"))
            {
                proc.conLaundry.Open();
            }
            else
            {
                // do nothing
            }
        }

    }
}