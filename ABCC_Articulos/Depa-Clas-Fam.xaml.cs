using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Depa_Clas_Fam.xaml
    /// </summary>
    public partial class Depa_Clas_Fam : Window
    {
        public Depa_Clas_Fam()
        {
            InitializeComponent();
            DataTable dataTableDepa = new DataTable();
            ConexionSQL Tabla_Depa = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            Tabla_Depa.Consulta_Departamento(ref dataTableDepa);
            Tabla_Departamento.ItemsSource = dataTableDepa.DefaultView;

            DataTable dataTableClase = new DataTable();
            ConexionSQL TablaClase = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            TablaClase.Consulta_Clase(ref dataTableClase);
            Tabla_Clase.ItemsSource = dataTableClase.DefaultView;

            DataTable dataTableFamilia = new DataTable();
            ConexionSQL TablaFamilia = new ConexionSQL("MANUEL", "ABCC_Articulos", "sa", "1234");
            TablaFamilia.Consulta_Familia(ref dataTableFamilia);
            Tabla_Familia.ItemsSource = dataTableFamilia.DefaultView;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Tabla_InfoSku_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Salir_Menu_Click(object sender, RoutedEventArgs e)
        {
            Read_Articulo read_Articulo = new Read_Articulo();
            read_Articulo.Show();
            this.Hide();
        }
    }
}
