   M S B A M L   `   `   `  ����Q  MMusicClassificationGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MusicClassificationGui.ViewModel MusicClassificationGui.ViewModel  5     ,    &MusicClassificationGui.SongDataControl   6   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6P   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   D	ViewModel.clr-namespace:MusicClassificationGui.ViewModel     6  -   5          >�Name$  SongDataControl1��5         DefaultedBorderBrush#���   60   $	��100��6d   .��5      �� -   5         ��Name$ 
LayoutRoot��5      ._�5   
   �� .+�5      � $��59��6   $��0,0,0,1q�6   .+�5      �� $��	Song Name��6   $
��Left=�6,   $��7,2,0,0q�6G   $��84��6X   $��25.96��6c   $	��Top=�6r   $
��Bold"�6�   �� 5	      $��Song Artist
��6   $
��Left=�63   $��7,0,0,19.04q�6N   $��84��6c   $��25.96��6n   $��Bottom=�6}   $
��Bold"�6�   �� 5
      -   5         ��Name$ lblSongName��5
      $
��Left=�6a   $��25.96��6|   $��85,2,0,0q�6�   $	��Top=�6�   $	��104��6�   ��6-   ��  �� Path$ Property.Title� �� Mode$ OneWay=�6�   �� 5      -   5        $ lblSongArtist��5      $
��Left=�6d   $��85,14,0,19.04q�6   $	��104��6�   ��6/   �� $ Property.Artist�$ OneWay=�6�   �� 5      $��Time Passed
��6   $
��Left=�63   $��	198,2,0,0q�6N   $��92��6a   $��25.96��6l   $	��Top=�6{   $
��Bold"�6�   �� 5      $��
Time Left
��6   $
��Left=�61   $��198,13.5,0,0q�6L   $��92��6b   $��25.96��6m   $	��Top=�6|   $
��Bold"�6�   �� 5      -   5        $ lblTimePass��5      $��25.96��6t   $��280.5,2,210.666,0q�6�   $	��Top=�6�   ��6-   �� $ CurrentTime�$ OneWay=� �� StringFormat$ hh:mm:ss��6�   �� 5      -   5        $ lblTimeLeft��5      $��281,13.5,210.666,19.54q�6q   ��6-   �� $ Duration�$ OneWay=�$ hh:mm:ss��6q   �� 5      $��Pitch Value

��6   $��0,0.985,124.333,0q�68   $��25.96��6S   $	��Top=�6b   $��Right=�6z   $��87��6�   $
��Bold"�6�   �� 5      -   5        $ lblBPM��5      $��0,15.34,26.009,17.7q�6c   $��Right=�6�   $	��106��6�   ��6(   �� $ Property.AudioBitrate�$ OneWay=�6�   �� 5      -   5        $ lblPitch��5      $��Lable Pitch Value��6*   $��0,2.319,20.673,0q�6F   $��Right=�6`   $	��113��6|   $��25.96��6�   $	��Top=�6�   5      �� 5      -	   5         ��Name$ SongWave��5      $��40��6'   $��0,1,0,0q�63   5      5      5      