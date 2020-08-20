using System;
using System.Linq;
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
                }else if (Regex.IsMatch(lexema[i], "[Q$]+.*"))
                {
                    Console.WriteLine(lexema[i].Substring(0,1));
                    String moneda = lexema[i].Substring(0, 1);
                    Console.WriteLine(lexema[i].Substring(1, lexema[i].Length-1));
                    String numero = lexema[i].Substring(1, lexema[i].Length - 1);
                    if (Regex.IsMatch(moneda, "[Q$]+.*"))
                    {
                        listV_moneda.Items.Add(moneda);
                    }
                    if (Regex.IsMatch(numero, ".*[.].*" + "[0-9]*"))
                    {
                        //String numeroEntero = numero.Substring(0, numero.IndexOf("."));
                        listV_numDecimal.Items.Add(numero);
                    } 
                    if (Regex.IsMatch(numero, @"^[0-9]+$"))
                    {
                        listV_numEntero.Items.Add(numero);
                    }
                    //listV_numEntero.Items.Add(lexema[i]);
                }else if (Regex.IsMatch(lexema[i], ".*[.].*" + "[0-9]*"))
                {
                    listV_numDecimal.Items.Add(lexema[i]);
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
