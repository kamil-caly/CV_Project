using System;
using System.Windows.Forms;

namespace library_man
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Library", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            viewStudents.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }

        private void completeBooksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void issuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_history iHistory = new Issue_history();
            iHistory.Show();
        }

        private void returnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returned_history rHistory = new Returned_history();
            rHistory.Show();
        }
    }
}
