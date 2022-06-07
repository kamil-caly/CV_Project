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
    public partial class AddStudent : Form
    {
        Students students = new Students();
        public void clearText()
        {
            idTb.Text = "";
            nameTb.Text = "";
            surnameTb.Text = "";
            indexTb.Text = "";
            emailTb.Text = "";
        }
        public void cellClick(DataGridViewCellEventArgs ee, DataGridView dt)
        {
            idTb.Text = dt.Rows[ee.RowIndex].Cells[0].Value.ToString();
            nameTb.Text = dt.Rows[ee.RowIndex].Cells[1].Value.ToString();
            surnameTb.Text = dt.Rows[ee.RowIndex].Cells[2].Value.ToString();
            indexTb.Text = dt.Rows[ee.RowIndex].Cells[3].Value.ToString();
            emailTb.Text = dt.Rows[ee.RowIndex].Cells[4].Value.ToString();
        }
        public AddStudent()
        {
            InitializeComponent();
            students.openConn();
            students.loadDB(dataGridAddStudents);
            students.closeConn();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearText();
        }

        private void dataGridAddBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, dataGridAddStudents);
        }

        private void addB_Click(object sender, EventArgs e)
        {
            students.openConn();
            students.addStudenst(idTb, nameTb, surnameTb, indexTb, emailTb);
            students.loadDB(dataGridAddStudents);
            students.closeConn();
        }
    }
}
