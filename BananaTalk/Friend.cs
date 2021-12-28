using BananaTalk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

class Friend
{
    string name;
    int id = -1;
    public Profile Profile = new Profile();
    public ChatRoom room;
    public ChatRoom_Profile ChatRoom_Profile = new ChatRoom_Profile();
    bool isClosed = true;

    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
            Profile.id = value;
            ChatRoom_Profile.id = value;
        }
    }

    public string NickName
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    void Room_Closed(object sender, EventArgs e)
    {
        isClosed = true;
    }

    public void openChat()
    {
        if (isClosed)
        {
            
            room = new ChatRoom();
            room.profile_Name.Text = NickName;
            room.Closed += Room_Closed;
            isClosed = false;
            room.Show();
        }
    }

    public Friend() { }

    public Friend(string Name)
    { 
        this.NickName = Name;
        Profile.VerticalAlignment = VerticalAlignment.Top;
        Profile.HorizontalAlignment = HorizontalAlignment.Left;
        Profile.Width = 334;
        Profile.Height = 55;
        Profile.isMe = false;
        Profile.NickName = Name;

        ChatRoom_Profile.Height = 70;
        ChatRoom_Profile.Width = 334;
        ChatRoom_Profile.NickName = Name;
        ChatRoom_Profile.LastContent = "";
        ChatRoom_Profile.VerticalAlignment = VerticalAlignment.Top;
        ChatRoom_Profile.HorizontalAlignment = HorizontalAlignment.Left;
    }
}
