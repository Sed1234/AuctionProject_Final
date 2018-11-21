using AuctionProjectV2.Service;
using AuctionProjectV2.UI.WPF.pages.application;
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
    /// Логика взаимодействия для RegistrationAdminPage.xaml
    /// </summary>
    public partial class RegistrationAdminPage : Page
    {
        public RegistrationAdminPage()
        {
            InitializeComponent();
        }

        private void btnSaveAdminToDb_Click(object sender, RoutedEventArgs e)
        {
            if (tbxPassword.Password == tbxPaswordTwo.Password)
            {
                var NewUser = UserInfoService.AddUserInfoToDb(tbxLogin.Text, tbxPassword.Password, "admin");
                HomeAdminPage page = new HomeAdminPage(NewUser);
                MainWindow._MainFrame.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("Password Validation");
            }

        }
    }
}
