   M S B A M L   `   `   `  ����Q  MMusicClassificationGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MusicClassificationGui.ViewModel MusicClassificationGui.ViewModel  5      -    'MusicClassificationGui.SongsFileBrowser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      [ MusicClassificationGui_ViewModel.clr-namespace:MusicClassificationGui.ViewModel     5      -   5          >�Name$  UserControl��5	       � 	Resources 5         DataTemplate1  TreeViewItemFocusVisual �� Property �� Value  	TreeArrow  ExpandCollapseToggleStyle �� 
TargetType �� 
TargetType �� Padding F�Name �� Angle	 �� CenterY
 �� CenterX �� Triggers P� Property P� Value �� 
TargetName  TreeViewItemStyle1 �� RelativeSource �� AncestorType � ColumnDefinitions � RowDefinitions d�Name �� 	ClickMode d� 	IsChecked ��Name J� SnapsToDevicePixels ��Name ��Name ]� 
Conditions �� Property �� Value��%�  &	        &	 (     &	 �     &	 �     7  &	 }    7  7  �� 5      .R�5      � 5      �� 5      .�5      ��  � �� 5      �� 5      .R�5      �� 5      5      5      B� 5      $��M0,0 L0,6 L6,0 zC�6#   �� 5      " d�6,   .�5      ��  � |� .  6!   �� 5       � ��$ 16��6   �� 5       � ��$ 16��6   �� 5       � �� 5      �� 5      " d�6   .R�5       �� 
������ $��16��6(   $ 5,5,5,5q�64   $��16��6F   ._�5!   	   F� $ 
ExpandPath��6   8��  
������ ���	#FF989898z�5"   
   �� 5#      $	 135Q�6   $	 3Q�6'   $
 3Q�63   5%   
   5&   	    5'      P� 5(   	    �@J�IsMouseOver . . �5)   
   �� $ 
ExpandPath��6#    � �� �	#FF1BBBFA6;   �� 5*   
   $ 
ExpandPath��6!    � ��
 ���� 69   5+   
   P� 5,   	    �@d�	IsChecked$
 TrueY�6&   . �5-   
   �� $ 
ExpandPath��6,    � z� 5.      �� 5/      $	 180Q�6   $	 3Q�6(   $
 3Q�64   51      �� 52   
   $ 
ExpandPath��6!    � �� �	#FF59595969   �� 53   
   $ 
ExpandPath��6#    � �� �	#FF2626266;   54   
   56      58      59      �� 5:      " Q�6%   .�5;      ��  � ��
 ���� 6"   �� 5<       � �� 62   �� *HorizontalContentAlignment+ �� " ���� 5=       � �� 60   �� *VerticalContentAlignment+ �� " ���� 5>       � ��$ 1,0,0,0q�6   �� 5?       � ��# � ��6"   �� 5@       �@�FocusVisualStyle8   6(   �� 5A       � �� 5B      �� 5C      " Q�6   .R�5D      �  5E   	   �� 5F   
   $��19��6   $
��Auto �6)   �� 5G   
   $
��Auto �6   �� 5H   
   $��* �6    5J   	   �� 5K   
   $
��Auto �6   �� 5L   
   .+�5N   	   d� $ Expander��6   $ Press=�6(   8�� 
���   �$��0q�6�   ���	#FF040202$��20��6�   $��20��6	   6:   �� *
IsExpanded+ �� *TemplatedParent+6	  �� 5O   	   $ Bd��6   #��z��6   #��z��6H   #��z��6|   $��1��6�   # z��6�    . ._�5P   
   �� $ PART_Header��6   $��Header��60   #��z��6G   # z 6�   5Q   
   �� 5R   	   $ 	ItemsHost��6   $��2��6+   $��1��6?   $��1��6O   5S   	    5T      P� 5U   	    �@Q�
IsExpanded .  . �5V   
   �� $ 	ItemsHost��6'    � y�$ 	Collapsed=�6>   �� 5W   
   $ 	ItemsHost��6(    �@J�OpacityMask
 �   �6?   5X   
   P� 5Y   	    �@��HasItems .  . �5Z   
   �� $ Expander��6'    � y�$ Hidden=�6=   5[   
   P� 5\   	    �@Q�
IsSelected . . �5]   
   �� $ Bd��6'   # � ��67    � ���� 5^   
   # � ��6'    � ��5_   
   ]� 5`   	    5a   
   �� 5b       �@Q�
IsSelected . 6+   �� 5c       �@Q�IsSelectionActive .  62   ./�5e   
   �� $ Bd��6'   # � ��67    � ���� 5f   
   # � ��6'    � ��5g   
   P� 5h   	    � {� .  . �5i   
   �� # � ��6'    � ��5j   
   5l      5n      5o      5q      .��5s      A�  A� Columns$ 2��6*   .+�5t      R� -   5         R�Name$ 	tvBrowser��5t      $��0,-1,0,1q�6      SimpleTreeView#���  62   �� 5u   
   $��Visible=�6   .��5v      &   System.Windows.Controls.DataGrid  -   5          Name$ dgSongsGrid��5v   ;   $��0q�60       AreRowDetailsFrozen  . ! J� 	AllowDrop! .  $	��2,0q�6~   ��.  ��6   �� ��6�   Z� ��5w      �� 5x      )  #System.Windows.Controls.DataGridRow"  6   .�5y      -   5        5z      " � ContextMenu" 5|      �� 5}      $��Stretch=�6"   $��7,2,2,2q�6G   .@�5~      m� $��Column��6#   # � Cursor$
# None��63   .@�5      m� $
��Name��6'   $ m� IsCheckable$ . 65   m� 5�      $��Title��6'   $ . 66   m� 5�      $��Artist��6'   $ . 67   m� 5�      $��Album��6'   $ . 66   m� 5�      $��Genre��6'   $ . 66   m� 5�      $
��Year��6'   $ . 65   m� 5�      $��BeatsPerMinute��6'   $ . 6?   m� 5�      $��Comment��6'   $ . 68   m� 5�      $��AudioBitrate��6'   $ . 6=   m� 5�      $��AudioSampleRate��6'   $ . 6@   5�      5�      5�      5�      5�      5�      