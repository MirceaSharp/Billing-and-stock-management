using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for MaakBestelling.xaml
    /// </summary>
    public partial class MaakBestelling : Window
    {


        public MaakBestelling()
        {
            InitializeComponent();
        }



        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string BestellingID = txtBestellingID.Text;
            string DatumOpgemaakt = DatePicker.SelectedDate.ToString();
            string LevernacierID = CmbLeverancierID.SelectedItem.ToString();
            string PersoneelslidID = CmbPersoneelslidID.SelectedItem.ToString();
            string KlantID = CmbKlantID.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Bestelling (BestellingID,DatumOpgemaakt,LeverancierID,PersoneelslidID,KlantID) values('" + BestellingID + "','" + DatumOpgemaakt + "','" + LevernacierID + "','" + PersoneelslidID + "','" + KlantID + "')", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bestelling toevoegen: gelukt.");
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CmbLeverancierID.ItemsSource = DataManager.GetAllSuppliersDistinct();
            CmbPersoneelslidID.ItemsSource = DataManager.GetAllEmployeesDistinct();
            CmbKlantID.ItemsSource = DataManager.GetAllClientsDistinct();
        }

        private void CmbLeverancierID_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
