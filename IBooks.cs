using System.Windows.Forms;

namespace library_man
{
    interface IBooks
    {
        void addBook(TextBox id, TextBox author, TextBox title, TextBox price);
        void updateBook(TextBox id, TextBox author, TextBox title, TextBox price);
        void deleteBook(TextBox id);
        void searchBook(TextBox search, DataGridView dataGrid);
    }
}
