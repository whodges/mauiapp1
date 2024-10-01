namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Windows[0].Page = new AppShell();
        }
    }
}
