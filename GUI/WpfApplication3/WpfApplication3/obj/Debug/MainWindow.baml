   M S B A M L   `   `   `  ����Q  MMusicClassificationGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MusicClassificationGuiMusicClassificationGui  5   F  S.clr-namespace:MusicClassificationGui.ViewModel MusicClassificationGui.ViewModel  6y  '    !MusicClassificationGui.MainWindow   6	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6K   c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  6�   :d2http://schemas.microsoft.com/expression/blend/2008  6�   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6�   0local$clr-namespace:MusicClassificationGui  6F  U MusicClassificationGui_ViewModel.clr-namespace:MusicClassificationGui.ViewModel  6y  -   5          �Name$  Window��5       � Title$ DjMachinLearning��5       � WindowStartupLocation$ CenterScreen=�6,    � WindowState$ 	Maximized=�6Q    J� 	AllowDrop .  � 
ResizeMode$ NoResize=�6z   $��Stretch=�6�   $��Stretch=�6�   ���	#FF161414��5      �� *&$SystemParameters.PrimaryScreenHeight+��5      �� *%#SystemParameters.PrimaryScreenWidth+��5     Z�  � 	Resources 5         ThumbStyle1 �� 
TargetType �� Property	 �� Value
 �� 
TargetType  NormalBrush �� RadiusY �� RadiusX �� EndPoint � MappingMode �� 
StartPoint � Color � Offset �� Triggers P� Property P� Value  SliderStyle1  
LightBrush  NormalBorderBrush �Name � RowDefinitions m�Name J� SnapsToDevicePixels m� 	Placement  
GlyphBrush m� Fill ��Name �� CornerRadius ]�Name ]� Thumb ]� IncreaseRepeatButton ! SimpleScrollRepeatButtonStyle  ]� DecreaseRepeatButton! �� 
TargetName  DisabledBackgroundBrush  DisabledBorderBrush" �� Angle��%�
  &	        &	     �� 5      " n�65   .�5	      ��  �@J�SnapsToDevicePixels	 . 6+   �� 5
       � ��$	 14��6   �� 5       � ��$	 14��6   �� 5       � ��	 5      �� 5      "
 n�6   .R�5      � $��-5.25,-6.264,0,-5.854q�6   .+�5   	   �� #���  6   $��Stretch=�68   $��5.833,0,1.167,0q�6V   $ 1.833��6o   $ 1.833��6   $��1��6�   $
��Auto��6�   ��5   
   �� 5      $ -1,0.5&�6   $ RelativeToBoundingBox=�61   $ 2,0.5&�6U   .��5      � $ Black��6   $ 0Q�6'   � 5      $ 	#FFC27D7D��6   $ 1Q�6+   � 5      $ 	#FF331F1F��6   $	 0.5Q�6+   5      5   
   5   	    5      P� 5   	    �@J�IsMouseOver . 6(   P� 5   	    � {� .  6&   5      5       5!      �� 5"      " ��6   .�5#      ��  � ��#	 �  6"   �� 5$       � ��#	 �  6#   �� 5%       � ��	 5&      �� 5'      "
 ��6   .R�5(      � $ GridRoot��6   ���	#FF9D2F2F 5)   	   �� 5*   
   $
��Auto �6   �� 5+   
   $
��Auto �6   #��z��6&   �� 5,   
   $
��Auto �6   .+�50   	   m� $ TopTick��6(   $y�	Collapsed=�6   $��4��69    . $	 Top=�6_   # �  6o   �� 51   	   $ Border��6(   $��1��6   $��0q�6   $��4��68   #��z��6C   #��z��6o   $ 2��6�   ���	#FFA5A5A56�   ]� 54   	   $ 
PART_Track��6   $��1��6    55   
   n� 56      #���   6    58   
   �� 59      #���  6   $��Slider.IncreaseLarge��6P     5;   
   �� 5<      #���  6   $��Slider.DecreaseLarge��6P   5>   
   m� 5@   	   $ 
BottomTick��65   $y�	Collapsed=�6   $��2��6(   $��4��6I    . $ Bottom=�6o   # z��6�   5A   	    5B      P� 5C   	    �@��TickPlacement$ TopLeft=�6*   . �5D   
   �� $! TopTick��67    � y�$	 Visible=�6'   67   5E   
   P� 5F   	    �@��TickPlacement$ BottomRight=�6*   . �5G   
   �� $! 
BottomTick��67    � y�$	 Visible=�6'   67   5H   
   P� 5I   	    �@��TickPlacement$
 Both=�6*   . �5J   
   �� $! TopTick��67    � y�$	 Visible=�6'   67   �� 5K   
   $! 
BottomTick��67    � y�$	 Visible=�6'   67   �� 5L   
   $! TopTick��6#    � ��$	 8��68   �� 5M   
   $! 
BottomTick��6#    � ��$	 8��6;   5N   
   P� 5O   	    � {� .  . �5P   
   �� #	 �  6'   $! Border��6Y    � ���� 5Q   
   #	 �  6(   $! Border��6V    � ��5R   
   P� 5U   	    �@��Orientation$ Vertical=�6(   . �5V   
   �� $! GridRoot��6,    �@�LayoutTransform	 5W      �� 5X      $	" -90Q�6   5Z      �� 5\   
   $! 
PART_Track��6    � ��$	 
Horizontal=�6@   5]   
   5`      5b      5c      5d      .��5f      (� $��0q�6   # (� Stretch$
# Fill=�6   .��5h      �� -   5        $ ��Name$$ Board��5h      .+�5i      �� -   5        % ��Name$% 	MainGraph��5i      $��105.386��6"   $��5q�63   $ 20��6>   $ 20��6K   ���	#FF4E4E4E6X   �� 5j      & �� Orientation$& 
Horizontal=�6   $��0q�6)   ��5k      �� 5l      $ 0.5,1&�6   $ 0.5,0&�6,   .��5m      � $ Black��6   $ 0Q�6#   � 5n      $ 	#FF452F2F��6   $ 1Q�6'   5o      .+�5q      &    MusicClassificationGui.DockPanel  -   5        '  Name$' LeftDock��5q      $	��600��6(   $��Hidden=�64   $��0q�6h   6   0MusicClassificationGui.Volume_and_BalanceControl  5r      -   5        (  Name$( VolumeControl��5r   &   $��0q�6=   $
��Auto��6H   $��0q�6V   $	��210��6�   ��6j   Z� 6�     5s      -   5        $' 	RightDock��5s      $	��600��6)   $��0q�65   5t      0   *MusicClassificationGui.FilesManagerControl  5u      -   5        )  Name$) FileManagerControl��5u      $��276.493��6;   $��1422.531��6L   5v      5w      5x      