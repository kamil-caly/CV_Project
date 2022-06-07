using System;
using System.Windows.Forms;

namespace library_man
{
    public partial class ReturnBooks : Form
    {
        ReturnToLibrary returnObj = new ReturnToLibrary();
        public void clearStudentsTextBoxesAndCombobox()
        {
            idTb.Text = "";
            nameTb.Text = "";
            surnameTb.Text = "";
            indexTb.Text = "";
            emailTb.Text = "";
            chooseStudentCombo.Text = "";
        }
        public void cellClick(DataGridViewCellEventArgs ee, DataGridView dt)
        {
            bookTb.Text = dt.Rows[ee.RowIndex].Cells[1].Value.ToString();
        }
        public ReturnBooks()
        {
            InitializeComponent();
            returnObj.openConn();
            returnObj.searchBook(indexTb, viewBooks);
            returnObj.loadSudentsToCombo(chooseStudentCombo);
            returnObj.closeConn();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearStudentsTextBoxesAndCombobox();
        }

        private void chooseStudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            returnObj.openConn();
            returnObj.setStudentIntoTextBoxes(chooseStudentCombo, idTb, nameTb, surnameTb, indexTb, emailTb);
            returnObj.closeConn();
        }

        private void indexTb_TextChanged(object sender, EventArgs e)
        {
            returnObj.openConn();
            returnObj.searchBook(indexTb, viewBooks);
            returnObj.closeConn();
        }

        private void viewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, viewBooks);
        }

        private void searchStudentBn_Click(object sender, EventArgs e)
        {
            returnObj.openConn();
            returnObj.setStudentIntoTextBoxes(chooseStudentCombo, idTb, nameTb, surnameTb, indexTb, emailTb);
            returnObj.closeConn();
        }

        private void returnBn_Click(object sender, EventArgs e)
        {
            returnObj.openConn();
            if(returnObj.checkDoesStudentHasThisBook(chooseStudentCombo, bookTb))
            {
                returnObj.returnBook(indexTb, bookTb);
                returnObj.deleteIssue(indexTb, bookTb);
                returnObj.searchBook(indexTb, viewBooks);
            }
            else
            {
                MessageBox.Show("Incorrect book or student index.", "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
