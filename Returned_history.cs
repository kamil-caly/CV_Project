using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace library_man
{
    public partial class Returned_history : Form
    {
        ReturnToLibrary returnBookObj = new ReturnToLibrary();
        private List<TextBox> list1;

        public Returned_history()
        {
            InitializeComponent(); //Wszystkie metody, kolekcje itd. z kontrolkami wystepujacymi w tej klasie 
                                   //musza być pod tą metodą!

            list1 = new List<TextBox> {searchText, studentIdText, studentIndeksText, studentNameText,
            studentSurnameText, bookIdText, bookNameText, issuedDataText, returnedDataText};
            returnBookObj.openConn();
            returnBookObj.loadRerunedBooks(returnedGridView);
            returnBookObj.closeConn();
        }
        public void cellClick(DataGridViewCellEventArgs ee, DataGridView dt)
        {
            int i = 0; 
            foreach (var element in list1)
            {
                if (list1.IndexOf(element) != 0)
                { 
                    element.Text = dt.Rows[ee.RowIndex].Cells[i].Value.ToString();
                    i++;
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            returnBookObj.openConn();
            returnBookObj.loadRerunedBooks(returnedGridView);
            returnBookObj.closeConn();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to permanently delete this row?", "library_db", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                returnBookObj.openConn();
                returnBookObj.deleteFromReturnHistory(studentIdText);
                returnBookObj.loadRerunedBooks(returnedGridView);
                returnBookObj.closeConn();
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            returnBookObj.openConn();
            returnBookObj.searchReturnHistory(list1, returnedGridView);
            returnBookObj.closeConn();
        }

        private void returnedGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, returnedGridView);
        }
    }
}
