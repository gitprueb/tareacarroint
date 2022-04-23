using interfazcarro.clase;
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

namespace interfazcarro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carro carrito; 
        public MainWindow()
        {
            InitializeComponent();
            carrito = new Carro("fort", 2022, 250, "mario");
        }

        private void acelerar_Click(object sender, RoutedEventArgs e)
        {
           
         
            encendido.Text = carrito.acelerar();
        }

        private void encender_Click(object sender, RoutedEventArgs e)
        {
            
            encendido.Text = carrito.EncenderMotor();
        }

        private void frenar_Click(object sender, RoutedEventArgs e)
        {
            encendido.Text = carrito.FRENAR();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            encendido.Text = carrito.desacelerar(-25);
        }

        private void apagar_Click(object sender, RoutedEventArgs e)
        {
            encendido.Text =  carrito.apagar();
        }
    }
}
