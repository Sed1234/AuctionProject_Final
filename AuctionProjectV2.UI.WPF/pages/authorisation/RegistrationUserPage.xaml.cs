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
    /// Логика взаимодействия для RegistrationUserPage.xaml
    /// </summary>
    public partial class RegistrationUserPage : Page
    {
        public RegistrationUserPage()
        {
            InitializeComponent();
        }

        private void btnSaveUserToDb_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnJuradical.IsChecked == true)
            {
               CUSTOMER NewUser = CustomerService.AddCustomerToDb(tbxLogin.Text, tbxPassword.Password, tbxName.Text, true, tbxAddress.Text, tbxPhone.Text, 
                    tbxEmail.Text, tbxBIN_IIN.Text, tbxDescription.Text, tbxWebsite.Text);
                HomePage page = new HomePage(NewUser);
                MainWindow._MainFrame.NavigationService.Navigate(page);
            }
            else
            {
               CUSTOMER NewUser = CustomerService.AddCustomerToDb(tbxLogin.Text, tbxPassword.Password, tbxName.Text, false, tbxAddress.Text, tbxPhone.Text,
                   tbxEmail.Text, tbxBIN_IIN.Text);
                HomePage page = new HomePage(NewUser);
                MainWindow._MainFrame.NavigationService.Navigate(page);
            }
        }
    }
}
