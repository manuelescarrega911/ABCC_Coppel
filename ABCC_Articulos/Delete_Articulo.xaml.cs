using ABCC_Articulos.CargasDeComboBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
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
    /// Interaction logic for Delete_Articulo.xaml
    /// </summary>
    public partial class Delete_Articulo : Window
    {
        public Boolean Existente = false;

        public Delete_Articulo()
        {
            InitializeComponent();
            Combo_Departamento.ItemsSource = CargaCombo().DefaultView;
            Combo_Clase.ItemsSource = Combo_Depa_Clase().DefaultView;
            Combo_Familia.ItemsSource = Combo_Clase_Familia().DefaultView;
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
        private void Button_Regrsar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Hide();
        }

        public DataTable CargaCombo()
        {
            DataTable tabla = new DataTable();
            ConexionSQL conexionSQL = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            conexionSQL.CargaCombo(ref tabla);
            return tabla;
        }
        public DataTable Combo_Depa_Clase()
        {
            DataTable tabla = new DataTable();
            Departamento_Clase departamento_Clase = new Departamento_Clase("MANUEL", "ABCC_Articulos", "sa", "1234");
            departamento_Clase.Combo_Depa_Clase(ref tabla);
            return tabla;
        }
        public DataTable Combo_Clase_Familia()
        {
            DataTable tabla = new DataTable();
            Clase_Familia clase_Familia = new Clase_Familia("MANUEL", "ABCC_Articulos", "sa", "1234");
            clase_Familia.Combo_Clase_Familia(ref tabla);
            return tabla;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Text_Sku_MouseLeave(object sender, MouseEventArgs e)
        {
            
            
        }

        private void Text_Sku_TextChanged(object sender, TextChangedEventArgs e)
        {

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
            //Fecha_Alta.SelectedDate = DateTime.Now;
            Check_Descontinuado.IsChecked = false;
            Button_Eliminar.IsEnabled = false;

        }


        private void Button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if (Text_Sku.Text.Length > 0)
            {
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

                    Existente = true;
                    Button_Eliminar.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No Exixte El Articulo Con Ese SKU", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa Un SKU", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            ConexionSQL Baja_Art = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            {
                if(Text_Sku.Text.Length > 0)
                {
                    if (Existente == true)
                    {
                        if (MessageBox.Show("Esta usted seguro(a) de eliminar este articulo?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            Baja_Art.BajaArticulos(Convert.ToInt64(Text_Sku.Text));
                            MessageBox.Show("Articulo Eliminado Correctamente", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe el articulo con ese SKU");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de ingresar un numero SKU");
                }

            }
        }

        private void Button_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
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
    }
}
