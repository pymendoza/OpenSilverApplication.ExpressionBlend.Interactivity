using System.Windows;

namespace OpenSilverApplication.ExpressionBlend
{
    public sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            var mainPage = new MainPage();
            Window.Current.Content = mainPage;
        }
    }
}