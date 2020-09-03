using System.Windows;
using System.Windows.Input;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Window
    {


        public Overview()
        {
            InitializeComponent();


        }




        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnDatabeheer_Click(object sender, RoutedEventArgs e)
        {
            Databeheer databeheer = new Databeheer();
            databeheer.Show();

        }




        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnOverzicht_Click(object sender, RoutedEventArgs e)
        {




        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }



}
