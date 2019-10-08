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

namespace PremezclasPremium
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        // botones panel
        private void button_operaciones(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Visible;
            atras.Visibility = Visibility.Visible;
        }
        private void button_seguridad(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Visible;
            atras.Visibility = Visibility.Visible;
        }

        private void button_atras(object sender, RoutedEventArgs e)
        {
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Visible;
        }

        // Botones de Operaciones
        private void button_diagrama_de_proceso(object sender, RoutedEventArgs e)
        {
            DiagramaProcesos window = new DiagramaProcesos();
            window.Show(); // Returns immediately
        }
        private void button_layout(object sender, RoutedEventArgs e)
        {
            Layout window = new Layout();
            window.Show(); // Returns immediately
        }
        private void button_control_de_operaciones(object sender, RoutedEventArgs e)
        {

        }
        private void button_documentos_tecnicos(object sender, RoutedEventArgs e)
        {

        }
        private void button_instrucciones(object sender, RoutedEventArgs e)
        {

        }

        // Botones de Seguridad
        private void button_analisis_de_riesgo(object sender, RoutedEventArgs e)
        {

        }
        private void button_EPP(object sender, RoutedEventArgs e)
        {

        }
        private void button_instrucciones_de_seguridad(object sender, RoutedEventArgs e)
        {

        }
        private void button_formatos_SHA(object sender, RoutedEventArgs e)
        {

        }
    }
}
