   M S B A M L   `   `   `  ����   MusicClassificationGui(    "MusicClassificationGui.DickControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     >�Name$  	DiscPanel��$	��220��$	��200��$��0q� � 	Resources    ThumbStyle1 �� 
TargetType �� Property �� Value �� 
TargetType  NormalBrush �� RadiusY �� RadiusX �� EndPoint	 � MappingMode
 �� 
StartPoint � Color � Offset �� Triggers P� Property P� Value  SliderStyle1  
LightBrush  NormalBorderBrush �Name � RowDefinitions m�Name J� SnapsToDevicePixels m� 	Placement  
GlyphBrush m� Fill ��Name �� CornerRadius ]�Name ]� Thumb ]� IncreaseRepeatButton ! SimpleScrollRepeatButtonStyle ]� DecreaseRepeatButton �� 
TargetName  DisabledBackgroundBrush  DisabledBorderBrush �� Angle 	 PlaySong g� RepeatBehavior g� AutoReverse  �� TargetProperty! �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame" O� KeyTime# O� Value��%~  &	        &	 �    &		 Y    �� " n�.���  �@J�SnapsToDevicePixels . ��  � ��$ 14����  � ��$ 14����  � �� �� " n�.R�� $��-5.25,-6.264,0,-5.854q�.+��� #���  $��Stretch=�$��5.833,0,1.167,0q�$ 1.833��$ 1.833��$��1��$
��Auto������ $ -1,0.5&�$	 RelativeToBoundingBox=�$
 2,0.5&�.��� $ Black��$ 0Q�� $ 	#FFC27D7D��$ 1Q�� $ 	#FF331F1F��$	 0.5Q� P�  �@J�IsMouseOver . P�  � {� .  �� " ��.���  � ��# �  ��  � ��# �  ��  � �� �� " ��.R�� $ GridRoot�����	#FF161313 �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $ TopTick��$y�	Collapsed=�$��4�� . $	 Top=�# �  �� $ Border��$��1��$��0q�$��4��#��z��#��z��$ 2�����	#FFA5A5A5]� $ 
PART_Track��$��1�� n� #���    �� #���  $��Slider.IncreaseLarge�� �� #���  $��Slider.DecreaseLarge��m� $ 
BottomTick��$y�	Collapsed=�$��2��$��4�� . $ Bottom=�# z�� P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=��� $ TopTick�� � ��$ 8���� $ 
BottomTick�� � ��$ 8��P�  � {� .  . ��� # �  $ Border�� � ���� # �  $ Border�� � ��P�  �@��Orientation$ Vertical=�. ��� $ GridRoot�� �@�LayoutTransform �� $	 -90Q��� $ 
PART_Track�� � ��$ 
Horizontal=��� $ Forever�� .  .��U� $V  P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$
! Disc��.\�  $" 0��$# 0Q�  $" 0:0:1��$# 90Q�  $" 0:0:2��$	# 180Q�  $" 0:0:3��$	# 270Q�  $" 0:0:4��$	# 360Q�$ � Triggers$ :� % :� RoutedEvent$% ButtonBase.Click��& :� 
SourceName$& play_button��.[��� ' �� BeginStoryboardName$' PlaySong_BeginStoryboard���� $' PlaySong_BeginStoryboard���� -   ( ��Name$( PlaySong_BeginStoryboard��#��[	 :� $% ButtonBase.Click��$& PauseButton��.[�?� $' PlaySong_BeginStoryboard��?� $' PlaySong_BeginStoryboard��.���� $��0q�
���   �$ 20�� 
 DefaultedBorderBrush#��� 
 ._�]� -   ) ]�Name$) 	dockPanel��$	��200��.+�� -   $ Buttons��$��Bottom=�$��0q�$	��Top=�$��50��.+�� -   * �Name$* InnerButtons��$��0q�.+��� -   + ��Name$+ PauseButton��  
PauseStyle#���  $��40��$��40��$��20,7,0,0q���Z� .��F� "�����,�7�	� : �I���P`��	���	#FF04040E, �� Stretch$
, Fill=�
���   �- J� RenderTransformOrigin$- 0.5,0.5&�$��32.538��$��40.248��$��Right=�z�V� .~��� . �� ScaleY$	. 0.5Q�/ �� ScaleX$	/ 0.5Q��� �� $ -0.467Q�T� 0 T� X$
0 0.01Q�1 T� Y$1 -0.0215Q��� -   $+ play_button��$��0,7,0,0q�  PlayButtonTemplate#���  $��40��$��40����Z� .��F� "�����,�7�	� : �I���P`��	���	#FF04040E$
, Fill=�
���   �$- 0.5,0.5&�$��32.538��$��40.248��$��Right=�z�V� .~��� $	. 0.5Q�$	/ 0.5Q��� �� $ -0.467Q�T� $
0 0.01Q�$1 -0.0215Q��� -   $+ 
CUT_button��$��0,7,0,0q�  ButtonControlTemplate1#���  $��40��$��40����Z� .��F� "�����,�7�	� : �I���P`��	���	#FF04040E$
, Fill=�
���   �$- 0.5,0.5&�$��32.538��$��40.248��$��Right=�z�V� .~��� $	. 0.5Q�$	/ 0.5Q��� �� $ -0.467Q�T� $
0 0.01Q�$1 -0.0215Q��� $��0,9,5,0q�#���  2 �� Orientation$2 Vertical=�$��Right=�3 �� TickPlacement$
3 Both=�4 � Maximum$4 20Q�$- 0.5,0.5&�$��0q�5 � Value$5 10Q�z�V� .~��� �� �� $	 180Q�T� (� $��0q�6 (� Stretch$
6 Fill=�$	��Top=�$	��150��.���� -	   7 ��Name$
7 Disc��$- 0.5,0.5&�8 � Cursor$
8 Hand��$	��250��$	��250��z�V� .~��� �� �� T� .+�A� $	��250��$	��250��$��5����
� .��� $ Black��$ 1Q�� $ 	#FF545151��$ 0.918Q���
� .��� $ 	#FF41353B��$ 0.879Q�� $ White��$ 1Q�� $ 	#FF41353B��$ 0.491Q��� $��12.01��9 �� Left$9 73.384�����	#FF212121
: �� Top$: 57.42��$��103.744��$- 0.5,0.5&�$ 13.032��$ 13.032�����	#FF8B7474$��3��z�V� .~��� �� �� $ -89.496Q�T� A� ���	#FF727272$	��100��$	��100��$9 75��$: 75��$��3����
� .��� $ Black��$ 0Q�� $ White��$ 1Q�