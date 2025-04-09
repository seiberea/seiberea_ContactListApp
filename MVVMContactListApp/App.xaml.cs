using MVVMContactListApp.Views;

namespace MVVMContactListApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainContactPage());
        }
    }
}
