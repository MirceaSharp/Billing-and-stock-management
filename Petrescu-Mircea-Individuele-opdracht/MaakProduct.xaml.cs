using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for MaakProduct.xaml
    /// </summary>
    public partial class MaakProduct : Window
    {
        public MaakProduct()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {

            string ProductID = txtProductID.Text;
            string Naam = txtNaam.Text;
            string Inkoopprijs = txtInkoopprijs.Text;
            string Marge = txtMarge.Text;
            string Eenheid = txtEenheid.Text;
            string BTW = txtBTW.Text;
            string LeverancierID = txtLeverancierID.Text;
            string CategorieID = txtCategorieID.Text;
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Product (ProductID,Naam,Inkoopprijs,Marge,Eenheid,BTW,LeverancierID,CategorieID) values('" + ProductID + "','" + Naam + "','" + Inkoopprijs + "','" + Marge + "','" + Eenheid + "','" + BTW + "','" + LeverancierID + "','" + CategorieID + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product toevoegen: gelukt.");
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


    }
}
