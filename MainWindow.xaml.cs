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

namespace Rekenmachine
{
    public partial class MainWindow : Window
    {
        // strings

        string number1 = "";
        string number2 = "";
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VoegNummerToe(1);
        }

        private void VoegNummerToe(int nummer)
        {
            if (operation == "")
            {
                number1 += nummer.ToString();
                textDisplay.Text = number1;
            }
            else
            {
                number2 = number2 + nummer.ToString(); ;
                textDisplay.Text = number2;
            }
        }

        //button cijfers
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            VoegNummerToe(2);

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(3);

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(4);

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(5);

        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(6);

        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(7);


        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(8);

        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(9);

        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {

            VoegNummerToe(0);

        }

        //button functions/sommen
        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            
        }

        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            
        }

        //button equals/= & resultaat
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            decimal result = 0;
            decimal decimal1 = decimal.Parse(number1);
            decimal decimal2 = decimal.Parse(number2);

            switch (operation)
            {
                case "+":
                    result = decimal1 + decimal2;
                    break;
                case "-":
                    result = decimal1 - decimal2;
                    break;
                case "*":
                    result = decimal1 * decimal2;
                    break;
                case "/":
                    result = decimal1 / decimal2;
                    break;


            }

            number1 = result.ToString();
            number2 = "";
            textDisplay.Text = result.ToString();
        }

        //button Clear alles
        private void buttonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = "0";
            }
            else
            {
                number2 = "0";
            }

            textDisplay.Text = "0";

        }
        //button clear laats toegevoegde
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = "";
            number2 = "";
            operation = "";
            textDisplay.Text = "0";
        }
        //button wiss laats toegevoegde getal/som
        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = number1.Substring(1);
                textDisplay.Text = number1;
            }
            else
            {
                number2 = number2.Substring(1);
                textDisplay.Text = number2.ToString();
            }

        }
        //button +/-
        private void buttonPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = "-" + number1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = "-" + number2;
                textDisplay.Text = number2.ToString();
            }
        }
        //button ,
        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + ",";
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 + ",";
                textDisplay.Text = number2.ToString();
            }
        }
    }
}
