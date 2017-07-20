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

namespace Calculator.cs
{
    public partial class MainWindow : Window
    {
        private double num1;
        private double num2;

        Calc calculator = new Calc(); // instance of calculator

        private void Parse() // parse method to make life easy.
        {
            try
            {
                num1 = double.Parse(TextBox1.Text);
                num2 = double.Parse(TextBox2.Text);
            }
            catch (FormatException) // catches the format exception to exclude anything but a numerical input.
            {
                MessageBox.Show("Please enter a valid numerical input.");
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Parse();
            calculator.Add(num1, num2);
            label1.Content = calculator.Sum;
        }
        // Parses the data, calls the calculator method add taking in both parameters and returns value to label1.content.

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Parse();
            calculator.Minus(num1, num2);
            label1.Content = calculator.Sum;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Parse();
            calculator.Multiply(num1, num2);
            label1.Content = calculator.Sum;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Parse();
            calculator.Divide(num1, num2);
            label1.Content = calculator.Sum;
        }
    }
}