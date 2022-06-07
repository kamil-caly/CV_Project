using System.Windows.Forms;

namespace library_man
{
    interface IStudents
    {
        void addStudenst(TextBox id, TextBox name, TextBox surname, TextBox index, TextBox email);
        void updateStudent(TextBox id, TextBox name, TextBox surname, TextBox index, TextBox email);
        void deleteStudent(TextBox id);
        void searchStudent(TextBox search, DataGridView dataGrid);
    }
}
