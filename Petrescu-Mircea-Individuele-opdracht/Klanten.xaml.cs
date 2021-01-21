using System;
using System.Collections.Generic;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Klanten.xaml
    /// </summary>
    public partial class Klanten : Window
    {
        List<Klant> ListOfClients = null;
        public Klanten()
        {

            InitializeComponent();
        }

        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {
            List<Klant> ListOfClients = null;
            ListOfClients = DataManager.GetClients();
            foreach (Klant k in ListOfClients)
            {
                dgShowKlanten.ItemsSource = ListOfClients;
            }
        }

        private void btnToonID_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtKlantID.Text)))
                {

                    {
                        List<Klant> ListOfClients = null;
                        ListOfClients = DataManager.GetClientByID(Convert.ToInt32(txtKlantID.Text));
                        dgShowKlanten.ItemsSource = ListOfClients;
                    }
                }
                else
                {
                    MessageBox.Show("Geef een ID in.", "Vergeten ID in te vullen.", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Geef een goede ID in.", exc.Message, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MaakKlant maakklant = new MaakKlant();
            maakklant.Show();
        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            DataManager.DeleteClient((Klant)dgShowKlanten.SelectedItem);
            dgShowKlanten.ItemsSource = DataManager.GetClients();

            MessageBox.Show("Klant verwijderen: gelukt.");
        }

        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgShowKlanten_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void txtKlantID_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}






















