using S14_P4.Data;

namespace S14_P4
{
    public partial class App : Application
    {
        static DataBaseService database;

        public static DataBaseService Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "Farmacia.db3");

                    database = new DataBaseService(path);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}