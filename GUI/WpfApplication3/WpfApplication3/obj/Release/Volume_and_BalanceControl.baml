   M S B A M L   `   `   `  ����   MusicClassificationGui6    0MusicClassificationGui.Volume_and_BalanceControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     >�Name$  UserControl��$��294.293��$	��143�� � 	Resources    ThumbStyle1 �� 
TargetType �� Property �� Value �� 
TargetType  NormalBrush �� RadiusY �� RadiusX �� EndPoint	 � MappingMode
 �� 
StartPoint � Color � Offset �� Triggers P� Property P� Value  SliderStyle1  
LightBrush  NormalBorderBrush �Name � RowDefinitions m�Name J� SnapsToDevicePixels m� 	Placement  
GlyphBrush m� Fill ��Name �� CornerRadius ]�Name ]� Thumb ]� IncreaseRepeatButton ! SimpleScrollRepeatButtonStyle ]� DecreaseRepeatButton �� 
TargetName  DisabledBackgroundBrush  DisabledBorderBrush �� Angle��%m  &	        &	 �    �� " n�.���  �@J�SnapsToDevicePixels . ��  � ��$ 14����  � ��$ 14����  � �� �� " n�.R�� $��-5.25,-6.264,0,-5.854q�.+��� #���  $��Stretch=�$��5.833,0,1.167,0q�$ 1.833��$ 1.833��$��1��$
��Auto������ $ -1,0.5&�$	 RelativeToBoundingBox=�$
 2,0.5&�.��� $ Black��$ 0Q�� $ 	#FFC27D7D��$ 1Q�� $ 	#FF331F1F��$	 0.5Q� P�  �@J�IsMouseOver . P�  � {� .  �� " ��.���  � ��# �  ��  � ��# �  ��  � �� �� " ��.R�� $ GridRoot�����	#FF9D2F2F �� $
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
Horizontal=�.���� -   $ 
LayoutRoot��$��0q�$ 20��$��5q� 	 DefaultedBorderBrush#��� 	 ._�� -   $ Volume_and_Balance�� J� 	AllowDrop .   � ColumnDefinitions �� $��0.497* ��� $��0.503* � �� $��0.154* ��� $��0.577* ��� $��0.269* �.+��� -     ��Name$  	Vol_text2��$��31��$
��Wrap=�$��13.333(�$��0q�! �� TextAlignment$! Center=�
��������� $�vo���� $
�lume���� �� .��� �� -   $  	Vol_text1��$��31��$
��Wrap=�$��13.333(�$��0q�$��1��$! Center=�
��������� $�vo���� $
�lume���� �� .��� �� -   " ��Name$" LeftValumeSlider��#���  $��31��# �� Orientation$# Vertical=�$ �� TickPlacement$
$ Both=�% � Maximum$% 20Q�& J� RenderTransformOrigin$& 0.5,0.5&�$��10,0,0,0q�$��0q�$��1��' � Value$' 20Q��� -   $" RightVolumeSlider��#���  $# Vertical=�$
$ Both=�$% 20Q�$& 0.5,0.5&�$��10,0,0,0q�$��0,0.358,18.838,1.184q�$��1��$��1��$��Right=�$' 20Q��� -   $" MixerSlider��#���  $
$ Both=�$& 0.5,0.5&�$��10,0,0,0q�$��90��$' 6Q�$# Vertical=�$��0,-0.936,-12.5,-9.9q�$��2��$��31��$��Right=�$% 11Q�z�V� .~��� �� �� $ 89.547Q�T� 