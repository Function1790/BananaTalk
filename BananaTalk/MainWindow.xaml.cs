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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Tabs
        {
            Friend,
            Chatting
        }

        List<Friend> friends = new List<Friend>();
        Tabs Selected_Tab = Tabs.Chatting;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            friends.Add(new Friend("뚱이"));
            friends.Add(new Friend("징징이"));
            friends.Add(new Friend("다람이"));
            friends.Add(new Friend("플랑크톤"));
            friends.Add(new Friend("래리"));
            friends.Add(new Friend("퐁퐁부인"));
            friends.Add(new Friend("진주"));

            for (int i=0; i<friends.Count; i++)
            {
                friends[i].ID = i;
                friends[i].Profile.Margin = new Thickness(0, 55 * i, 0, 0);
                friends[i].Profile.MouseDoubleClick += new MouseButtonEventHandler(Profile_MouseDoubleClick);
                FriendTab_Profiles.Children.Add(friends[i].Profile);

                friends[i].ChatRoom_Profile.MouseDoubleClick += new MouseButtonEventHandler(ChatRoom_Profile_MouseDoubleClick);
                friends[i].ChatRoom_Profile.Margin = new Thickness(0, 70 * i, 0, 0);
                ChatTab_Chats.Children.Add(friends[i].ChatRoom_Profile);
            }

            FriendTab_FriendText.Text = $"친구  {friends.Count}";
        }

        void ToolGrid_Reset()
        {
            ToolGrid_ToolBar1_Chatting.Opacity = 0.4;
            ToolGrid_ToolBar1_Friend.Opacity = 0.4;
            FriendTab.Visibility = Visibility.Hidden;
            ChatTab.Visibility = Visibility.Hidden;
        }

        bool SelectTab(Tabs tab)
        {
            if (tab == Selected_Tab)
            {
                return false;
            }

            Selected_Tab = tab;
            ToolGrid_Reset();

            switch (tab)
            {
                case Tabs.Friend:
                    FriendTab.Visibility = Visibility.Visible;
                    break;
                case Tabs.Chatting:
                    ChatTab.Visibility = Visibility.Visible;
                    break;
            }
            return true;
        }
        
        void SenderOpacity(object sender, double opacity)
        {
            (sender as FrameworkElement).Opacity = opacity;
        }
        
        void Tab_Tool_Opacity(Tabs tab, object sender, double opacity)
        {
            if (Selected_Tab != tab)
            {
                SenderOpacity(sender, opacity);
            }
        }

        private void TopGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Tool_MouseEnter(object sender, MouseEventArgs e)
        {
            SenderOpacity(sender, 0.4);
        }

        private void Tool_MouseLeave(object sender, MouseEventArgs e)
        {
            SenderOpacity(sender, 0.2);
        }

        private void Button_Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ToolGrid_ToolBar1_Friend_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTab(Tabs.Friend);
            SenderOpacity(sender, 1);
        }

        private void ToolGrid_ToolBar1_Chatting_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTab(Tabs.Chatting);
            SenderOpacity(sender, 1);
        }

        private void ToolGrid_ToolBar1_Friend_MouseEnter(object sender, MouseEventArgs e)
        {
            Tab_Tool_Opacity(Tabs.Friend, sender, 0.6);
        }

        private void ToolGrid_ToolBar1_Friend_MouseLeave(object sender, MouseEventArgs e)
        {
            Tab_Tool_Opacity(Tabs.Friend, sender, 0.4);
        }
        
        private void ToolGrid_ToolBar1_Chatting_MouseEnter(object sender, MouseEventArgs e)
        {
            Tab_Tool_Opacity(Tabs.Chatting, sender, 0.6);
        }

        private void ToolGrid_ToolBar1_Chatting_MouseLeave(object sender, MouseEventArgs e)
        {
            Tab_Tool_Opacity(Tabs.Chatting, sender, 0.4);
        }

        private void Profile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int n = -1;
            for(int i=0; i<friends.Count; i++)
            {
               if((sender as Profile).id == friends[i].ID)
                {
                    n = i;
                    break;
                }
            }
            friends[n].openChat();
        }
        
        private void ChatRoom_Profile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int n = -1;
            for(int i=0; i<friends.Count; i++)
            {
               if((sender as ChatRoom_Profile).id == friends[i].ID)
                {
                    n = i;
                    break;
                }
            }
            friends[n].openChat();
        }
    }
}
