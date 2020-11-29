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

namespace Superheroes
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

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreTextBox.Text = "";
            rutaImagenTextBox.Text = "";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bool esHeroe = (sender as RadioButton).Tag.Equals("heroe");
            if (esHeroe)
            {
                vengadoresCheckBox.IsEnabled = true;
                xmenCheckBox.IsEnabled = true;
                villanoRadioButton.IsChecked = false;
            }
            else
            {
                vengadoresCheckBox.IsEnabled = false;
                xmenCheckBox.IsEnabled = false;
                heroeRadioButton.IsChecked = false;
            }
        }
    }
}
