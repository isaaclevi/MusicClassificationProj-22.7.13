   M S B A M L   `   `   `  ����Q  MMusicClassificationGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MusicClassificationGuiMusicClassificationGui  5      P LMusicClassificationBL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:MusicClassificationBL;assembly=MusicClassificationBLMusicClassificationBL 5      S.clr-namespace:MusicClassificationGui.ViewModel MusicClassificationGui.ViewModel  5      a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5	      0    *MusicClassificationGui.FilesManagerControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      6local$clr-namespace:MusicClassificationGui     5      QBLBclr-namespace:MusicClassificationBL;assembly=MusicClassificationBL     5      ?data.clr-namespace:MusicClassificationGui.ViewModel     5      oMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5	      -   5          >�Name$  FileManagerControl��5      $��3q�5   2   ���	#FF919191���	#FF919090 � 	Resources 5      (  "MusicClassificationBL.SongPropList   PlayList  TreeViewItemFocusVisual �� Property �� Value  	TreeArrow  ExpandCollapseToggleStyle �� 
TargetType �� 
TargetType �� Padding F�Name �� Angle	 �� CenterY
 �� CenterX �� Triggers P� Property P� Value �� 
TargetName  TreeViewItemStyle1 �� RelativeSource �� AncestorType � ColumnDefinitions � RowDefinitions d�Name �� 	ClickMode d� 	IsChecked ��Name J� SnapsToDevicePixels ��Name ��Name ]� 
Conditions �� Property �� Value  DataTemplate1  ButtonFocusVisual �� StrokeDashArray  ButtonNormalBackground �� EndPoint �� 
StartPoint  � Color! � Offset  ButtonNormalBorder" �� Color 	 ButtonStyle1��%  &	        &	      &	 �     &	 �     7  &	 h    7  7  &	 >    &	 f    &	     &	     &		 '    7  7  7    5   
   6   �� 5      .�5      ��  � �� 5      �� 5      .R�5      �� 5      5      5      B� 5      $��M0,0 L0,6 L6,0 zC�6#   �� 5      " d�6,   .�5      ��  � |� .  6!   �� 5       � ��$ 16��6   �� 5       � ��$ 16��6   �� 5       � �� 5       �� 5!      " d�6   .R�5"      �� 
������ $��16��6(   $ 5,5,5,5q�64   $��16��6F   ._�5#   	   F� $ 
ExpandPath��6   8��  
������ ���	#FF989898z�5$   
   �� 5%      $	 135Q�6   $	 3Q�6'   $
 3Q�63   5'   
   5(   	    5)      P� 5*   	    �@J�IsMouseOver . . �5+   
   �� $ 
ExpandPath��6#    � �� �	#FF1BBBFA6;   �� 5,   
   $ 
ExpandPath��6!    � ��
 ���� 69   5-   
   P� 5.   	    �@d�	IsChecked$
 TrueY�6&   . �5/   
   �� $ 
ExpandPath��6,    � z� 50      �� 51      $	 180Q�6   $	 3Q�6(   $
 3Q�64   53      �� 54   
   $ 
ExpandPath��6!    � �� �	#FF59595969   �� 55   
   $ 
ExpandPath��6#    � �� �	#FF2626266;   56   
   58      5:      5;      �� 5<      " Q�6%   .�5=      ��  � ��
 ���� 6"   �� 5>       � �� 62   �� *HorizontalContentAlignment+ �� " ���� 5?       � �� 60   �� *VerticalContentAlignment+ �� " ���� 5@       � ��$ 1,0,0,0q�6   �� 5A       � ��# � ��6"   �� 5B       �@�FocusVisualStyle8   6(   �� 5C       � �� 5D      �� 5E      " Q�6   .R�5F      �  5G   	   �� 5H   
   $��19��6   $
��Auto �6)   �� 5I   
   $
��Auto �6   �� 5J   
   $��* �6    5L   	   �� 5M   
   $
��Auto �6   �� 5N   
   .+�5P   	   d� $ Expander��6   $ Press=�6(   8�� 
���   �$��0q�6�   ���	#FF040202$��20��6�   $��20��6	   6:   �� *
IsExpanded+ �� *TemplatedParent+6	  �� 5Q   	   $ Bd��6   #��z��6   #��z��6H   #��z��6|   $��1��6�   # z��6�    . ._�5R   
   �� $ PART_Header��6   $��Header��60   #��z��6G   # z 6�   5S   
   �� 5T   	   $ 	ItemsHost��6   $��2��6+   $��1��6?   $��1��6O   5U   	    5V      P� 5W   	    �@Q�
IsExpanded .  . �5X   
   �� $ 	ItemsHost��6'    � y�$ 	Collapsed=�6>   5Y   
   P� 5Z   	    �@��HasItems .  . �5[   
   �� $ Expander��6'    � y�$ Hidden=�6=   5\   
   P� 5]   	    �@Q�
IsSelected . . �5^   
   �� $ Bd��6'   # � ��67    � ���� 5_   
   # � ��6'    � ��5`   
   ]� 5a   	    5b   
   �� 5c       �@Q�
IsSelected . 6+   �� 5d       �@Q�IsSelectionActive .  62   ./�5f   
   �� $ Bd��6'   # � ��67    � ���� 5g   
   # � ��6'    � ��5h   
   P� 5i   	    � {� .  . �5j   
   �� # � ��6'    � ��5k   
   5m      5o      5p      �� 5q      .R�5r      � 5s      �� 5t      .�5u      ��  � �� 5v      �� 5w      .R�5x      �� $��2q�6    . #��� ��68   $��1��6   $	 1 2R�6�   5y      5{      5|      �� 5}      $	 0,1&�67   $	 0,0&�6F   .��5~      � $  #F3F3F3��6   $! 0Q�6"   � 5      $  #EBEBEB��6   $	! 0.5Q�6"   � 5�      $  #DDDDDD��6   $	! 0.5Q�6"   � 5�      $  #CDCDCD��6   $! 1Q�6"   5�      �� 5�      $" 	#FF707070��6/   �� 5�      " ��6   .�5�      ��  �@�FocusVisualStyle8   6(   �� 5�       � ��8  6"   �� 5�       � ��8  6#   �� 5�       � ��$ 1q�6'   �� 5�       � ��# � ��6"   �� 5�       � ��$ Center=�62   �� 5�       � ��$ Center=�60   �� 5�       � ��$ 1q�6   �� 5�       � �� 5�      �� 5�      " ��6    5�      P� 5�   	    �@J�IsKeyboardFocused . 6.   P� 5�   	    �@d�	IsChecked$
 trueY�63   P� 5�   	    � {� .  . �5�   
   ��  � �� �#ADADAD6'   5�   
   5�      5�      5�      5�      .��5�      � -   5        # �Name$# 
LayoutRoot��5�      $ � DataContext$ 6   �� % �� Source#% [   5�      �� 5�      $��0.666* �6   �� 5�      $��0.017* �6   �� 5�      $��0.317* �6   .+�5�   
   -   'MusicClassificationGui.SongsFileBrowser  -   5        &  Name$& SongsFileBrower��5�   !   $��0q�6:   &   System.Windows.Controls.DataGrid  5�   
   -   5        '  Name$' 
dgPlayList��5�      $��2��6'   (   SelectionMode$( Single=�67   $��0q�6g   ) J� 	AllowDrop) . *   AutoGenerateColumns* .  +   
IsReadOnly+ .  ��6N   �� ��6�   Z� ,   RowStyle, 5�      �� 5�      )  #System.Windows.Controls.DataGridRow"  6   .�5�      -   5        - �� Triggers- 5�      P� 5�       �@ 
IsSelected . . �5�      ��  � ��
 � ���5�      5�      5�      . � ContextMenu. 5�      �� 5�      $��Stretch=�6   $��7,2,2,2q�6C   .@�5�      m� $��Column��6   / � Cursor$
/ None��6/   .@�5�      m� $
��Name��6#   0 m� IsCheckable0 . 61   m� 5�      $��Title��6#   0 . 62   m� 5�      $��Artist��6#   0 . 63   m� 5�      $��Album��6#   0 . 62   m� 5�      $��Genre��6#   0 . 62   m� 5�      $
��Year��6#   0 . 61   m� 5�      $��BeatsPerMinute��6#   0 . 6;   m� 5�      $��Comment��6#   0 . 64   m� 5�      $��AudioBitrate��6#   0 . 69   m� 5�      $��AudioSampleRate��6#   0 . 6<   5�      5�      1   Columns1 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn2   Header$
2 Name��6J   1  +System.Windows.Controls.DataGridBoundColumn3   Binding3 6%   �� *Name+4 �� Mode$4 OneWay=�6J     5�      $2 Duration��6N   3 6%   �� *
Duration+$4 OneWay=�6N     5�      $2 Title��6K   3 6%   �� *Title+$4 OneWay=�6K     5�      $2 Artist��6L   3 6%   �� *Artist+$4 OneWay=�6L     5�      $2 Album��6K   3 6%   �� *Album+$4 OneWay=�6K     5�      $2 Genre��6K   3 6%   �� *Genre+$4 OneWay=�6K     5�      $
2 Year��6J   3 6%   �� *Year+$4 OneWay=�6J     5�      $2 BeatsPerMinute��6T   3 6%   �� *BeatsPerMinute+$4 OneWay=�6T     5�      $2 Comment��6M   3 6%   �� *	Comment+$4 OneWay=�6M     5�      $2 AudioBitrate��6R   3 6%   �� *AudioBitrate+$4 OneWay=�6R     5�      $2 AudioSampleRate��6U   3 6%   �� *AudioSampleRate+$4 OneWay=�6U   5�      � 5�   
   $��1��6   $��0q�6    5�      �� 5�      $��49 �6   �� 5�      $��0.15* �6   �� 5�      $��0.176* �6   �� 5�      $��0.674* �6   .+�5�      �� -   5        5 ��Name$5 AutoPlaylist��5�      $��Button��6(   6 J� RenderTransformOrigin$6 0.523,1.867&�69   $��1��6]    
 AutoPlaylist#��� 
 6j   6�   �� 5�      -   5        $5 
clustering��5�      $��Button��6&   $��0q�67   $��2��6B     
Clustering#���  6O   $	��Top=�6t   6�   5�      5�      5�      