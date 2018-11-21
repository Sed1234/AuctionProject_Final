using AuctionProjectV2.Core.Model;
using AuctionProjectV2.Service.Auction;
using AuctionProjectV2.Service.Users;
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
    /// Логика взаимодействия для AuctionPage.xaml
    /// </summary>
    public partial class AuctionPage : Page
    {
        AUCTION auction = new AUCTION();
        public AuctionPage()
        {
            InitializeComponent();
            int catId = (int)auction.CATEGORY_ID;
            Guid guid = (Guid)auction.CUSTID;

            tbxCategory.Text = AuctionService.FindCategoryById(catId).DESCRIPTION;
            tbxDescription.Text = auction.DESCRIPTION;
            tbxAddress.Text = auction.DELIVERY_ADDRESS;
            tbxFoB.Text = auction.FOB;
            tbxStartPrice.Text = auction.START_PRICE.ToString();
            tbxStepOfAuction.Text = auction.STEP_OF_AUCTION.ToString();
            tbxStartDate.Text = auction.START_DATE.ToString();
            tbxFinalDate.Text = auction.END_DATE.ToString();
            tbxStatus.Text = auction.STATUS;
            tbxRatePrice.Text = RateService.FindRateByCustomerId(guid).SUMM.ToString();
			tbxRating.Text = RatingService.GetAllRatings().Find(x => x.CUSTOMER_ID == guid).Rating1.ToString();

        }

        private void BtnSendRate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
