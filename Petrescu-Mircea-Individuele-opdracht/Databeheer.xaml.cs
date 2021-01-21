using System.Windows;
using System.Windows.Input;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Databeheer.xaml
    /// </summary>
    public partial class Databeheer : Window
    {
        public Databeheer()
        {
            InitializeComponent();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnProducten_Click(object sender, RoutedEventArgs e)
        {
            Producten product = new Producten();
            product.Show();
        }

        private void btnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            Bestellingen bestellingen = new Bestellingen();
            bestellingen.Show();
        }

        private void btnCategorieen_Click(object sender, RoutedEventArgs e)
        {
            Categorieën categorieën = new Categorieën();
            categorieën.Show();
        }

        private void btnKlanten_Click(object sender, RoutedEventArgs e)
        {
            Klanten klanten = new Klanten();
            klanten.Show();
        }

        private void btnLeveranciers_Click(object sender, RoutedEventArgs e)
        {
            Leveranciers leverancier = new Leveranciers();
            leverancier.Show();
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPersoneelslid_Click(object sender, RoutedEventArgs e)
        {
            Personeelslidvenster personeelslid = new Personeelslidvenster();
            personeelslid.Show();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


    }
}
