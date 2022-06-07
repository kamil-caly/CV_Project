using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_man
{
    class Students : StudentsDB, IStudents
    {
        public void addStudenst(TextBox id, TextBox name, TextBox surname, TextBox index, TextBox email)
        {
            try
            {
                string addQuery = $"insert into Students(Id, Name, Surname, Indeks, Email) VALUES ('{id.Text}', '{name.Text}','{surname.Text}', '{index.Text}', '{email.Text}')";
                command = new SqlCommand(addQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie dodano studenta o Id = : " + id.Text + ".", "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Students_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void updateStudent(TextBox id, TextBox name, TextBox surname, TextBox index, TextBox email)
        {
            try
            {
                string upQuery = $"update Students set Name = '{name.Text}', Surname = '{surname.Text}', Indeks = '{index.Text}', Email = '{email.Text}' where Id = '{id.Text}'";
                command = new SqlCommand(upQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie nadpisano studenta o Id = : " + id.Text + ".", "Students_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void deleteStudent(TextBox id)
        {
            try
            {
                string delQuery = $"delete from Students where Id = '{id.Text}'";
                command = new SqlCommand(delQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie usunięto studenta o Id = : " + id.Text + ".", "Students_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Students_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void searchStudent(TextBox search, DataGridView dataGrid)
        {
            try
            {
                adapter = new SqlDataAdapter($"select * from Students where Id like '%{search.Text}%' or Name like '%{search.Text}%' or Surname like '%{search.Text}%' or Indeks like '%{search.Text}%' or Email like '%{search.Text}%'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Students_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
