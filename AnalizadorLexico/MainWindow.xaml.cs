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
                    //Determina si existe una palabra con letras del abecedario mayusculas o minusculas
                if (Regex.IsMatch(lexema[i], @"^[a-zA-Z]+$"))
                {
                    listV_palabra.Items.Add(lexema[i]);
                    //Determina si ingresa un numero entero a la oracion   
                }else if (Regex.IsMatch(lexema[i], @"^[0-9]+$"))
                {
                    listV_numEntero.Items.Add(lexema[i]);
                    //Determina si hay un signo de moneda en quetzales o dolares
                }else if (Regex.IsMatch(lexema[i], "[Q$]+.*"))
                {
                    //separa la palabra con su moneda y numero ya sea entero o decimal
                    String moneda = lexema[i].Substring(0, 1);
                    String numero = lexema[i].Substring(1, lexema[i].Length - 1);
                    //Determina e ingresa el valor de la moneda
                    if (Regex.IsMatch(moneda, "[Q$]+.*"))
                    {
                        listV_moneda.Items.Add(moneda);
                    }
                    //Determina si tenemos un numero decimal despues de el simbolo de la moneda y lo agrega a tabla decimales
                    if (Regex.IsMatch(numero, ".*[.].*" + "[0-9]*"))
                    {
                        listV_numDecimal.Items.Add(numero);
                    }
                    //Determina si es un numero entero lo agrega a su tabla enteros
                    if (Regex.IsMatch(numero, @"^[0-9]+$"))
                    {
                        listV_numEntero.Items.Add(numero);
                    }
                    //Determina si hay un decimal entre la oracion y no necesariamente despues de un simbolo de moneda
                }else if (Regex.IsMatch(lexema[i], ".*[.].*" + "[0-9]*"))
                {
                    listV_numDecimal.Items.Add(lexema[i]);
                }
               
            }
        }
    }
}
