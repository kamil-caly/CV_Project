using System;
using System.Windows.Forms;

namespace library_man
{
    public partial class Issue_history : Form
    {
        Issue issuedBooks = new Issue();
        public Issue_history()
        {
            InitializeComponent();
            issuedBooks.openConn();
            issuedBooks.loadIssuedBooks(issueGridView);
            issuedBooks.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            issuedBooks.openConn();
            issuedBooks.loadIssuedBooks(issueGridView);
            issuedBooks.closeConn();
        }
    }
}
