using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_man
{
    public partial class AddBooks : Form
    {
        Books books = new Books();
        public void clearText()
        {
            idTb.Text = "";
            authorTb.Text = "";
            titleTb.Text = "";
            priceTb.Text = "";
        }
        public void cellClick(DataGridViewCellEventArgs ee, DataGridView dt)
        {
            idTb.Text = dt.Rows[ee.RowIndex].Cells[0].Value.ToString();
            titleTb.Text = dt.Rows[ee.RowIndex].Cells[1].Value.ToString();
            authorTb.Text = dt.Rows[ee.RowIndex].Cells[2].Value.ToString();
            priceTb.Text = dt.Rows[ee.RowIndex].Cells[3].Value.ToString();
        }
        public AddBooks()
        {
            InitializeComponent();
            books.openConn();
            books.loadDB(dataGridAddBooks);
            books.closeConn();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            books.openConn();
            books.addBook(idTb, authorTb, titleTb, priceTb);
            books.loadDB(dataGridAddBooks);
            books.closeConn();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearText();
        }

        private void dataGridAddBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, dataGridAddBooks);
        }
    }
}
