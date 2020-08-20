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

namespace AnalizadorLexico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] lexema;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            //Separa las palabras de la oracion cuando hay un espacio
            lexema = txt_cadena.Text.Split(' ');
            foreach (var lexema in lexema)
            {
                System.Console.WriteLine($"<{lexema}>");
            }
            //se captura el valor de la caja de texto txt_cadena
            Console.WriteLine(txt_cadena.Text);
        }
    }
}
