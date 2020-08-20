using System;
using System.Text.RegularExpressions;
using System.Windows;

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
            listV_palabra.Items.Clear();
            listV_numEntero.Items.Clear();
            listV_numDecimal.Items.Clear();
            listV_moneda.Items.Clear();

            //Separa las palabras de la oracion cuando hay un espacio
            lexema = txt_cadena.Text.Split(' ');
            for (int i = 0; i < lexema.Length; i++)
            {
                if (Regex.IsMatch(lexema[i], @"^[a-zA-Z]+$"))
                {
                    listV_palabra.Items.Add(lexema[i]);
                }else if (Regex.IsMatch(lexema[i], @"^[0-9]+$"))
                {
                    listV_numEntero.Items.Add(lexema[i]);
                }
                //System.Console.WriteLine(lexema[i]);
            }
//            foreach (var lexema in lexema)
//            {
//                System.Console.WriteLine($"<{lexema}>");
//            }
            //se captura el valor de la caja de texto txt_cadena
            Console.WriteLine(txt_cadena.Text);
        }
    }
}
