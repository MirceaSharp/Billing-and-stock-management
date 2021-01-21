using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(txtUser.Text) || ((string.IsNullOrWhiteSpace(txtPassword.Password)))))
            {
                MessageBox.Show("You must fill in both username and password fields");


            }
            else
            {

                SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost; Initial Catalog=FinalDB; Integrated Security = true");

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    string query = "SELECT COUNT (1) FROM Personeelslid WHERE Voornaam=@Voornaam AND Password=@Password;";
                    SqlCommand sqlcom = new SqlCommand(query, sqlCon);
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.Parameters.AddWithValue("@Voornaam", txtUser.Text);
                    sqlcom.Parameters.AddWithValue("@Password", txtPassword.Password);





                    int count = Convert.ToInt32(sqlcom.ExecuteScalar());
                    if (count == 1)
                    {
                        if (txtUser.Text == "Joost")
                        {
                            Overview overview = new Overview();
                            overview.lblWelkom.Content = "Welcome Joost!";
                            overview.Show();
                            this.Close();
                        }
                        else if (txtUser.Text == "Bart")
                        {
                            Overview overview = new Overview();
                            overview.Show();
                            overview.lblWelkom.Content = "Welcome Bart!";

                            overview.btnDatabeheer.Visibility = Visibility.Hidden;
                            overview.icondatabase.Visibility = Visibility.Hidden;

                            this.Close();
                        }
                        else if (txtUser.Text == "Guido")
                        {

                            Overview overview = new Overview();
                            overview.Show();
                            overview.lblWelkom.Content = "Welcome Guido!";

                            overview.btnLeveranciers.Visibility = Visibility.Hidden;
                            overview.btnDatabeheer.Visibility = Visibility.Hidden;
                            overview.icondatabase.Visibility = Visibility.Hidden;

                            this.Close();
                        }
                        else
                        {
                            Overview overview = new Overview();
                            overview.Show();
                            overview.lblWelkom.Content = "Welcome Alice!";
                            overview.btnLeveranciers.Visibility = Visibility.Hidden;
                            overview.btnDatabeheer.Visibility = Visibility.Hidden;
                            overview.icondatabase.Visibility = Visibility.Hidden;


                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or wrong password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void Top_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMinmize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

