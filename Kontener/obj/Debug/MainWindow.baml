   M S B A M L   `   `   `  ����C  ?Kontener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KontenerKontener  5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	       Kontener.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Kontener     5   	   ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	     � Title$&   Rozmieszczanie paczek w konterze��5	   	   $	��750��62   $
��1000��6?    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b    � 	Resources 5
         
ListBorder �� Color ! ListViewStyleBiggerSizeOfText �� 
TargetType �� Property �� Value �� 
TargetType,  &Microsoft.Windows.Themes.ListBoxChrome	  Name
   BorderBrush   BorderThickness   
Background J� IsMouseOver   RenderMouseOver J� IsKeyboardFocusWithin   RenderFocused J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%7  &	        &	 !     7   �� 5   
   $ #828790��6-   �� 5   
   " ��66   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��$ 1q�60   �� 5       � �� �	#FF0422716+   �� 5       � ��$
 Auto=�6K   �� 5       � ��$
 Auto=�6I   �� 5       � �� . 6>   �� 5       �@��PanningMode$
 Both=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � ��$ Center=�69   �� 5       � ��$ 16(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5        $	 Bd��6/   #
 z��6;   # z��6g   # z��6�   # z 6�   # z 6�    . ._�5      �� #��z��6+   #��� $�6O   .��5   "   �� # z 61   5      5       5       P� 5!       � {� .  . �5"   "   �� $ Bd��6?   # � ��6O    �@ 
Background5#      ]� 5$       5%   "   �� 5&   &    �@��
IsGrouping . 6F   �� 5'   &   " �@%�IsVirtualizingWhenGrouping .  6h   ./�5)   "   ��  � �� .  6R   5*      5,      5.      5/      50      .��51      � -   5        ��52   
   �� 53       �� ImageSource$ mainWindowBackground.jpg��6    �� Opacity$	 0.6Q�6@   .+�56   
   �� -   5         ��Name$ listViewParcels��56      $
��Left=�6,   $	��300��6G   $��	10,49,0,0q�6T   $	��Top=�6g   $	��600��6   #���  6�    �� View 57      �� 58      .P�59      �� $��ID��6%    �� Width$	 390��61    �� DisplayMemberBinding 6=   �� *parcelNumberID+�� 5:      $��Szerokość��6%   $	 100��68    6D   �� *parcelSizeX+�� 5;      $��
Długość��6%   $	 100��66    6B   �� *parcelSizeY+5<      5>      �� 5?   
   -   5        $ listViewChoosenParcels��5?      $
��Left=�63   $	��280��6N   $��
10,392,0,0q�6[   $	��Top=�6o   $	��600��6�   #���  6�    5@      �� 5A      .P�5B      �� $��ID��6%   $	 390��61    6=   �� *parcelNumberID+�� 5C      $��Szerokość��6%   $	 100��68    6D   �� *parcelSizeX+�� 5D      $��
Długość��6%   $	 100��66    6B   �� *parcelSizeY+5E      5G      �� 5K   
   -   5         ��Name$ lblListOfAllParcels��5K      $��Lista paczek:��6-   $
��Left=�6E   $��	10,10,0,0q�6`   $	��Top=�6s   $��34��6�   $��18(�6�   $	��109��6�   �� 5L   
   -   5        $ lblListOfChoosenParcels��5L      $��Wybrane paczki:��61   $
��Left=�6K   $��
10,354,0,0q�6f   $	��Top=�6z   $��34��6�   $��18(�6�   $	��143��6�   �� 5M   
   -   5        $ 	lblSizeOf��5M      $��Powierzchnia:��6#   $
��Left=�6;   $��
10,677,0,0q�6V   $	��Top=�6j   $��34��6�   $��18(�6�   $	��117��6�   �� 5N   
   -   5        $ lblSizeOfParcels��5N      $��Paczek:��6*   $
��Left=�6<   $��250,677,0,0q�6W   $	��Top=�6l   $��34��6�   $��18(�6�   $��70��6�   �� 5O   
   -   5        $ lblSizeOfParcelsNumbers��5O      $�� ��61   $
��Left=�6<   $��325,677,0,0q�6W   $	��Top=�6l   $��34��6�   $��18(�6�   $��90��6�   �� 5P   
   -	   5        $ lblSizeOfContainer��5P      $��
Kontenera:��6,   $
��Left=�6A   $��420,677,0,0q�6\   $	��Top=�6q   $��34��6�   $��18(�6�   $��95��6�   �� 5Q   
   -
   5        $ lblSizeOfContainerNumbers��5Q      $�� ��63   $
��Left=�6>   $��520,677,0,0q�6Y   $	��Top=�6n   $��34��6�   $��18(�6�   $��90��6�   �� 5R   
   -   5        $ lblCountOfAllParcelsText��5R      $��Ilość paczek:��62   $
��Left=�6J   $��
184,12,0,0q�6e   $	��Top=�6y   $��34��6�   $��16(�6�   $	��109��6�   �� 5S   
   -   5        $ lblCountOfAllParcels��5S      $
��Left=�6.   $��
298,12,0,0q�6I   $	��Top=�6]   $��34��6u   $��16(�6�   $��40��6�   �� 5T   
   -   5        $" lblCountOfChoosenParcelsText��5T      $��Ilość:��66   $
��Left=�6G   $��157,356,0,0q�6b   $	��Top=�6w   $��34��6�   $��16(�6�   $��44��6�   �� 5U   
   -   5        $ lblCountOfChoosenParcels��5U      $
��Left=�62   $��206,354,0,0q�6M   $	��Top=�6b   $��34��6z   $��18(�6�   $��20��6�   �� 5V   
   -   5        $ lblContainerSizeText��5V      $��Rozmiar kontenera:��6.   $
��Left=�6K   $��
653,10,0,0q�6f   $	��Top=�6z   $��34��6�   $��18(�6�   �� 5W   
   -   5        $ lblContainerSize��5W      $
��Left=�6*   $��
856,10,0,0q�6E   $	��Top=�6Y   $��34��6q   $��18(�6}   $	��130��6�   $��Right=�6�   �� 5[   
   -   5          ��Name$  btnAddParcel��5[      $��Segoe UI Symbol)�6'   $��	 Dodaj��6D   $
��Left=�6]   $��
438,10,0,0q�6x   $��18(�6�   $	��Top=�6�   $��80��6�   $��33��6�   6�   �� 5\   
   -   5        $  btnDeleteParcel��5\      $��Segoe UI Symbol)�6*   $��Usuń��6G   $
��Left=�6^   $��
530,10,0,0q�6y   $��18(�6�   $	��Top=�6�   $��80��6�   $��33��6�   6�   �� 5]   
   -   5        $  btnEditContainer��5]      $��Edytuj��6+   $
��Left=�6<   $��
877,49,0,0q�6W   $��18(�6k   $	��Top=�6y   $	��107��6�   $��33��6�   �� 5^   
   -   5        $  btnChooseParcel��5^      $��Segoe UI Symbol)�6*   $�� Wybierz paczkę��6G   $
��Left=�6i   $��271,354,0,0q�6�   $��18(�6�   $	��Top=�6�   $	��165��6�   $��33��6�   6�   �� 5_   
   -   5        $  btnDeleteChoosenParcel��5_      $��Segoe UI Symbol)�61   $�� Odłóż paczkę��6N   $
��Left=�6n   $��450,354,0,0q�6�   $��18(�6�   $	��Top=�6�   $	��160��6�   $��33��6�   6�   �� 5`   
   -   5        $  btnPlaceInContainer��5`      $��Umieść w konterze��6.   $
��Left=�6J   $��686,677,0,0q�6e   $��18(�6z   $	��Top=�6�   $	��200��6�   $��34��6�   6�   �� 5a   
   -   5        $  btnResetContainer��5a      $��Resetuj��6,   $
��Left=�6>   $��891,677,0,0q�6Y   $��18(�6n   $	��Top=�6|   $��95��6�   $��34��6�   6�   �� 5e   
   
�������$
��Left=�6!   $	��600��6<   $��
715,49,0,0q�6I   
���   �$	��Top=�6l   $	��150��6�   �� 5f   
   -   5        $��cnvContainer��5f      
�������$
��Left=�68   $	��600��6S   $��
715,49,0,0q�6`   $	��Top=�6t   $	��150��6�   5i      5j      