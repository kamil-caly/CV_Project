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
    public partial class ViewStudents : Form
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
        public ViewStudents()
        {
            InitializeComponent();
            students.openConn();
            students.loadDB(dataGridViewStudents);
            students.closeConn();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.clearText();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellClick(e, dataGridViewStudents);
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            students.openConn();
            students.searchStudent(searchTb, dataGridViewStudents);
            students.closeConn();
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            students.openConn();
            students.loadDB(dataGridViewStudents);
            students.closeConn();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy usunąć studenta o Id: " + idTb.Text, "Student_db", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                students.openConn();
                students.deleteStudent(idTb);
                students.loadDB(dataGridViewStudents);
                students.closeConn();
            }
        }

            private void updateB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy nadpisać studenta o Id: " + idTb.Text, "Student_db", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                students.openConn();
                students.updateStudent(idTb, nameTb, surnameTb, indexTb, emailTb);
                students.loadDB(dataGridViewStudents);
                students.closeConn();
            }
        }
    }
}
