using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int len = 1;
        string code = "";
        public MainWindow()
        {
            InitializeComponent();
            code = File.ReadAllText("C:\\Users\\student\\Desktop\\code.txt");
        }

        private void CodeText_TextChanged(object sender, TextChangedEventArgs e)
        {
            CodeText.Text.Remove(CodeText.Text.Length - 1);
            CodeText.Text += code.ToCharArray()[len];
            len += 1;
        }
    }
}
