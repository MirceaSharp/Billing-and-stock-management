using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Personeelslid.xaml
    /// </summary>
    public partial class Personeelslidvenster : Window
    {
        List<Personeelslid> ListOfEmployees = null;

        public Personeelslidvenster()
        {
            InitializeComponent();
        }

        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {

            List<Personeelslid> ListOfEmployees = null;
            ListOfEmployees = DataManager.GetEmployees();
            foreach (Personeelslid per in ListOfEmployees)
            {
                dgShowEmployees.ItemsSource = ListOfEmployees;
            }
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {

            string PersoneelslidID = txtPersoneelslidID.Text;
            string Voornaam = txtVoornaam.Text;
            string Password = txtPassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Personeelslid (PersoneelslidID,Voornaam,Password) values('" + PersoneelslidID + "','" + Voornaam + "','" + Password + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personeelslid toevoegen: gelukt.");
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {

            DataManager.DeleteEmployee((Personeelslid)dgShowEmployees.SelectedItem);
            dgShowEmployees.ItemsSource = DataManager.GetEmployees();

            MessageBox.Show("Personeelslid verwijderen: gelukt.");
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












