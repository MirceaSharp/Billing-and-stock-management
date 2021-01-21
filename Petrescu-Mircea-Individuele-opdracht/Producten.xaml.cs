using System;
using System.Collections.Generic;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Producten.xaml
    /// </summary>
    public partial class Producten : Window
    {
        List<Product> ListOfProducts = null;


        public Producten()
        {
            InitializeComponent();


        }


        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {
            List<Product> ListOfProducts = null;
            ListOfProducts = DataManager.GetProducts();
            foreach (Product p in ListOfProducts)
            {
                dgShowProducten.ItemsSource = ListOfProducts;
            }
        }

        private void btnToonID_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtProductID.Text)))
                {

                    {
                        List<Product> ListOfProducts = null;
                        ListOfProducts = DataManager.GetProductByID(Convert.ToInt32(txtProductID.Text));
                        dgShowProducten.ItemsSource = ListOfProducts;
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







        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            DataManager.DeleteProduct((Product)dgShowProducten.SelectedItem);
            dgShowProducten.ItemsSource = DataManager.GetProducts();

            MessageBox.Show("Product verwijderen: gelukt.");
        }


        private void dgShowProducten_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {


        }



        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MaakProduct maakp = new MaakProduct();
            maakp.Show();
        }
    }
}












