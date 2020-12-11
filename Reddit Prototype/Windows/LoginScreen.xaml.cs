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
using System.Windows.Shapes;
using System.Windows.Navigation;
using Reddit_Prototype.Windows;
using Reddit_Prototype.Classes;

namespace Reddit_Prototype.Windows
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        DatabaseReader db;
        MainWindow mw;

        public LoginScreen(MainWindow mainwindow)
        {
            InitializeComponent();
            db = new DatabaseReader();
            mw = mainwindow;
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterScreen screen = new RegisterScreen();
            screen.ShowDialog();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(db.checkLogin(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Succesfull Login");
                mw.MyUser = new User(txtUserName.Text, txtPassword.Text, db.getEmail(txtUserName.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Login credentials failed");
            }
        }
    }
}
