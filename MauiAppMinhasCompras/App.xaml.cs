using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper db;
   

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (db == null)
                {
                   string path = Path.Combine(
                       Environment.GetFolderPath(
                           Environment.SpecialFolder.LocalApplicationData),
                       "banco_sqlite_compras.db3");

                   db = new SQLiteDatabaseHelper(path);
                }

                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
           
        }
    }
}
