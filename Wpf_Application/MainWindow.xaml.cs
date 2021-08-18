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
using Calculator_Model;

namespace Wpf_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator _calculator;
        public MainWindow()
        {
            InitializeComponent();

            _calculator = new Calculator();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //if (sender is Button)
            //{
            //    var bSender = (Button)sender;
            //    MessageBox.Show($"{bSender.Name} I told you not to press me");
            //}
            lblResult.Content = _calculator.Add();
        }

        

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(tbxNum1.Text, out double num1))
            {
                _calculator.Num1 = num1;
            }
            else
            {
                lblResult.Content = "Invalid Input";
            }
        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum2.Text, out double num1) ? _calculator.Num2 = num1 : lblResult.Content = "Invalid Input";
        }

    }
}