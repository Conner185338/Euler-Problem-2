/*
 * Conner Warboys
 * Project Euler Problem 2
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338FibonacciNumbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int Num1 = 0;
            int Num2 = 1;
            int Answer = 0;
            int Sum = 0;
            int Output = 1;

            while (Answer < 4000000)
            {
                Answer = Num1 + Num2;
                Num1 = Num2;
                Num2 = Answer;
                if (Answer % 2 == 0)
                {
                    Output = Sum += Answer;
                }
            }

            lblOutput.Content = Output;
        }
    }
}

