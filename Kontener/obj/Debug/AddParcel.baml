   M S B A M L   `   `   `  ����C  ?Kontener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KontenerKontener  5   	       Kontener.AddParcel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Kontener     5   	     � Title$  Dodaj paczkę��5   	   $	��300��6   $	��300��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � ��5   
   �� 5       �� ImageSource$ parcelBackground.jpg��6    �� Opacity$	 0.6Q�6<   .+�5   
   �� -   5         ��Name$ lblAddParcel��5      $��Podaj dane paczki��6&   $	��206��6B   $��25(�6N   $��44,10,43.6,0q�6\   $��Center=�6r   $��44��6�   $	��Top=�6�   �� 5   
   -   5        $ lblParcelNumberID��5      $��Numer ID Paczki:��6+   $
��Left=�6F   $��	16,59,0,0q�6a   $	��Top=�6t   $	��102��6�   �� 5   
   -   5        $ lblParcelSizeX��5      $��Szerokość paczki:��6(   $
��Left=�6D   $��	16,90,0,0q�6_   $	��Top=�6r   �� 5   
   -   5        $ lblParcelSizeXunit��5      $��m��6,   $
��Left=�68   $��
191,90,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $  lblParcelSizeXDefaultValue��5      $��	0.4m ~ 4m��64   $
��Left=�6H   $��
216,90,0,0q�6c   $	��Top=�6w   �� 5   
   -   5        $ lblParcelSizeY��5      $��Długość paczki:��6(   $
��Left=�6B   $��
26,121,0,0q�6]   $	��Top=�6q   �� 5   
   -   5        $ lblParcelSizeYunit��5      $��m��6,   $
��Left=�68   $��191,121,0,0q�6S   $	��Top=�6h   �� 5   
   -   5        $  lblParcelSizeYDefaultValue��5      $��	0.4m ~ 4m��64   $
��Left=�6H   $��216,121,0,0q�6c   $	��Top=�6x   �� 5   
   -	   5         ��Name$ txtParcelNumberID��5      $��0��6-   $
��Left=�66   $��23��6Q   $��
136,63,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $��50��6�   6�   �� 5   
   -
   5        $ txtParcelSizeX��5      $	��1.2��6*   $
��Left=�65   $��23��6P   $��
136,94,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $��50��6�   6�   �� 5   
   -   5        $ txtParcelSizeY��5      $	��0.8��6*   $
��Left=�65   $��23��6P   $��136,125,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $��50��6�   6�   �� 5!   
   -   5         ��Name$ btnAddParcelConfirm��5!      $��Dodaj paczkę��6.   $
��Left=�6E   $��100,167,0,0q�6`   $	��Top=�6u   $	��125��6�   $��50��6�   6�   �� 5"   
   -   5        $ btnAddParcelCancel��5"      $��Anuluj��6-   $
��Left=�6>   $��112.5,222,0,0q�6Y   $	��Top=�6p   $	��100��6�   $��25��6�   6�   5$      5%      