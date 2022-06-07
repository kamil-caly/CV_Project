using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace library_man
{
    class LoginDB : ILoginDB
    {
        public SqlConnection conn { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataAdapter adapter { get; set; }
        public DataSet set { get; set; }

        public string connectionString { get; set; }

        public void openConn()
        {
            try
            {
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL_kammex\Documents\libraryDB.mdf;Integrated Security=True;Connect Timeout=30";
                conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void closeConn()
        {
            try
            {
                if(conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDB(string login, string password)
        {
            try
            {
                string loginQuery = "select * from logowanie where login = '" + login + "' and password = '" + password + "'";
                command = new SqlCommand(loginQuery, conn);
                adapter = new SqlDataAdapter(command);
                set = new DataSet();
                adapter.Fill(set);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkLoginPass()
        {
            if (set.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
