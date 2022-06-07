using System;
using System.Windows.Forms;

namespace library_man
{
    public partial class Form1 : Form
    {
        LoginDB logindb = new LoginDB();
        public Form1()
        {
           InitializeComponent();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.clearTexboxes();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            if (doExit())
                this.Close();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (this.loginBox.Text == "" || this.passwordBox.Text == "")
                emptyBoxes();
            else
            {
                logindb.openConn();
                logindb.loadDB(this.loginBox.Text, this.passwordBox.Text);
                if (logindb.checkLoginPass())
                {
                    this.Hide();
                    menu m = new menu();
                    m.Show();
                }
                logindb.closeConn();
            }
        }
    }
}
