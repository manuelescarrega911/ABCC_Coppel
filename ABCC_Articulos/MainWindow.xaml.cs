using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ABCC_Articulos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Salir_Menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_AgregarArticulos_Click(object sender, RoutedEventArgs e)
        {
            Add_Articulo Ventanta_Add = new Add_Articulo();
            Ventanta_Add.Show();
            this.Hide();
        }

        private void Button_EliminarArticulo_Click(object sender, RoutedEventArgs e)
        {
            Delete_Articulo Ventana_Delete = new Delete_Articulo(); 
            Ventana_Delete.Show();
            this.Hide();
        }

        private void Button_ActualizarArticulos_Click(object sender, RoutedEventArgs e)
        {
            Update_Articulo Ventana_Articulo = new Update_Articulo();
            Ventana_Articulo.Show();
            this.Hide();
        }

        private void Button_ConsultaArticulo_Click(object sender, RoutedEventArgs e)
        {
            Read_Articulo Ventana_Consultar = new Read_Articulo();
            Ventana_Consultar.Show();
            this.Hide();
        }
    }
}
