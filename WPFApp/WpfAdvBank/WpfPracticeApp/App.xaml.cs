using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Navigation;

namespace WpfPracticeApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);
            var navWin = new MetroNavigationWindow();
            navWin.Title = @"WPF BikeShop";
            navWin.Show();
            navWin.Navigate(new MainMenu());
        }
    }
}
