   M S B A M L   `   `   `  ����F  BCiburuyDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CiburuyDeskCiburuyDesk  5   	        CiburuyDesk.DataPengunjung   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CiburuyDesk     5   	     � Title$  Ciburuy Desk��5   	   $	��720��6   $
��1280��6+    � WindowStartupLocation$ CenterScreen=�68    � WindowState$ 	Maximized=�6]   $��Center=�6u   $��Center=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��640* �6   �� 5      $
��640* �6   .+�5   
   �� -   5         ��Name$ bg��5      $��
img/bg.png��6   $
��Fill=�60   $��0,0,-0.4,0.4q�6?   $��2��6U   �� 5   
   -   5         ��Name$ judul��5      $��Data Pengunjung��6   $��Center=�69   $��402,51,402.6,548.4q�6V   $��Center=�6r   $	��469��6�   $��Monotype Corsiva)�6�   $��72(�6�   $��2��6�   �� 5   
   -   5        $
 back��5      $��img/back-icon.png��6   $
��Left=�69   $��47��6T   $��	10,10,0,0q�6`   $	��Top=�6s   $��47��6�   6�   �� 5   
   -   5         ��Name$ 
refreshbtn��5      $��2��6%   $��Refresh��69   $��Center=�6K   $��561,505,560.6,146.4q�6h   $��Center=�6�   $	��152��6�   $��39��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��Center=�6=   $	��342��6Z   $��407,147,408.6,201.4q�6g   $��Center=�6�   $	��458��6�      CanUserResizeRows .  	   CanUserResizeColumns	 .  $��2��6�   ��6%   �� 5      5      5      