using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ABCC_Articulos
{
    /// <summary>
    /// Interaction logic for Read_Articulo.xaml
    /// </summary>
    public partial class Read_Articulo : Window
    {
        public Read_Articulo()
        {
            InitializeComponent();
            Text_Sku.Focus();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Hide();
        }

        private void Tabla_InfoSku_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if(Text_Sku.Text.Length > 0)
            {
                DataTable dataTable = new DataTable();
                ConexionSQL conexionSQL = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
                conexionSQL.ConsultaGeneral(Convert.ToInt64(Text_Sku.Text), ref dataTable);
                Tabla_InfoSku.ItemsSource = dataTable.DefaultView;
            }
            else
            {

                MessageBox.Show("Ingresar Un SKU Del Articulo", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

        }

        private void Text_Sku_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);

        }

        private void Depa_Clas_Famili_Click(object sender, RoutedEventArgs e)
        {
            Depa_Clas_Fam depa_Clas_Fam = new Depa_Clas_Fam();
            depa_Clas_Fam.Show();
            this.Hide();
        }
    }
}
