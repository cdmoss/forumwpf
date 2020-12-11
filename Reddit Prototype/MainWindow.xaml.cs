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
using Reddit_Prototype.Windows;
using Reddit_Prototype.Classes;

namespace Reddit_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User MyUser { get;  set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen login = new LoginScreen(this);

            login.ShowDialog();
        }

        private void BtnPost_Click(object sender, RoutedEventArgs e)
        {
            if(MyUser == null)
            {
                MessageBox.Show("Please login to post!");
            }
            else
            {
                PostScreen post = new PostScreen(this);

                post.ShowDialog();
            }
        }
    }
}
