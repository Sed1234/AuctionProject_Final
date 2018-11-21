using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuctionProjectV2.UI.WPF.pages.authorisation
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnEnterAsAdmin_Click(object sender, RoutedEventArgs e)
        {
            AuthPage page = new AuthPage("Admin");
            MainWindow._MainFrame.NavigationService.Navigate(page);
        }

        private void btnEnterAsUser_Click(object sender, RoutedEventArgs e)
        {
            AuthPage page = new AuthPage("User");
            MainWindow._MainFrame.NavigationService.Navigate(page);
        }
    }
}
