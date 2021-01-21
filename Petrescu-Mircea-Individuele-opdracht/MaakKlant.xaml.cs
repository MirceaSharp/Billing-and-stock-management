using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for MaakKlant.xaml
    /// </summary>
    public partial class MaakKlant : Window
    {
        public MaakKlant()
        {
            InitializeComponent();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtKlantID.Text) || (!(string.IsNullOrEmpty(txtVoornaam.Text) || (!(string.IsNullOrEmpty(txtAchternaam.Text) || (!(string.IsNullOrEmpty(txtStraatnaam.Text) || (!(string.IsNullOrEmpty(txtHuisnummer.Text) || (!(string.IsNullOrEmpty(txtBus.Text) || (!(string.IsNullOrEmpty(txtPostcode.Text) || (!(string.IsNullOrEmpty(txtGemeente.Text) || (!(string.IsNullOrEmpty(txtTeleffonnummer.Text) || (!(string.IsNullOrEmpty(txtEmailAdres.Text) || (!(string.IsNullOrEmpty(txtOpmerking.Text)))))))))))))))))))))))
            {
                string KlantID = txtKlantID.Text;
                string Aangemaaktop = DatePicker.SelectedDate.ToString();
                string Voornaam = txtVoornaam.Text;
                string Achternaam = txtAchternaam.Text;
                string Straatnaam = txtStraatnaam.Text;
                string Huisnummer = txtHuisnummer.Text;
                string Bus = txtBus.Text;
                string Postcode = txtPostcode.Text;
                string Gemeente = txtGemeente.Text;
                string Teleffonnummer = txtTeleffonnummer.Text;
                string Emailadres = txtEmailAdres.Text;
                string Opmerking = txtOpmerking.Text;
                SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Klant (KlantID,Voornaam,Achternaam,Straatnaam,Huisnummer,Bus,Postcode,Gemeente,Teleffonnummer,Emailadres,AangemaaktOp,Opmerking) values('" + KlantID + "','" + Voornaam + "','" + Achternaam + "','" + Straatnaam + "','" + Huisnummer + "','" + Bus + "','" + Postcode + "','" + Gemeente + "','" + Teleffonnummer + "','" + Emailadres + "','" + Aangemaaktop + "','" + Opmerking + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Klant toevoegen : gelukt.");
            }
            else
            {
                MessageBox.Show("U moet alles invullen.");
            }

        }
    }
}

