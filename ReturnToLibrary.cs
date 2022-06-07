using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_man
{
    class ReturnToLibrary : Issue
    {   
        public override void searchBook(TextBox indeks, DataGridView dataGrid)
        {
            try
            {
                string query = $"select Book_id, Book_name, Issue_data from Issued_books where Student_indeks = '{indeks.Text}'";
                fillAdapterFromDataTable(query);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void returnBook(TextBox indeks, TextBox book)
        {
            try
            {
                string query = $"insert top (1) into Returned_books(Student_indeks, Student_name, Student_surname, Book_id, Book_name, Issued_data, Returned_data) select '{indeks.Text}', Issued_books.Student_name, Issued_books.Student_surname, Issued_books.Book_id, '{book.Text}', Issued_books.Issue_data, '{DateTime.Now.ToString()}' from Issued_books where Issued_books.Student_indeks = '{indeks.Text}' and Issued_books.Book_name = '{book.Text}'";
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Book: " + book.Text + " returned by " + indeks.Text + ".", "library_man", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadRerunedBooks(DataGridView dataGrid)
        {
            try
            {
                string query = "select * from Returned_books";
                fillAdapterFromDataTable(query);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void deleteFromReturnHistory(TextBox id)
        {
            try
            {
                string query = $"delete from Returned_books where Id = '{id.Text}'";
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Row with id: "+ id.Text + " successfully removed.", "library_man", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_man", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void searchReturnHistory(List<TextBox> list, DataGridView dataGrid)
        {
            try
            {
                string query = $"select Id, Student_indeks, Student_name, Student_surname, Book_id, Book_name, Issued_data, Returned_data from Returned_books where Id like '%{list[0].Text}%' or Student_indeks like '%{list[0].Text}%' or Student_name like '%{list[0].Text}%' or Student_surname like '%{list[0].Text}%' or Book_id like '%{list[0].Text}%' or Book_name like '%{list[0].Text}%' or Issued_data like '%{list[0].Text}%' or Returned_data like '%{list[0].Text}%'";
                fillAdapterFromDataTable(query);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "library_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
