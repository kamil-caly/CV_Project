using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_man
{
    class Issue : Books
    {
        public string query { get; set; }
        public DataTable table { get; set; }
        public SqlDataReader reader { get; set; }

        public override void searchBook(TextBox search, DataGridView dataGrid)
        {
            base.searchBook(search, dataGrid);
        }

        public void fillAdapterFromDataSet(string query)
        {
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(command);
            set = new DataSet();
            adapter.Fill(set);
        }

        public void fillAdapterFromDataTable(string query)
        {
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
        }
        public void loadSudentsToCombo(ComboBox combo)
        {
            try
            {
                query = "select * from Students";
                fillAdapterFromDataTable(query);
                combo.DataSource = table;
                combo.DisplayMember = "Indeks"; 
                combo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void setStudentIntoTextBoxes(ComboBox combo, TextBox id, TextBox name, TextBox surname, TextBox indeks, TextBox email)
        {
            query = "select * from Students where Indeks = '" + combo.Text + "'";
            command = new SqlCommand(query, conn);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                id.Text = reader["Id"].ToString();
                name.Text = reader["Name"].ToString();
                surname.Text = reader["Surname"].ToString();
                indeks.Text = reader["Indeks"].ToString();
                email.Text = reader["Email"].ToString();
            }

        }

        public void issueBook(ComboBox Indekscombo, TextBox titleBook)  
        {
            try
            {
                string addQuery = $"insert into Issued_books(Student_indeks, Student_name, Student_surname, Book_id, Book_name, Issue_data) select '{Indekscombo.Text}', Students.Name, Students.Surname, Books.Id, '{titleBook.Text}', '{DateTime.Now.ToString()}' from Books, Students where Books.Title = '{titleBook.Text}' and Students.Indeks = '{Indekscombo.Text}'";
                command = new SqlCommand(addQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Book: " + titleBook.Text + " issued to Student: "+ Indekscombo.Text+ ".", "library_man", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool canStudentIssueABook(ComboBox Indekscombo)
        {
            try
            {
                string checkQuery = $"select * from Issued_books where Student_indeks = '{Indekscombo.Text}'";
                fillAdapterFromDataSet(checkQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (set.Tables[0].Rows.Count < 3) // max three books to issue
                return true;
            else
                return false;
        }

        public bool doIssueTheSameBook(ComboBox Indekscombo, TextBox titleBook)
        {
            try
            {
                string checkQuery = $"select * from Issued_books where Student_indeks = '{Indekscombo.Text}' and Book_name = '{titleBook.Text}'";
                fillAdapterFromDataSet(checkQuery);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(set.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void deleteIssue(TextBox Indeks, TextBox titleBook)
        {
            try
            {
                string query = $"delete top (1) from Issued_books where Student_indeks = '{Indeks.Text}' and Book_name = '{titleBook.Text}'";
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool checkDoesStudentHasThisBook(ComboBox Indekscombo, TextBox titleBook)
        {
            if(doIssueTheSameBook(Indekscombo, titleBook))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void loadIssuedBooks(DataGridView dataGrid)
        {
            try
            {
                string query = "select * from Issued_books";
                fillAdapterFromDataTable(query);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
