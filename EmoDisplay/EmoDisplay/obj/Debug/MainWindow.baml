   M S B A M L   `   `   `  ����  
EmoDisplay    EmoDisplay.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $	��105��6   $	��500��6)    � 	Resources 5         BtnStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6!   .�5      ��  � ��$	 100��6&   64   �� 5       � ��$ 50��6'   64   �� 5	       � ��$ 10 10 10 10q�6'   6=   5
      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$
 Load��5   7   #��[  6   .��6X   阻抗检测6^   �� 5      -   5        $	 EEG��5   7   #��[  6   .��6V   	数据图6[   �� 5      -   5        $	 FFT��5   7   #��[  6   .��6V   FFT图6\   �� 5      -   5        $ Brain��5   7   #��[  6   .��6Z   脑地形图6`   5      5      5      