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
    /// Логика взаимодействия для OpenAuctionPage.xaml
    /// </summary>
    public partial class OpenAuctionPage : Page
    {
        AUCTION auction = new AUCTION();
        Mapping mapping = new Mapping();
        CUSTOMER CusUser = new CUSTOMER();
        public OpenAuctionPage(CUSTOMER user)
        {
            InitializeComponent();
            cbxCategoriesList.ItemsSource = mapping.CATEGORY.ToList();
            auction.CUSTID = user.ID;
            CusUser = user;
        }

        private void btnSaveAuctionToDb_Click(object sender, RoutedEventArgs e)
        {
            if (rbActive.IsChecked == true)
            {
                auction.STATUS = "Active";
            }
            else
            {
                auction.STATUS = "Inactive";
            }
            if (AuctionService.OpenAuction(tbxDescription.Text, (int)auction.CATEGORY_ID, (Guid)auction.CUSTID, (DateTime)tbxStartDate.SelectedDate,
                 (DateTime)tbxFinalDate.SelectedDate, Convert.ToDouble(tbxStartPrice.Text),
                 Convert.ToDouble(tbxStepOfAuction.Text), tbxFoB.Text, tbxAddress.Text, auction.STATUS) != null)
            {
                HomePage page = new HomePage(CusUser);
                MainWindow._MainFrame.NavigationService.Navigate(page);
            }
        }

        private void cbxCategoriesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            CATEGORY selectedItem = (CATEGORY)comboBox.SelectedItem;
            auction.CATEGORY_ID = selectedItem.ID;         
        }
    }
}
