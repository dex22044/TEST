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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double prevNum = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberBtn(object sender, RoutedEventArgs e)
        {
            NumText.Text += ((Button)sender).Content;
        }

        private void NumberClr(object sender, RoutedEventArgs e)
        {
            operation = "";
            prevNum = 0;
            NumText.Text = "";
        }

        private void OperationBtn(object sender, RoutedEventArgs e)
        {
            prevNum = Convert.ToDouble(NumText.Text);
            operation = ((Button)sender).Content.ToString();
            NumText.Text = "";
        }

        private void EqualsBtn(object sender, RoutedEventArgs e)
        {
            double res=0;
            if (operation == "+")
            {
                res = prevNum + Convert.ToDouble(NumText.Text);
            }
            if (operation == "-")
            {
                res = prevNum - Convert.ToDouble(NumText.Text);
            }
            if (operation == "*")
            {
                res = prevNum * Convert.ToDouble(NumText.Text);
            }
            if (operation == "/")
            {
                res = prevNum / Convert.ToDouble(NumText.Text);
            }
            if (operation == "%")
            {
                res = prevNum % Convert.ToDouble(NumText.Text);
            }
            if (operation == "^")
            {
                res = Math.Pow(prevNum, Convert.ToDouble(NumText.Text));
            }
            if (operation == "Sin")
            {
                res = Math.Sin(prevNum/57.29578);
            }

            NumText.Text = Convert.ToString(res);
        }

        private void EraseNum(object sender, RoutedEventArgs e)
        {
            if(NumText.Text.Length>0)
                NumText.Text = NumText.Text.Remove(NumText.Text.Length-1);
        }
    }
}
