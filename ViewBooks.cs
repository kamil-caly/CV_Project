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
    public partial class ViewBooks : Form
    {
        //BooksDB booksDB = new BooksDB();
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
        public ViewBooks()
        {
            InitializeComponent();
            books.openConn();
            books.loadDB(dataGridViewBooks);
            books.closeConn();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, dataGridViewBooks);
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearText();
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy nadpisać książkę o Id: " + idTb.Text, "Books_db", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                books.openConn();
                books.updateBook(idTb, authorTb, titleTb, priceTb);
                books.loadDB(dataGridViewBooks);
                books.closeConn();
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy usunąć książkę o Id: " + idTb.Text, "Books_db", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                books.openConn();
                books.deleteBook(idTb);
                books.loadDB(dataGridViewBooks);
                books.closeConn();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            books.openConn();
            books.searchBook(searchTb,  dataGridViewBooks);
            books.closeConn();
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            books.openConn();
            books.loadDB(dataGridViewBooks);
            books.closeConn();
        }
    }
}
