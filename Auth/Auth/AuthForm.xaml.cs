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

namespace Auth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User("admin", "newpass"));
            users.Add(new User("АДМИН", "очки ннада?"));
        }

        class User
        {
            public string login;
            public string password;
            public User() { }
            public User(string login,string password)
            {
                this.password = password;
                this.login = login;
            }
        }

        List<User> users = new List<User>();

        private void Auth(object sender, RoutedEventArgs e)
        {
            int id = authorize(thisLogIn.Text, thisPassWord.Password);
            if (id!=-1)
            {
                Access.Content = "ACCESS GRANTED\nID:" +id;
            }
            else
            {
                Access.Content = "ACCESS DENIED";
            }
        }

        int authorize(string log,string pass)
        {
            for(int i=0;i<users.Count;i++)
            {
                if (users[i].login==log && users[i].password==pass)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
