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
    // This is the main class that uses Calc.cs abstract methods.
    public partial class MainWindow : Window
    {
        // These values are made private for the purpose of encapsulation.
        private double num1;
        private double num2;
        
        // Class instance of Calc.cs to call abstract methods.
        Calc calculator = new Calc(); 

        // A Parse function designed to convert a value from a textbox to a double.
        private void Parse()
        {
            try
            {
                num1 = double.Parse(TextBox1.Text);
                num2 = double.Parse(TextBox2.Text);
            }
            catch (FormatException) // Invalid input caught. Only numbers can be calculated.
            {
                MessageBox.Show("Please enter a valid numerical input.");
            }
        }
        
        // Starts The Main Window
        public MainWindow()
        {
            InitializeComponent();
        }

        // Auto Generated Method suffix '_Click' for buttons.
        // Each method uses abstract methods from Calc.cs; add, minus, divide, multiple
        // Methods created for GUI. On Click the curent values are parsed and checked before calculations are made.
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Parse();
            calculator.Add(num1, num2);
            label1.Content = calculator.Sum;
        }
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
