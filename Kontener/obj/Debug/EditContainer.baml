   M S B A M L   `   `   `  ����C  ?Kontener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KontenerKontener  5   	       Kontener.EditContainer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Kontener     5   	     � Title$  Edytuj wymiary kontenera��5   	   $	��300��6*   $	��300��67    � 
ResizeMode$ NoResize=�6C    � WindowStartupLocation$ CenterScreen=�6Y   .��5	      � ��5   
   �� 5       �� ImageSource$ containerBackground.jpg��6    �� Opacity$	 0.4Q�6?   .+�5   
   �� -   5         ��Name$ lblEditContainer��5      $��Zmień dane kontenera��6*   $	��260��6I   $��25(�6U   $��0,10,0,0q�6c   $��Center=�6u   $��44��6�   $	��Top=�6�   �� 5   
   -   5        $ lblContainerSizeX��5      $��Szerokość kontenera:��6+   $
��Left=�6J   $��6,72,0,0q�6e   $	��Top=�6w   �� 5   
   -   5        $ lblContainerSizeXunit��5      $��m��6/   $
��Left=�6;   $��
192,72,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $# lblContainerSizeXDefaultValue��5      $��1m ~ 5m��67   $
��Left=�6I   $��
217,72,0,0q�6d   $	��Top=�6x   �� 5   
   -   5        $ lblContainerSizeY��5      $��Długość kontenera:��6+   $
��Left=�6H   $��
16,111,0,0q�6c   $	��Top=�6w   �� 5   
   -   5        $ lblContainerSizeYunit��5      $��m��6/   $
��Left=�6;   $��192,111,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $# lblContainerSizeYDefaultValue��5      $��5m ~ 20m��67   $
��Left=�6J   $��216,111,0,0q�6e   $	��Top=�6z   �� 5   
   -   5         ��Name$ txtContainerSizeX��5      $
��Left=�6-   $��23��6H   $��
136,76,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $��50��6�   6�   �� 5   
   -	   5        $ txtContainerSizeY��5      $
��Left=�6-   $��23��6H   $��136,115,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $��50��6�   6�   �� 5   
   -
   5         ��Name$ btnEditContainerConfirm��5      $��Potwierdź zmiany��62   $
��Left=�6M   $��100,167,0,0q�6h   $	��Top=�6}   $	��125��6�   $��50��6�   6�   �� 5    
   -   5        $ btnEditContainerCancel��5       $��Anuluj��61   $
��Left=�6B   $��112.5,222,0,0q�6]   $	��Top=�6t   $	��100��6�   $��25��6�   6�   5"      5#      