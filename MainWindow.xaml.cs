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

namespace CalculatorTryTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;
        string operation = "";
        string output = "";
        private string userInput = "";
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            DivideButton.Content = "\u00F7";
        }


        private  void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            
            switch(name)
            {
                case "OneButton":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;
                case "TwoButton":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;
                case "ThreeButton":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;
                case "FourButton":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;
                case "FiveButton":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;
                case "SixButton":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;
                case "SevenButton":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;
                case "EightButton":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;
                case "NineButton":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;
                case "ZeroButton":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

            }
        }

        private  void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
                
            }
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";

            }

        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Division";

            }
        }

        private void TimesButton_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Multiplication";

            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp = 0;

            Calculate(outputTemp);
        }

        private void Calculate(double outputTemp)
        {
            switch (operation)
            {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Multiplication":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Division":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break;
         
             
            }
        }

        private  void KeyboardInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is a number key (0-9)
            if (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                // Append the pressed key (number) to the user input
                output += e.Key.ToString().Last();
                OutputTextBlock.Text = output;

            }
            else
            {
                switch (e.Key)
                {
                    case Key.Add:
                        temp = double.Parse(output);
                        output = "";
                        operation = "Plus";
                        break;
                    case Key.Subtract:
                        temp = double.Parse(output);
                        output = "";
                        operation = "Minus";
                        break;
                    case Key.Multiply:
                        temp = double.Parse(output);
                        output = "";
                        operation = "Multiplication";
                        break;
                    case Key.Divide:
                        temp = double.Parse(output);
                        output = "";
                        operation = "Division";
                        break;
                    case Key.Enter:
                        double outputTemp = 0;
                        Calculate(outputTemp);
                        break;
                    case Key.Back:
                        output = "";
                        OutputTextBlock.Text = output;
                        break;



                }
            }

        }

    }
}
