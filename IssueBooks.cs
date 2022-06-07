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
    public partial class IssueBooks : Form
    {
        Issue issue = new Issue();

        public void clearStudentsTextBoxesAndCombobox()
        {
            studentId.Text = "";
            studentName.Text = "";
            studentSurname.Text = "";
            studentIndeks.Text = "";
            studentEmail.Text = "";
            chooseStudentCombo.Text = "";
        }

        public void cellClick(DataGridViewCellEventArgs ee, DataGridView dt)
        {
            bookToIssueTb.Text = dt.Rows[ee.RowIndex].Cells[1].Value.ToString();
        }

        public IssueBooks()
        {
            InitializeComponent();
            issue.openConn();
            issue.loadDB(BooksView);
            issue.loadSudentsToCombo(chooseStudentCombo);
            issue.closeConn();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            issue.openConn();
            issue.searchBook(searchBooksTb, BooksView);
            issue.closeConn();
        }

        private void chooseStudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            issue.openConn();
            issue.setStudentIntoTextBoxes(chooseStudentCombo, studentId, studentName, studentSurname, studentIndeks, studentEmail);
            issue.closeConn();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearStudentsTextBoxesAndCombobox();
        }

        private void clearBooksBn_Click(object sender, EventArgs e)
        {
            issue.loadDB(BooksView);
            searchBooksTb.Text = "";
        }

        private void searchStudentBn_Click(object sender, EventArgs e)
        {
            issue.openConn();
            issue.setStudentIntoTextBoxes(chooseStudentCombo, studentId, studentName, studentSurname, studentIndeks, studentEmail);
            issue.closeConn();
        }

        private void BooksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, BooksView);
        }

        private void issueBn_Click(object sender, EventArgs e)
        {
            issue.openConn();
            if (issue.canStudentIssueABook(chooseStudentCombo))
                if(issue.doIssueTheSameBook(chooseStudentCombo, bookToIssueTb))
                {
                    if(MessageBox.Show("Do you want issue the same Book which you issued before?", "library_man", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        issue.issueBook(chooseStudentCombo, bookToIssueTb);
                    }
                }
                else
                {
                    issue.issueBook(chooseStudentCombo, bookToIssueTb);
                }
            else
                MessageBox.Show("Cannot issue more than 3 books!", "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            issue.closeConn();
        }
    }
}
