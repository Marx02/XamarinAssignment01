using Xamarin.Forms;
using XamarinAssignment01.Data;

namespace XamarinAssignment01
{
    public partial class App : Application
    {

        public static INoteEntryStore Entries { get; set; }
        public App()
        {
            
            InitializeComponent();

            Entries = new MemoryEntryStore();
            Entries.LoadMockData();


            MainPage = new XamarinAssignment01.MainPage();
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
