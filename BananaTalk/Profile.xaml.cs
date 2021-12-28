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

namespace BananaTalk
{
    /// <summary>
    /// Profile.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Profile : UserControl
    {
        public int id = -1;
        public Profile()
        {
            InitializeComponent();
        }

        public string NickName
        {
            get
            {
                return profile_name.Text;
            }
            set
            {
                profile_name.Text = value;
            }
        }

        public bool isMe
        {
            set
            {
                if (value == false)
                {
                    profile_image.Width = 40;
                    profile_image.Height = 40;
                    profile_image.RadiusX = 15;
                    profile_image.RadiusY = 15;
                    profile_name.Margin = new Thickness(58, 0, 0, 0);
                }
            }
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(248, 248, 248));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}
