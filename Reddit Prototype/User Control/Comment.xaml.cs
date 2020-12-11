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

namespace Reddit_Prototype.User_Control
{
    /// <summary>
    /// Interaction logic for Comment.xaml
    /// </summary>
    public partial class Comment : UserControl
    {
        private string name;
        private string content;

        private MainWindow mw;

        public Comment(string name, string content, MainWindow mw)
        {
            InitializeComponent();

            this.name = name;
            this.content = content;

            lblPoster.Content = name + " " + DateTime.Now;
            txtBlockComment.Text = content;

            this.mw = mw;
        }
    }
}
