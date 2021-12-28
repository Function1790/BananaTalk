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
using System.Windows.Threading;

namespace BananaTalk
{
    /// <summary>
    /// Message.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Message : UserControl
    {
        const double TAIL_WIDTH = 6;
        const double CHAT_WIDTH = 25;
        const double CHAT_HEIGHT = 30;
        const double BOX_MAX_WIDTH = 196;
        bool me = true;


        public Message()
        {
            InitializeComponent();
        }

        public bool isMe
        {
            get
            {
                return me;
            }
            set
            {
                me = value;
                Color c = Color.FromRgb(255, 235, 51);
                if (!me) { c = Colors.White; }
                t0.Fill = new SolidColorBrush(c);
                t1.Fill = new SolidColorBrush(c);
                t2.Fill = new SolidColorBrush(c);
                t3.Fill = new SolidColorBrush(c);
                t4.Fill = new SolidColorBrush(c);
                t5.Fill = new SolidColorBrush(c);
                Msg_Box.Fill = new SolidColorBrush(c);
            }
        }

        public string Text
        {
            get
            {
                return Msg_Content.Text;
            }
            set
            {
                Msg_Content.Text = value;
                if (value == "")
                {
                    Width = CHAT_WIDTH + TAIL_WIDTH;
                }
                else
                {
                    Height = 30;
                    Width = value.Length * CHAT_WIDTH + TAIL_WIDTH;
                    if (Width > 196)
                    {
                        Height = CHAT_HEIGHT * 2;
                        Width = BOX_MAX_WIDTH;     
                    }
                }
            }
        }
    }
}
