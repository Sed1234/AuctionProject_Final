using AuctionProjectV2.Core.Model;
using AuctionProjectV2.Service.Auction;
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

namespace AuctionProjectV2.UI.WPF.pages.application
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        Mapping mapping = new Mapping();
        CUSTOMER CustUser = new CUSTOMER();
        public HomePage(CUSTOMER user)
        {
            var list = mapping.AUCTION.ToList();

            InitializeComponent();
            lvAuctions.ItemsSource = list;
            CustUser = user;
        }

        private void btnOpenAuction_Click(object sender, RoutedEventArgs e)
        {
            OpenAuctionPage page = new OpenAuctionPage(CustUser);
            MainWindow._MainFrame.NavigationService.Navigate(page);
        }
    }
}
