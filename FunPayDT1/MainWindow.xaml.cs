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
using FunPayDT1.FunPayMTDataSetTableAdapters;

namespace FunPayDT1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTableAdapter Clients = new ClientsTableAdapter();
        ReviewsTableAdapter Reviews = new ReviewsTableAdapter();
        SellersTableAdapter Sellers = new SellersTableAdapter(); 
        SupportEmailsTableAdapter SupportEmails = new SupportEmailsTableAdapter();
        SupportPhonesTableAdapter SupportPhones = new SupportPhonesTableAdapter();
        SupportTeamTableAdapter SupportTeams = new SupportTeamTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = Clients.GetData();
        }

        private void ReviewsButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = Reviews.GetData();
        }

        private void SellersButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = Sellers.GetData();
        }

        private void SupportEmailButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = SupportEmails.GetData();
        }

        private void SupportPhonesButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = SupportPhones.GetData();
        }

        private void SupportTeamButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = SupportTeams.GetData();
        }
    }
}

