   M S B A M L   `   `   `  ����F  BCiburuyDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CiburuyDeskCiburuyDesk  5   	       CiburuyDesk.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CiburuyDesk     5   	     � Title$  Ciburuy Desk��5   	   $	��720��6   $
��1280��6+   $��Center=�68   $��Center=�6U    � WindowStartupLocation$ CenterScreen=�6p    � WindowState$ 	Maximized=�6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ bg��5
      $��img/bg-login.png��6   $
��Fill=�66   $��0,0,-0.4,0.4q�6E   � 5   
   $��365,169,363.6,168.4q�6   $��Center=�6,   $��Center=�6I   $	��353��6d   $	��545��6q    � ColumnDefinitions 5      �� 5      $
��272* �6#   �� 5      $
��273* �6#   .+�5      �� -   5        $ pwd_icon_png��5      $��94,162,130,143q�6*   $��img/pwd-icon.png��6B   $
��Fill=�6\   $��48��6k   $��48��6v   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ email_icon_png��5      $��94,89,130,216q�6,   $��img/email-icon.png��6C   $
��Fill=�6_    J� RenderTransformOrigin$ 0.5,0.5&�6n   $��48��6�   $��48��6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ masukBtn��5      $
��Left=�6&   $��53��6A   $��45,216,0,84q�6M   $��Center=�6b   $	��133��6}   $��img/masuk-btn.png��6�    � Cursor$
 Hand��6�   $��1��6  �� 5      -   5        	 ��Name$	 emailBox��5      $��Center=�6(   $��161,95,94.8,222q�6E   $��Center=�6^   $��36��6y   $	��289��6�   $��22(�6�   $��2��6�   $��Email��6�   
�������$��1��6  G� 5      -   5        
 G�Name$
 pwdBox��5      $��Center=�6*   $��161,169,94.8,149q�6G   $��Center=�6a   $	��289��6|   $��2��6�   $��35��6�   $��22(�6�   $��3��6�   �� 5      -   5        $	 passBox��5      $��Center=�6'   $��161,169,94.8,149q�6D   $��Center=�6^   $��35��6y   $	��289��6�   $��22(�6�   $��2��6�   $��Password��6�   
�������$��2��6�   5      5      5      