using System;
using System.Collections.Generic;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Leveranciers.xaml
    /// </summary>
    public partial class Leveranciers : Window
    {
        List<Leverancier> ListOfSuppliers = null;
        public Leveranciers()
        {
            InitializeComponent();
        }

        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {
            List<Leverancier> ListOfSuppliers = null;
            ListOfSuppliers = DataManager.GetSuppliers();
            foreach (Leverancier l in ListOfSuppliers)
            {
                dgShowSuppliers.ItemsSource = ListOfSuppliers;
            }
        }
        private void btnToonID_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!(string.IsNullOrEmpty(txtLevID.Text)))
                {
                    List<Leverancier> ListOfSuppliers = null;
                    ListOfSuppliers = DataManager.GetSupplierByID(Convert.ToInt32((txtLevID.Text)));



                    dgShowSuppliers.ItemsSource = ListOfSuppliers;

                }
                else
                {
                    MessageBox.Show("Geef een ID in!");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Geef een goede ID in");
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            DataManager.DeleteSupplier((Leverancier)dgShowSuppliers.SelectedItem);
            dgShowSuppliers.ItemsSource = DataManager.GetSuppliers();

            MessageBox.Show("Leverancier verwijderen : gelukt!");

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

        private void txtLevID_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}









