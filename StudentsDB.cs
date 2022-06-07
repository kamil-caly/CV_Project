using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_man
{
    class StudentsDB : BooksDB
    {
        public override void loadDB(DataGridView dataGrid)
        {
            try
            {
                adapter = new SqlDataAdapter("select * from Students", conn);
                setDataGrid(dataGrid, adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

