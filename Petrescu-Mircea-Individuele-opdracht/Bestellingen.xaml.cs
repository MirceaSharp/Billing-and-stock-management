using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Word = Microsoft.Office.Interop.Word;
using SQL = System.Data;
using System.Reflection;
using System.Configuration;
using System.IO;
using System.Data;

using System.Configuration;
using System.Data.SqlClient;
using ClosedXML.Excel;
using Ubiety.Dns.Core;
using Microsoft.Office.Interop.Excel;

namespace Petrescu_Mircea_Individuele_opdracht
{
    /// <summary>
    /// Interaction logic for Bestellingen.xaml
    /// </summary>
    public partial class Bestellingen : System.Windows.Window
    {
        public Bestellingen()
        {
            InitializeComponent();
        }

        List<Bestelling> ListOfOrders = new List<Bestelling>();


        private void btnToonAlles_Click(object sender, RoutedEventArgs e)
        {
            List<Bestelling> ListOfOrders = null;
            ListOfOrders = DataManager.GetOrders();
            foreach (Bestelling b in ListOfOrders)
            {
                dgShowBestellingen.ItemsSource = ListOfOrders;
            }


        }
        private void btnToonID_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!(string.IsNullOrEmpty(txtBestellingID.Text)))
                {

                    {
                        List<Bestelling> ListOfOrders = null;
                        ListOfOrders = DataManager.GetOrderByID(Convert.ToInt32(txtBestellingID.Text));
                        dgShowBestellingen.ItemsSource = ListOfOrders;
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
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MaakBestelling maakb = new MaakBestelling();
            maakb.Show();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {


            DataManager.DeleteOrder((Bestelling)dgShowBestellingen.SelectedItem);
            dgShowBestellingen.ItemsSource = DataManager.GetOrders();

            MessageBox.Show("Bestelling verwijderen: gelukt.");
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





        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            List<Bestelling> ListOfOrders = DataManager.GetOrderByID(Convert.ToInt32(txtBestellingID.Text));
            Word.Application wordfile = null;
            try
            {
                wordfile = new Word.Application();
                Word.Document worddocument = wordfile.Documents.Add(Environment.CurrentDirectory + @"\Template.dotx");
                foreach (Word.Bookmark bm in worddocument.Bookmarks)
                {
                    switch (bm.Name)
                    {

                        case "DATE": bm.Range.Text = ListOfOrders[0].DatumOpgemaakt.ToString(); break;
                        case "PO": bm.Range.Text = ListOfOrders[0].BestellingID.ToString(); break;
                            //case "winkelgegevens": bm.Range.Text = ListOfOrders[0].Store.stor_name + Environment.NewLine + storeSales[0].Store.stor_address; break;
                            //case "salesgegevens":
                            //    bm.Range.Text = string.Join(Environment.NewLine, storeOrders.Select(s => $"{s.Title.PaddedTitle(35)}{s.Title.price,9:C2}{s.qty,10}{s.Title.price * s.qty,13:C2}")); break;
                            //case "totaal": bm.Range.Text = Convert.ToDouble(storeOrders.Select(s => s.qty * s.Title.price).Sum()).ToString("C2"); break;



                    }
                }

                worddocument.SaveAs(Environment.CurrentDirectory + @"\" + txtBestellingID.Text);
                worddocument.Close(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:" + ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                wordfile.Quit();
            }

        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cnn;
            string connectionstring = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;


            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionstring = "Data Source=localhost;Initial Catalog=FinalDB;Integrated Security=True;Pooling=False";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            sql = "SELECT * FROM Product";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs(Environment.CurrentDirectory + @"\" + "s.xlsx");
            //xlWorkBook.SaveAs("information.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);


            MessageBox.Show("Excel file created , you can find the file ");

              //xlApp = null;

            try
            {

                // Grafiek aanmaken
                Chart chart = xlWorkSheet.ChartObjects().Add(250, 30, 400, 250).Chart;

                // Data aan de grafiek geven
                int maxrij = xlWorkSheet.UsedRange.Rows.Count;
                string xlListSerpatorStr = xlApp.International[XlApplicationInternational.xlListSeparator];
                Range chartRange = xlWorkSheet.get_Range($"A3:A{maxrij}{xlListSerpatorStr}C3:C{maxrij}");
                chart.SetSourceData(chartRange);

                // instellingen van de grafiek aanpassne
                chart.HasLegend = true;
                chart.Legend.Position = XlLegendPosition.xlLegendPositionRight;
                chart.ChartType = XlChartType.xlPyramidBarStacked100;
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Finally a graph in Excel with data from SQL using C#";

                // titels can de assen zetten
                chart.Axes(XlAxisType.xlCategory).HasTitle = true;
                chart.Axes(XlAxisType.xlCategory).AxisTitle.Characters.Text = "Studenten";
                chart.Axes(XlAxisType.xlValue).HasTitle = true;
                chart.Axes(XlAxisType.xlValue).AxisTitle.Characters.Text = "Punten";

                // ducment oplsaan en het document sluiten
                xlWorkBook.SaveAs(Environment.CurrentDirectory + @"\s.xlsx");
                xlWorkBook.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets fout gelopen: " + ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                // Excel sluiten
                xlApp.Quit();
            }

        }






    }

}



