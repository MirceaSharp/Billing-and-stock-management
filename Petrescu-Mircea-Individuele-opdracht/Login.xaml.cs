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
            Overview overview = new Overview();


            if ((string.IsNullOrWhiteSpace(txtUser.Text) || ((string.IsNullOrWhiteSpace(txtPassword.Text)))))
            {
                MessageBox.Show("You must fill in both username and password fields");


            }
            else
            {
                if ((txtUser.Text == "admin") & (txtPassword.Text == "Greece2020"))
                {

                    overview.Show();
                    overview.btnKlanten.Visibility = Visibility.Hidden;
                    overview



                    Close();

                }
                else if ((txtUser.Text == "magazijner") & (txtPassword.Text == "magazijner1999"))
                {

                    overview.btnDatabeheer.Visibility = Visibility.Hidden;
                    overview.icondatabase.Visibility = Visibility.Hidden;
                    overview.Show();
                    Close();
                }
                else if ((txtUser.Text == "verkoper") & (txtPassword.Text == "SalesAccount123"))
                {
                    overview.btnDatabeheer.Visibility = Visibility.Hidden;
                    overview.icondatabase.Visibility = Visibility.Hidden;

                    overview.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or wrong password");


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

