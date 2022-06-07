using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_man
{
    class Books : BooksDB, IBooks
    {    
        public void addBook(TextBox id, TextBox author, TextBox title, TextBox price)
        {
            try
            {
                string addQuery = $"insert into Books(Id, Title, Author, Price) VALUES ('{id.Text}', '{title.Text}','{author.Text}', '{price.Text}')";
                command = new SqlCommand(addQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie dodano książkę o Id = : " + id.Text + ".", "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void updateBook(TextBox id, TextBox author, TextBox title, TextBox price)
        {
            try
            {
                string upQuery = $"update Books set Title = '{title.Text}', Author = '{author.Text}', Price = '{price.Text}' where Id = '{id.Text}'";
                command = new SqlCommand(upQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie nadpisano książkę o Id = : " + id.Text + ".", "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void deleteBook(TextBox id)
        {
            try 
            { 
                string delQuery = $"delete from Books where Id = '{id.Text}'";
                command = new SqlCommand(delQuery, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie usunięto książkę o Id = : " + id.Text + ".", "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public virtual void searchBook(TextBox search, DataGridView dataGrid)
        {
            try
            {
                adapter = new SqlDataAdapter($"select * from Books where Id like '%{search.Text}%' or Title like '%{search.Text}%' or Author like '%{search.Text}%' or Price like '%{search.Text}%'", conn);
                setDataGrid(dataGrid, adapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Books_db", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
