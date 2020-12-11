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
using Reddit_Prototype.Classes;

namespace Reddit_Prototype.Windows
{
    /// <summary>
    /// Interaction logic for RegisterScreen.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        DatabaseReader db;

        public RegisterScreen()
        {
            InitializeComponent();
            db = new DatabaseReader();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            db.addUser(txtRegName.Text, txtRegPass.Text, txtRegEmail.Text, 0);
            this.Close();
        }
    }
}
