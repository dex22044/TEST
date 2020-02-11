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

namespace ValuteConverter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FromVal.Items.Add("RUB");
            FromVal.Items.Add("USD");
            FromVal.Items.Add("EUR");
            FromVal.Items.Add("CHF");
            FromVal.Items.Add("GBP");

            ToVal.Items.Add("RUB");
            ToVal.Items.Add("USD");
            ToVal.Items.Add("EUR");
            ToVal.Items.Add("CHF");
            ToVal.Items.Add("GBP");
        }

        private void Conv(object sender, RoutedEventArgs e)
        {
            double input = Convert.ToDouble(FirstVal.Text);
            double output = convert(input, FromVal.Text, ToVal.Text);
            SecondVal.Text = Convert.ToString(output);
            ops.Items.Add(input+" "+FromVal.Text);
        }

        private double convert(double val,string from,string to)
        {
            double usd = 0;
            switch (from)
            {
                case "RUB": usd = val * 0.016; break;
                case "USD": usd = val * 1; break;
                case "EUR": usd = val * 1.09; break;
                case "CHF": usd = val * 1.02; break;
                case "GBP": usd = val * 1.29; break;
            }

            switch (to)
            {
                case "RUB": return usd / 0.016; break;
                case "USD": return usd / 1; break;
                case "EUR": return usd / 1.09; break;
                case "CHF": return usd / 1.02; break;
                case "GBP": return usd / 1.29; break;
            }
            return 0;
        }
    }
}
