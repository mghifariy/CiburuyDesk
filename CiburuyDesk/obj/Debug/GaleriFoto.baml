   M S B A M L   `   `   `  ����F  BCiburuyDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CiburuyDeskCiburuyDesk  5   	       CiburuyDesk.GaleriFoto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CiburuyDesk     5   	     � Title$  Ciburuy Desk��5   	   $	��720��6   $
��1280��6+    � WindowStartupLocation$ CenterScreen=�68    � WindowState$ 	Maximized=�6]   $��Center=�6u   $��Center=�6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��319* �6   �� 5      $
��372* �6    � ColumnDefinitions 5   
   �� 5      $
��640* �6   �� 5      $
��640* �6   .+�5   
   �� -   5         ��Name$ bg��5      $��0,0,-0.4,2.4q�6   $��
img/bg.png��62   $
��Fill=�6F   $��Center=�6U   $��Center=�6r   $��2��6�   $��2��6�   �� 5   
   -   5         ��Name$ judul��5      $��Galeri Foto��6   $��Center=�65   $��484,56,482.6,179.8q�6R   $��Center=�6n   $	��307��6�   $��Monotype Corsiva)�6�   $��72(�6�   $��2��6�   �� 5   
   -   5        $
 back��5      $��img/back-icon.png��6   $
��Left=�69   $��47��6T   $��	10,10,0,0q�6`   $	��Top=�6s   $��47��6�   6�   �� 5   
   -   5        $ image1��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��551,148,552.6,1.8q�6h   $��Center=�6�   $	��170��6�   $��2��6�   �� 5   
   -   5        $ image2��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��379,148,88.8,1.8q�6h   $��Center=�6�   $	��169��6�   �� 5   
   -   5        $ image3��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��88.2,148,379.6,1.8q�6h   $��Center=�6�   $	��169��6�   $��1��6�   �� 5   
   -   5        $ image4��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��379,2.6,88.8,200.4q�6h   $��Center=�6�   $	��169��6�   $��1��6�   �� 5   
   -   5        $ image5��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��551,2.2,552.6,200.4q�6h   $��Center=�6�   $	��170��6�   $��2��6�   $��1��6�   �� 5   
   -	   5        $ image6��5      $��img/picture-icon.png��6    $��Center=�6>   $	��169��6[   $��88.2,2.2,379.6,200.4q�6h   $��Center=�6�   $	��169��6�   $��1��6�   $��1��6�   �� 5   
   -
   5        $
 prev��5      $��img/backpage-icon.png��6   $��Center=�6=   $	��100��6Z   $��274,269,262.8,321.4q�6g   $��Center=�6�   $	��100��6�   $��2��6�   6�   �� 5   
   -   5        $
 next��5      $��img/nextpage-icon.png��6   $��Center=�6=   $	��100��6Z   $��262.2,269,274.6,321.4q�6g   $��Center=�6�   $	��100��6�   $��2��6�   $��1��6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   6�   �� 5   
   -   5        
 ��Name$

 page��5      $��Center=�6"   $��616,197.6,616.6,144.4q�6?   $��1��6^   $
��Wrap=�6k   $��1 / 10��6   $��Center=�6�   $��22(�6�   $��2��6�   5      5       