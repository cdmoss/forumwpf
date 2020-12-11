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
using Reddit_Prototype.User_Control;

namespace Reddit_Prototype.Windows
{
    /// <summary>
    /// Interaction logic for PostScreen.xaml
    /// </summary>
    public partial class PostScreen : Window
    {
        MainWindow mw;

        public PostScreen(MainWindow mainWindow)
        {
            InitializeComponent();

            mw = mainWindow;
        }

        private void BtnPost_Click(object sender, RoutedEventArgs e)
        {
            mw.stkPosts.Children.Add(new Post(txtTitle.Text,txtContent.Text,mw));
            this.Close();
        }
    }
}
