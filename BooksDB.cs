using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_man
{
    class BooksDB : LoginDB
    {
        public DataTable dt { get; set; }

        public void setDataGrid(DataGridView dataGrid, SqlDataAdapter adapter)
        {
            dt = new DataTable();
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
        }
        public virtual void loadDB(DataGridView dataGrid)
        {
            try
            {
                adapter = new SqlDataAdapter("select * from Books", conn);
                setDataGrid(dataGrid, adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
