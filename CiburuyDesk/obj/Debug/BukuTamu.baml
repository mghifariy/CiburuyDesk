   M S B A M L   `   `   `  ����F  BCiburuyDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CiburuyDeskCiburuyDesk  5   	       CiburuyDesk.BukuTamu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CiburuyDesk     5   	     � Title$  Ciburuy Desk��5   	   $	��720��6   $
��1280��6+   $��Center=�68   $��Center=�6U    � WindowState$ 	Maximized=�6p    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��640* �6   �� 5      $
��640* �6   .+�5   
   �� -   5         ��Name$ bg��5      $��img/bg-awal.png��6   $
��Fill=�65   $��0,0,-0.4,0.4q�6D   $��2��6Z   � 5   
   $��365,169,363.6,168.4q�6   $��Center=�6,   $��Center=�6I   $	��353��6d   $	��545��6q   $��2��6}    5      �� 5      $
��272* �6#   �� 5      $
��273* �6#   .+�5      �� -   5         ��Name$ emailBox��5      $��Center=�6(   $��35��6E   $��161,169,93.8,149q�6Q   $��Center=�6k   $	��290��6�   $��22(�6�   $��2��6�   
�������$��Email (opsional)��6�   $��2��6  �� 5      -   5        $ email_icon_png��5      $��94,162,130,143q�6,   $��img/email-icon.png��6D   $
��Fill=�6`   $��48��6o   $��48��6z   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ user_icon_png��5      $��94,89,130,216q�6+   $��img/user-icon.png��6B   $
��Fill=�6]    J� RenderTransformOrigin$ 0.5,0.5&�6l   $��48��6�   $��48��6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ masukBtn��5      $
��Left=�6&   $��53��6A   $��45,216,0,84q�6M   $��Center=�6b   $	��133��6}   $��img/masuk-btn.png��6�   	 � Cursor$
	 Hand��6�   $��1��6  �� 5      -   5        $ namaBox��5      $��Center=�6'   $��161,95,94.8,222q�6D   $��Center=�6]   $��36��6x   $	��289��6�   $��22(�6�   $��2��6�   $
��Nama��6�   
�������
�������$��1��6"  �� 5      -   5        
 ��Name$
 label��5      $��Punya akun?��6#   $
��Left=�69   $��
96,274,0,0q�6T   $	��Top=�6h   $��Italic$�6�   
�������$
��Bold"�6�   $
	 Hand��6�   $��1��6�   $��26��6�   $��82��6�   6�   5      5      5      