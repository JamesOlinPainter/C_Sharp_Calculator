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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number = "";
        long runningTotal = 0; 
        string operation = "";
        string displayString = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            number += "1";
            txtDisplay.Text = displayString + number;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            number += "2";
            txtDisplay.Text = displayString + number;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            number += "3";
            txtDisplay.Text = displayString + number;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            number += "4";
            txtDisplay.Text = displayString + number;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            number += "5";
            txtDisplay.Text = displayString + number;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            number += "6";
            txtDisplay.Text = displayString + number;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            number += "7";
            txtDisplay.Text = displayString + number;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            number += "8";
            txtDisplay.Text = displayString + number;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            number += "9";
            txtDisplay.Text = displayString + number;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            number += "0";
            txtDisplay.Text = displayString + number;
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            computeTotal();
            operation = "+";
            displayString += number + " + ";
            txtDisplay.Text = displayString;
            number = "";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            computeTotal();
            operation = "-";
            displayString += number + " - ";
            txtDisplay.Text = displayString;
            number = "";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            if (number == "")
            {
                displayString = "";
                txtDisplay.Text = "0";
                operation = "";
                runningTotal = 0;
            }
            else
            {
                number = "";
                txtDisplay.Text = displayString;
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            computeTotal();
            displayString = runningTotal.ToString("N0");
            txtDisplay.Text = displayString;
            number = "";
        }

        private void computeTotal()
        {
            switch (operation)
            {
                case "+":
                    if (number != "")
                    {
                        runningTotal = runningTotal + long.Parse(number);
                    }
                    break;
                case "-":
                    if (number != "")
                    {
                        runningTotal = runningTotal - long.Parse(number);
                    }
                    break;
                default:
                    if (number != "")
                    {
                        runningTotal = long.Parse(number);
                    }
                    else
                    {
                        runningTotal = 0;
                    }
                    break;
            }
        }
    }   //  end class
}   //  end namespace
