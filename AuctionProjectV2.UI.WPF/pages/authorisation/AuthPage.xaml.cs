using AuctionProjectV2.Core.Model;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {        
        private static string role;
        public AuthPage(string Role)
        {
            InitializeComponent();

            role = Role;

            if (Role == "User")
            {
                linkRegistrtion.NavigateUri = new Uri("RegistrationUserPage.xaml", UriKind.RelativeOrAbsolute);
            }
            else if (Role == "Admin")
            {
                linkRegistrtion.NavigateUri = new Uri("RegistrationAdminPage.xaml", UriKind.RelativeOrAbsolute);
            }
        }

        private void btnEnterToMainPage_Click(object sender, RoutedEventArgs e)
        {
            if (role == "User")
            {
                var users = CustomerService.ReturnAllCustomers();
                CUSTOMER user = CustomerService.FindCustomerByUserInfoId(UserInfoService.LogIn(tbxLogin.Text, tbxPassword.Password).ID);

                if (user == null)
                {
                    MessageBox.Show("Wrong Password or Login!");
                }
                else
                {
                    HomePage page = new HomePage(user);
                    MainWindow._MainFrame.NavigationService.Navigate(page);
                }
            }
            else if (role == "Admin")
            {
                USER_INFO admin = UserInfoService.LogIn(tbxLogin.Text, tbxPassword.Password);
                if (admin == null)
                {
                    MessageBox.Show("Wrong Password or Login!");
                }
                else
                {
                    HomeAdminPage page = new HomeAdminPage(admin);
                    MainWindow._MainFrame.NavigationService.Navigate(page);
                }
            }
        }
    }
}
