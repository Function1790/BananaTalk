   M S B A M L   `   `   `  ����E  ABananaTalk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BananaTalk
BananaTalk  5   	       BananaTalk.ChatRoom   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BananaTalk     5   	   -   5          � AllowsTransparency  .  � WindowStyle$
 None=�5	   	    � Title$ ChatRoom��5   	   $	��600��6   $	��350��6'    � Icon$ 	logoB.png��63   .��5      � ���	#FFB2C7D9.+�5   
   � -   5         �Name$ ChatGrid��5      $��
0,73,0,104q�6!   � 5   
   -   5        $ TopGrid��5      $��73��6>   $	��Top=�6J   ���	#FFA9BDCE.+�5      �� -   5         ��Name$ profile_image��5       � Cursor$
 Hand��6/   $
��Left=�6=   $��53��6X   $��
10,10,0,10q�6d   $��Center=�6x   $��53��6�    �� RadiusY$ 20��6�    �� RadiusX$ 20��6�   ��5      �� 5      	 �� ImageSource$	 BaseProfile.png��6!   5      �� 5      -   5        
 ��Name$
 profile_Name��5      $
��Left=�6.   $��	75,14,0,0q�6I   $
��Wrap=�6\   $��집게사장님��6p   $	��Top=�6}   ���	#FF4A4C4E$
��Bold"�6�   �� 5      -   5        $ TopGrid_CloseButton��5       J� Opacity$	 0.6Q�6�   $
��Left=�6�   $��9��6�   $��
332,10,0,0q�6�   $	��Top=�6�   $��8��6  ��5      �� 5      $	 close(room).png��6!   5      5      � 5   
   $	��104��6   $��0,0,0,0q�6   $��Bottom=�6-   
�������$y�Visible=�6[   .+�5      �� -   5         ��Name$ Send_TextBox��5      $��0,0,0,0q�6,   $
��Left=�6F   $��72��6�   $��	15,15,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��277��6�   ��6�   Z� ��6�   Z� �� 5      -   5        $ Send_Disabled��5      $
��Left=�6/   $��27��6J   $��
297,15,0,0q�6V   $	��Top=�6j   $��47��6�   ��5       �� 5!      $	 send_disabled.png��6!   5#      �� 5$      -	   5        $ Send_Enabled��5$      $
��Left=�6Q   $
 Hand��6l   $��27��6z   $��
297,15,0,0q�6�   $	��Top=�6�   $��47��6�   $y�Hidden=�6�   ��5%      �� 5&      $	 send_enabled.png��6!   5(      �� 5)      -
   5        $ Send_Lost_Focus��5)      $
��Left=�61   $��30��6L   $��
297,15,0,0q�6X   $	��Top=�6l   $��47��6�   $y�Hidden=�6�   ��5*      �� 5+      $	 send_lost_focused.png��6!   5-      5.      50      51      