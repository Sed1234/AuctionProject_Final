using AuctionProjectV2.Core.Model;
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
    /// Логика взаимодействия для HomeAdminPage.xaml
    /// </summary>
    public partial class HomeAdminPage : Page
    {
        public HomeAdminPage(USER_INFO admin)
        {
            InitializeComponent();
        }
    }
}
