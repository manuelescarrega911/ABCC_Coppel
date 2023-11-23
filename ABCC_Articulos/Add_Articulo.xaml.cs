using ABCC_Articulos.CargasDeComboBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for Add_Articulo.xaml
    /// </summary>
    public partial class Add_Articulo : Window
    {
        public Add_Articulo()
        {
            InitializeComponent();
            Text_SKU.Focus();
            Fecha_Alta.SelectedDate = DateTime.Now;
            Combo_Departamento.ItemsSource = CargaCombo().DefaultView;
            Combo_Departamento.DisplayMemberPath = "Nombre_Departamento";
            Combo_Departamento.SelectedValuePath = "Numero_Departamento";
            Combo_Clase.DisplayMemberPath = "Nombre_Clase";
            Combo_Clase.SelectedValuePath = "Numero_Clase";
            Combo_Familia.DisplayMemberPath = "Nombre_Familia";
            Combo_Familia.SelectedValuePath = "Numero_Familia";
        }

        public DataTable CargaCombo()
        {
            DataTable tabla = new DataTable();
            ConexionSQL conexionSQL = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            conexionSQL.CargaCombo(ref tabla);
            return tabla;
        }
        public DataTable Combo_Depa_Clase_1()
        {
            DataTable tabla = new DataTable();
            Departamento_Clase departamento_Clase = new Departamento_Clase("MANUEL", "ABCC_Articulos", "sa", "1234");
            departamento_Clase.Combo_Depa_Clase_1(ref tabla);
            return tabla;
        }
        public DataTable Combo_Depa_Clase_2()
        {
            DataTable tabla = new DataTable();
            Departamento_Clase departamento_Clase = new Departamento_Clase("MANUEL", "ABCC_Articulos", "sa", "1234");
            departamento_Clase.Combo_Depa_Clase_2(ref tabla);
            return tabla;
        }
        public DataTable Combo_Depa_Clase_3()
        {
            DataTable tabla = new DataTable();
            Departamento_Clase departamento_Clase = new Departamento_Clase("MANUEL", "ABCC_Articulos", "sa", "1234");
            departamento_Clase.Combo_Depa_Clase_3(ref tabla);
            return tabla;
        }
        public DataTable Combo_Depa_Clase_4()
        {
            DataTable tabla = new DataTable();
            Departamento_Clase departamento_Clase = new Departamento_Clase("MANUEL", "ABCC_Articulos", "sa", "1234");
            departamento_Clase.Combo_Depa_Clase_4(ref tabla);
            return tabla;
        }

        public DataTable Combo_Clase_Familia_1()
        {
            DataTable tabla = new DataTable();
            Clase_Familia clase_Familia = new Clase_Familia("MANUEL", "ABCC_Articulos", "sa", "1234");
            clase_Familia.Combo_Clase_Familia_1(ref tabla);
            return tabla;
        }
        public DataTable Combo_Clase_Familia_2()
        {
            DataTable tabla = new DataTable();
            Clase_Familia clase_Familia = new Clase_Familia("MANUEL", "ABCC_Articulos", "sa", "1234");
            clase_Familia.Combo_Clase_Familia_2(ref tabla);
            return tabla;
        }
        public DataTable Combo_Clase_Familia_3()
        {
            DataTable tabla = new DataTable();
            Clase_Familia clase_Familia = new Clase_Familia("MANUEL", "ABCC_Articulos", "sa", "1234");
            clase_Familia.Combo_Clase_Familia_3(ref tabla);
            return tabla;
        }
        public DataTable Combo_Clase_Familia_4()
        {
            DataTable tabla = new DataTable();
            Clase_Familia clase_Familia = new Clase_Familia("MANUEL", "ABCC_Articulos", "sa", "1234");
            clase_Familia.Combo_Clase_Familia_4(ref tabla);
            return tabla;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Regrsar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Hide();
        }

        public void Limpiar()
        {
            Text_SKU.Text = "";
            Text_Articulo.Text = "";
            Text_Marca.Text = "";
            Text_Modelo.Text = "";
            Combo_Departamento.Text = "";
            Combo_Clase.Text = "";
            Combo_Familia.Text = "";
            Text_Cantidad.Text = "";
            Text_Stock.Text = "";
            //Fecha_Alta.SelectedDate = DateTime.Now;
            //Check_Descontinuado.IsChecked = false;
            //Fecha_Baja.SelectedDate = DateTime.Now;
            Combo_Clase.IsEnabled = false;
            Combo_Familia.IsEnabled = false;
            Text_SKU.Focus();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean AltaCorrecto = false;

            if (Text_SKU.Text.Length == 0 || Text_Articulo.Text.Length == 0 || Text_Marca.Text.Length == 0||
                Text_Modelo.Text.Length == 0 || Text_Cantidad.Text.Length == 0 || Text_Stock.Text.Length == 0 ||
                Convert.ToInt32(Combo_Departamento.SelectedValue) == 0 || Convert.ToInt32(Combo_Clase.SelectedValue) ==0 ||
                Convert.ToInt32(Combo_Familia.SelectedValue) == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Convert.ToInt64(Text_Cantidad.Text) > Convert.ToInt64(Text_Stock.Text))
            {
                MessageBox.Show("La Cantidad No Debe Ser Mayor Al Stock", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning );
                return;
            }


            Combo_Departamento.SelectedValuePath = "Numero_Departamento";
            Combo_Clase.SelectedValuePath = "Numero_Clase";
            InfoArticulos info = new InfoArticulos()
            {
                SKu = Convert.ToInt64(Text_SKU.Text),
                Articulo = Text_Articulo.Text,
                Marca = Text_Marca.Text,
                Modelo = Text_Modelo.Text,
                Departamento = Convert.ToInt32(Combo_Departamento.SelectedValue),
                Clase = Convert.ToInt32(Combo_Clase.SelectedValue),
                Familia = Convert.ToInt32(Combo_Familia.SelectedValue),
                Stock = Convert.ToInt64(Text_Stock.Text),
                Cantidad = Convert.ToInt64(Text_Cantidad.Text),
                Descontinuado = Convert.ToBoolean(0),
                FechaAlta = Convert.ToDateTime(Fecha_Alta.SelectedDate),
                FechaBaja = Convert.ToDateTime(Fecha_Baja.SelectedDate)
            };

            ConexionSQL Alta_Art = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            {
                AltaCorrecto = Alta_Art.ALtaArticulos(info);

                if(!AltaCorrecto)
                {
                    MessageBox.Show("Ya Existe Un Articulo Con Ese SKU", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("El Articulo Se Ha Agregado Correctamente", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    Limpiar();
                    Text_SKU.Focus();

                }
            }
        }

        private void Button_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Text_SKU_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Text_Stock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Text_Cantidad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Combo_Departamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Convert.ToInt32(Combo_Departamento.SelectedValue) == 1)
            {
                Combo_Clase.ItemsSource = Combo_Depa_Clase_1().DefaultView;
                Combo_Clase.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Departamento.SelectedValue) == 2)
            {
                Combo_Clase.ItemsSource = Combo_Depa_Clase_2().DefaultView;
                Combo_Clase.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Departamento.SelectedValue) == 3)
            {
                Combo_Clase.ItemsSource = Combo_Depa_Clase_3().DefaultView;
                Combo_Clase.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Departamento.SelectedValue) == 4)
            {
                Combo_Clase.ItemsSource = Combo_Depa_Clase_4().DefaultView;
                Combo_Clase.IsEnabled = true;
            }
        }

        private void Combo_Clase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Convert.ToInt32(Combo_Clase.SelectedValue) == 11 || Convert.ToInt32(Combo_Clase.SelectedValue) == 12 ||
                Convert.ToInt32(Combo_Clase.SelectedValue) == 13 || Convert.ToInt32(Combo_Clase.SelectedValue) == 14) 
            {
                Combo_Familia.ItemsSource = Combo_Clase_Familia_1().DefaultView;
                Combo_Familia.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Clase.SelectedValue) == 21 || Convert.ToInt32(Combo_Clase.SelectedValue) == 22)
            {
                Combo_Familia.ItemsSource = Combo_Clase_Familia_2().DefaultView;
                Combo_Familia.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Clase.SelectedValue) == 31 || Convert.ToInt32(Combo_Clase.SelectedValue) == 32)
            {
                Combo_Familia.ItemsSource = Combo_Clase_Familia_3().DefaultView;
                Combo_Familia.IsEnabled = true;
            }
            else if (Convert.ToInt32(Combo_Clase.SelectedValue) == 41 || Convert.ToInt32(Combo_Clase.SelectedValue) == 42 ||
                     Convert.ToInt32(Combo_Clase.SelectedValue) == 43)
            {
                Combo_Familia.ItemsSource = Combo_Clase_Familia_4().DefaultView;
                Combo_Familia.IsEnabled = true;
            }
        }

        private void Text_SKU_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
