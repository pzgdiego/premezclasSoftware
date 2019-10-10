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
using System.Windows.Shapes;

namespace PremezclasPremium
{
    /// <summary>
    /// Lógica de interacción para Layout.xaml
    /// </summary>
    public partial class Layout : Window
    {
        public Layout()
        {
            InitializeComponent();
        }


        private void Btn_atras_layout(object sender, RoutedEventArgs e)
        {
            atrasLayout.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            pb.Visibility = Visibility.Hidden;
            MainLayout.Visibility = Visibility.Visible;
        }


        private void Btn_pb(object sender, RoutedEventArgs e)
        {
            MainLayout.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            pb.Visibility = Visibility.Visible;
            atrasLayout.Visibility = Visibility.Visible;
        }
        private void Btn_p1(object sender, RoutedEventArgs e)
        {
            MainLayout.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            pb.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Visible;
            atrasLayout.Visibility = Visibility.Visible;
        }
        private void Btn_p2(object sender, RoutedEventArgs e)
        {
            MainLayout.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            pb.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Visible;
            atrasLayout.Visibility = Visibility.Visible;
        }
        private void Btn_p3(object sender, RoutedEventArgs e)
        {
            MainLayout.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Hidden;
            pb.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Visible;
            atrasLayout.Visibility = Visibility.Visible;
        }
    }
}
