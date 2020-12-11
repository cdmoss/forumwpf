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
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        private string _title;
        private string _content;

        private MainWindow mw;

        public Post(string title, string content, MainWindow mw)
        {
            InitializeComponent();
            _title = title;
            _content = content;

            lblName.Content = _title;
            txtContent.Text = _content;
            this.mw = mw;

            lblPoster.Content = mw.MyUser.Username + " " + DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Comment comment = new Comment(mw.MyUser.Username, txtComment.Text, mw);

            this.stkPostComments.Children.Add(comment);
        }
    }
}
