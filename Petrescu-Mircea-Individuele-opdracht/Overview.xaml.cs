using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Window
    {


        public Overview()
        {
            InitializeComponent();


        }




        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnDatabeheer_Click(object sender, RoutedEventArgs e)
        {
            Databeheer databeheer = new Databeheer();
            databeheer.Show();

        }




        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void btnProducten_Click(object sender, RoutedEventArgs e)
        {
            List<Product> ListOfProducts = null;
            ListOfProducts = DataManager.GetProducts();
            foreach (Product p in ListOfProducts)
            {
                dgShow.ItemsSource = ListOfProducts;
            }
        }

        private void btnKlanten_Click(object sender, RoutedEventArgs e)
        {
            List<Klant> ListOfClients = null;
            ListOfClients = DataManager.GetClients();
            foreach (Klant k in ListOfClients)
            {
                dgShow.ItemsSource = ListOfClients;
            }
        }

        private void btnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            Bestellingen bestellingen = new Bestellingen();

            List<Bestelling> ListOfOrders = null;
            ListOfOrders = DataManager.GetOrders();
            foreach (Bestelling b in ListOfOrders)
            {
                dgShow.ItemsSource = ListOfOrders;
            }
        }

        private void btnLeveranciers_Click(object sender, RoutedEventArgs e)
        {
            Leveranciers leveranciers = new Leveranciers();

            List<Leverancier> ListOfSuppliers = null;
            ListOfSuppliers = DataManager.GetSuppliers();
            foreach (Leverancier l in ListOfSuppliers)
            {
                dgShow.ItemsSource = ListOfSuppliers;
            }




        }

        private void btnLoguit_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnBestelling_Click(object sender, RoutedEventArgs e)
        {
            MaakBestelling maak = new MaakBestelling();
            maak.Show();
        }
    }



}
