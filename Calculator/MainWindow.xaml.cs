using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double _number1 = 0;
        private double _number2 = 0;
        private string _op = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 0;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 0;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn1_Click(object sender , RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 1;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 1;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 2;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 2;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 3;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 3;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 4;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 4;
                txtDispay.Text = _number2.ToString();
            }
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 5;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 5;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 6;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 6;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 7;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 7;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 8;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 8;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (_op == "")
            {
                _number1 = (_number1 * 10) + 9;
                txtDispay.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + 9;
                txtDispay.Text = _number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            _op = "+";
            txtDispay.Text = "0";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            _op = "-";
            txtDispay.Text = "0";
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            _op = "*";
            txtDispay.Text = "0";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            _op = "/";
            txtDispay.Text = "0";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (_op) 
            {
                case "+":
                    txtDispay.Text = (_number1 + _number2).ToString();
                    break;
                case "-":
                    txtDispay.Text = (_number1 - _number2).ToString();
                    break;
                case "*":
                    txtDispay.Text = (_number1 * _number2).ToString();
                    break;
                case "/":
                    try
                    {
                        txtDispay.Text = (_number1 / _number2).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division of {0} by zero.", _number1);
                    }
                    break;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            _number1 = 0;
            _number2 = 0;
            _op = "";
            txtDispay.Text = "0";
        }
    }
}
