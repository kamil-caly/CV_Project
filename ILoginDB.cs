
namespace library_man
{
    interface ILoginDB
    {
        void openConn();
        void closeConn();
        void loadDB(string login, string password);
        bool checkLoginPass();
    }
}
