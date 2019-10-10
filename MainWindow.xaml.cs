using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
        public FileInfo[] Files_Control { get; set; }
        public FileInfo[] Files_Documentos { get; set; }
        public FileInfo[] Files_Instrucciones { get; set; }

        string controlOperacionesPath = "Documentos\\Control de Operaciones";
        string documentosTecnicosPath = "Documentos\\Documento Tecnico de Trabajo";
        string instruccionesPath = "Documentos\\Instrucciones Operacionales";

        public MainWindow()
		{
			InitializeComponent();

            //control de operaciones
            var ControlOperaciones_directory = new DirectoryInfo(controlOperacionesPath);
            Files_Control = ControlOperaciones_directory.GetFiles();

            //documentos tecnicos
            var DocumentosTecnicos_directory = new DirectoryInfo(documentosTecnicosPath);
            Files_Documentos = DocumentosTecnicos_directory.GetFiles();

            //Instrucciones Operacionales
            var Instrucciones_directory = new DirectoryInfo(instruccionesPath);
            Files_Instrucciones = Instrucciones_directory.GetFiles();


            DataContext = this;
        }

        public void OpenWithDefaultProgram(int location, string namefile)
        {
            string path = null;
            switch (location)
            {
                case 1:
                    path = controlOperacionesPath + "\\" + namefile;
                    break;
                case 2:
                    path = documentosTecnicosPath + "\\" + namefile;
                    break;
                case 3:
                    path = instruccionesPath + "\\" + namefile;
                    break;
                default:
                    break;
            }
            Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        //guardar
        private void button_guardar_control_operaciones(object sender, RoutedEventArgs e)
        {
            string namefile = lvControlOperaciones.SelectedItems[0].ToString();
            string path = controlOperacionesPath + "\\" + namefile;
            guardar(namefile, path);
        }
        private void button_guardar_documentos_tecnicos(object sender, RoutedEventArgs e)
        {
            string namefile = lvDocumentosTecnicos.SelectedItems[0].ToString();
            string path = documentosTecnicosPath + "\\" + namefile;
            guardar(namefile, path);
        }
        private void button_guardar_instrucciones(object sender, RoutedEventArgs e)
        {
            string namefile = lvInstrucciones.SelectedItems[0].ToString();
            string path = instruccionesPath + "\\" + namefile;
            guardar(namefile, path);
        }

        public void guardar(string namefile, string path)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = namefile; // Default file name
            saveFileDialog.Filter = "Cualquier tipo archivo (.)|*"; // Filter files by extension

            if (saveFileDialog.ShowDialog() == true)
            {
                File.Copy(path, saveFileDialog.FileName);
            }
        }

        private void lvControlOperaciones_DoubleClick(object sender, EventArgs e)
        {
            OpenWithDefaultProgram(1, lvControlOperaciones.SelectedItems[0].ToString());
        }
        private void lvDocumentosTecnicos_DoubleClick(object sender, EventArgs e)
        {
            OpenWithDefaultProgram(2, lvDocumentosTecnicos.SelectedItems[0].ToString());
        }
        private void lvInstrucciones_DoubleClick(object sender, EventArgs e)
        {
            OpenWithDefaultProgram(3, lvInstrucciones.SelectedItems[0].ToString());
        }

        // botones panel
        private void button_operaciones(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Visible;
            atras.Visibility = Visibility.Visible;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
        }
        private void button_seguridad(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Visible;
            atras.Visibility = Visibility.Visible;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
        }

        private void button_atras(object sender, RoutedEventArgs e)
        {
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Visible;
        }
        private void button_atras_operaciones(object sender, RoutedEventArgs e)
        {
            Seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Hidden;

            ControlOperaciones.Visibility = Visibility.Hidden;
            DocumentosTecnicos.Visibility = Visibility.Hidden;
            Instrucciones.Visibility = Visibility.Hidden;

            atras.Visibility = Visibility.Visible;
            Operaciones.Visibility = Visibility.Visible;
        }
        private void button_atras_seguridad(object sender, RoutedEventArgs e)
        {
            Operaciones.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            Main.Visibility = Visibility.Hidden;
            atras.Visibility = Visibility.Visible;
            Seguridad.Visibility = Visibility.Visible;
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
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            DocumentosTecnicos.Visibility = Visibility.Hidden;
            Instrucciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Visible;
            ControlOperaciones.Visibility = Visibility.Visible;
        }

        private void button_documentos_tecnicos(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            ControlOperaciones.Visibility = Visibility.Hidden;
            Instrucciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Visible;
            DocumentosTecnicos.Visibility = Visibility.Visible;

        }
        private void button_instrucciones(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            ControlOperaciones.Visibility = Visibility.Hidden;
            DocumentosTecnicos.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Visible;
            Instrucciones.Visibility = Visibility.Visible;
        }

        // Botones de Seguridad
        private void button_analisis_de_riesgo(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Visible;
        }
        private void button_EPP(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Visible;
        }
        private void button_instrucciones_de_seguridad(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Visible;
        }
        private void button_formatos_SHA(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            Operaciones.Visibility = Visibility.Hidden;
            Seguridad.Visibility = Visibility.Hidden;
            atras_operaciones.Visibility = Visibility.Hidden;
            atras_seguridad.Visibility = Visibility.Visible;
        }
    }

    public class ConvertFileImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value as string == string.Empty) return null;

            var file = @"Media/file_" + value.ToString().Substring(1) + ".png";
            ImageSource src = new BitmapImage(new Uri(file, UriKind.Relative));
            return src;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
