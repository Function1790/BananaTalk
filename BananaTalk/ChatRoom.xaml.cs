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

namespace BananaTalk
{
    /// <summary>
    /// ChatRoom.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatRoom : Window
    {
        public List<Message> messages = new List<Message>();
        public ChatRoom()
        {
            InitializeComponent();
        }
        void SenderOpacity(object sender, double opacity)
        {
            (sender as FrameworkElement).Opacity = opacity;
        }

        private void TopGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void TopGrid_CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            SenderOpacity(sender, 1);
        }

        private void TopGrid_CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            SenderOpacity(sender, 0.6);
        }

        private void TopGrid_CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        void Log(string title, object content)
        {
            Console.WriteLine($"[{title}] >> {content}");
        }

        void Send_Message()
        {
            int n = messages.Count;
            messages.Add(new Message());
            messages[n].isMe = true;
            messages[n].Text = Send_TextBox.Text;
            Send_TextBox.Text = "";

            messages[n].VerticalAlignment = VerticalAlignment.Top;
            messages[n].HorizontalAlignment = HorizontalAlignment.Right;
            double sum_y = 0;
            try
            {
                sum_y = messages[n-1].Margin.Top + messages[n-1].Height - 5;
            }
            catch
            {
                sum_y = 0;
            }
           
            messages[n].Margin = new Thickness(0, sum_y + 10, 0, 0);
            ChatGrid.Children.Add(messages[n]);
        }

        void Receive_Message(string msg)
        {
            int n = messages.Count;
            messages.Add(new Message());
            messages[n].isMe = false;
            messages[n].Text = msg;
            messages[n].VerticalAlignment = VerticalAlignment.Top;
            messages[n].HorizontalAlignment = HorizontalAlignment.Left;
            double sum_y = 0;
            try
            {
                sum_y = messages[n - 1].Margin.Top + messages[n - 1].Height - 5;
            }
            catch
            {
                sum_y = 0;
            }

            messages[n].Margin = new Thickness(0, sum_y + 10, 0, 0);
            ChatGrid.Children.Add(messages[n]);
        }

        void Send_Button_Reset()
        {
            Send_Disabled.Visibility = Visibility.Hidden;
            Send_Enabled.Visibility = Visibility.Hidden;
            Send_Lost_Focus.Visibility = Visibility.Hidden;
        }

        void Set_Send_Button_Color()
        {
            string text = Send_TextBox.Text;
            if (text != "" && text != "\n")
            {
                Send_Button_Reset();
                Send_Enabled.Visibility = Visibility.Visible;
            }
            else
            {
                Send_Button_Reset();
                Send_Disabled.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = (sender as TextBox).Text;
            Set_Send_Button_Color();
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            Send_Button_Reset();
            Set_Send_Button_Color();
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            Send_Button_Reset();
            Send_Lost_Focus.Visibility = Visibility.Visible;
        }

        private void Send_Enabled_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Receive_Message(Send_TextBox.Text);
            }
        }

        private void Message_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter || e.Key == Key.Return)
            {
                Send_Message();
            }
        }
    }
}
