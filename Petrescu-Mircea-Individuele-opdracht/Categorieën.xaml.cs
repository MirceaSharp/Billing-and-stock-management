using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Categorieën.xaml
    /// </summary>
    public partial class Categorieën : Window
    {
        List<Categorie> ListOfCategories = null;
        public Categorieën()
        {
            InitializeComponent();
        }

        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {
            List<Categorie> ListOfCategories = null;

            ListOfCategories = DataManager.GetCategories();
            foreach (Categorie c in ListOfCategories)
            {
                dgShowCategories.ItemsSource = ListOfCategories;
            }
        }
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string CategorieID = txtCategorieID.Text;
            string CategorieNaam = txtCategorieNaam.Text;


            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Categorie (CategorieID,CategorieNaam) values('" + CategorieID + "','" + CategorieNaam + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Categorie toevoegen: gelukt.");
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            DataManager.DeleteCatergory((Categorie)dgShowCategories.SelectedItem);
            dgShowCategories.ItemsSource = DataManager.GetCategories();

            MessageBox.Show("Categorie verwijderen : gelukt!");


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



    }
}
