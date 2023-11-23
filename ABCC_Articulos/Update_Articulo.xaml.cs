using ABCC_Articulos.CargasDeComboBox;
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
    /// Interaction logic for Update_Articulo.xaml
    /// </summary>
    public partial class Update_Articulo : Window
    {
        public Update_Articulo()
        {
            InitializeComponent();
            Text_Sku.Focus();
            Combo_Departamento.ItemsSource = CargaCombo().DefaultView;
            Combo_Departamento.DisplayMemberPath = "Nombre_Departamento";
            Combo_Departamento.SelectedValuePath = "Numero_Departamento";
            Combo_Clase.DisplayMemberPath = "Nombre_Clase";
            Combo_Clase.SelectedValuePath = "Numero_Clase";
            Combo_Familia.DisplayMemberPath = "Nombre_Familia";
            Combo_Familia.SelectedValuePath = "Numero_Familia";
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
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

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Regrsar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Hide();
        }

        private void Button_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            int Descontinuado = 1;
            if (Text_Sku.Text.Length == 0 || Text_Articulo.Text.Length == 0 || Text_Marca.Text.Length == 0 ||
                Text_Modelo.Text.Length == 0 || Text_Cantidad.Text.Length == 0 || Text_Stock.Text.Length == 0 ||
                Convert.ToInt32(Combo_Departamento.SelectedValue) == 0 || Convert.ToInt32(Combo_Clase.SelectedValue) == 0 ||
                Convert.ToInt32(Combo_Familia.SelectedValue) == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check_Descontinuado.IsChecked.Value == true)
            {
                Descontinuado = 1;
                Fecha_Baja.SelectedDate = DateTime.Now;
            }
            else
            {
                Descontinuado = 0;
            }

            if (Convert.ToInt64(Text_Cantidad.Text) > Convert.ToInt64(Text_Stock.Text))
            {
                MessageBox.Show("La Cantidad No Debe Ser Mayor Al Stock", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            Combo_Departamento.SelectedValuePath = "Numero_Departamento";
            Combo_Clase.SelectedValuePath = "Numero_Clase";
            InfoArticulos info = new InfoArticulos()
            {
                SKu = Convert.ToInt64(Text_Sku.Text),
                Articulo = Text_Articulo.Text,
                Marca = Text_Marca.Text,
                Modelo = Text_Modelo.Text,
                Departamento = Convert.ToInt32(Combo_Departamento.SelectedValue),
                Clase = Convert.ToInt32(Combo_Clase.SelectedValue),
                Familia = Convert.ToInt32(Combo_Familia.SelectedValue),
                Stock = Convert.ToInt64(Text_Stock.Text),
                Cantidad = Convert.ToInt64(Text_Cantidad.Text),
                Descontinuado = Convert.ToBoolean(Descontinuado),
                FechaAlta = Convert.ToDateTime(Fecha_Alta.SelectedDate),
                FechaBaja = Convert.ToDateTime(Fecha_Baja.SelectedDate)
            };

            ConexionSQL Update_Art = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            {
                if (MessageBox.Show("Esta usted seguro(a) de actualizar este articulo?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Update_Art.UpdateArticulos(info);
                    MessageBox.Show("El Articulo Se Ha Actualizado Correctamente", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    Text_Articulo.IsEnabled = false;
                    Text_Marca.IsEnabled = false;
                    Text_Modelo.IsEnabled = false;
                    Combo_Departamento.IsEnabled = false;
                    Combo_Clase.IsEnabled = false;
                    Combo_Familia.IsEnabled = false;
                    Text_Cantidad.IsEnabled = false;
                    Text_Stock.IsEnabled = false;
                    Check_Descontinuado.IsEnabled = false;
                    Limpiar();
                }
                else
                {
                    return;
                }

            }
        }

        private void Button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if (Text_Sku.Text.Length > 0)
            {
                Text_Sku.IsEnabled = false;
                InfoArticulos infoArticulos = new InfoArticulos();

                ConexionSQL consulta_Art = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");

                if (consulta_Art.ConsultaArt(Convert.ToInt64(Text_Sku.Text), ref infoArticulos))
                {
                    //Text_Sku .Text = infoArticulos.SKu.ToString();
                    Text_Articulo.Text = infoArticulos.Articulo;
                    Text_Marca.Text = infoArticulos.Marca;
                    Text_Modelo.Text = infoArticulos.Modelo;
                    Combo_Departamento.SelectedValue = infoArticulos.Departamento.ToString();
                    Combo_Clase.SelectedValue = infoArticulos.Clase.ToString();
                    Combo_Familia.SelectedValue = infoArticulos.Familia.ToString();
                    Fecha_Alta.SelectedDate = infoArticulos.FechaAlta;
                    Text_Stock.Text = infoArticulos.Stock.ToString();
                    Text_Cantidad.Text = infoArticulos.Cantidad.ToString();
                    Check_Descontinuado.IsChecked = Convert.ToBoolean(infoArticulos.Descontinuado);
                    Fecha_Baja.SelectedDate = infoArticulos.FechaBaja;

                    Text_Articulo.IsEnabled = true;
                    Text_Marca.IsEnabled = true;
                    Text_Modelo.IsEnabled = true;
                    Combo_Departamento.IsEnabled = true;
                    Combo_Clase.IsEnabled = true;
                    Combo_Familia.IsEnabled = true;
                    Text_Cantidad.IsEnabled = true;
                    Text_Stock.IsEnabled = true;
                    Check_Descontinuado.IsEnabled = true;
                    Button_Actualizar.IsEnabled = true;


                    //Existente = true;
                    //Button_Eliminar.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No Exixte El Articulo Con Ese SKU", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Text_Sku.IsEnabled = true;
                    Text_Sku.Focus();
                    Button_Actualizar.IsEnabled = false;

                }
            }
            else
            {
                MessageBox.Show("Ingresa Un SKU", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Text_Sku_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private void Button_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }


        public void Limpiar()
        {
            Text_Sku.Text = "";
            Text_Articulo.Text = "";
            Text_Marca.Text = "";
            Text_Modelo.Text = "";
            Combo_Departamento.Text = "";
            Combo_Clase.Text = "";
            Combo_Familia.Text = "";
            Text_Cantidad.Text = "";
            Text_Stock.Text = "";
            Fecha_Alta.SelectedDate = DateTime.Now;
            Check_Descontinuado.IsChecked = false;
            Fecha_Baja.SelectedDate = DateTime.Now;
            Text_Sku.IsEnabled = true;
            Button_Actualizar.IsEnabled = false;
            Text_Articulo.IsEnabled = false;
            Text_Marca.IsEnabled = false;
            Text_Modelo.IsEnabled = false;
            Combo_Departamento.IsEnabled = false;
            Combo_Clase.IsEnabled = false;
            Combo_Familia.IsEnabled = false;
            Text_Cantidad.IsEnabled = false;
            Text_Stock.IsEnabled = false;
            Check_Descontinuado.IsEnabled = false;
            Text_Sku.Focus();

        }
    }
}
