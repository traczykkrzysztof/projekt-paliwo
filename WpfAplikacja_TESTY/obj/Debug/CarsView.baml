   M S B A M L   `   `   `  ����M  IWpfAplikacja_TESTY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAplikacja_TESTYWpfAplikacja_TESTY  5      !    WpfAplikacja_TESTY.CarsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfAplikacja_TESTY     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$
  Cars��5
      $
��Left=�6!   $
��auto��6<   $��	20,16,0,0q�6J   $	��Top=�6]   $	��494��6u      AutoGenerateColumns .  $��Stretch=�5   	      CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . ��6q   �� *
viewcars+ �� SelectedItem 6�   �� *selectedcar+ J� InputBindings 5      d� 5       d� MouseAction$ LeftDoubleClicke�5       �� Command 5      �� *DoubleClick+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5      $
 Typ silnika��6%   $
 auto 6Y    6:   �� *
EngineType+6Y     5      $
 Data kolejnego przeglądu��6%   $ * 6g    6G   �� *NextService+6g   5      �� 5   
   -   5         ��Name$ addnewcar_label��5      $��Dodaj nowy pojazd��6)   $
��Left=�6E   $��
20,242,0,0q�6`   $	��Top=�6t   $��25(�6�   �� 5   
   -   5        $ carname��5      $��Nadaj nazwe��6!   $
��Left=�67   $��
20,308,0,0q�6R   $	��Top=�6f   $��84��6~   �� 5   
   -   5        $ carnextserivce��5      $&�� Podaj date 
następnego serwisu��6(   $
��Left=�6Z   $��
20,326,0,0q�6u   $	��Top=�6�   $	��140��6�   $��49��6�   �� 5   
   
�������$��2q�6$   $
��Left=�68   $	��187��6S   $��
20,230,0,0q�6`   $	��Top=�6t   $	��494��6�   �� 5   
   -   5         ��Name$ carname_textbox��5      $
��Left=�6+   $��23��6F   $��144,317,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6�   $	��120��6�   ��6{   �� *	CarName+6�   �� 5    
   -   5        $ carnextservice��5       $
��Left=�6*   $��23��6E   $��144,345,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6�   $	��120��6�   ��6z   �� *NextCarService+6�   &   System.Windows.Controls.Calendar  5!   
   -   5          Name$ calendar��5!      $
��Left=�6%   $��305,242,0,0q�6@   $	��Top=�6U      SelectionMode$ 
SingleDate=�6�   $	��164��6�   $	��178��6�      SelectedDate 6m   �� *NextCarService+6�   �� 5"   
   -   5        $ enginetypelabel��5"      $��Wybierz typ silnika��6)   $
��Left=�6G   $��
20,375,0,0q�6b   $	��Top=�6v   �� 5#   
   -	   5         ��Name$ enginetypescomboBox��5#      $
��Left=�60   $��144,375,0,0q�6K   $	��Top=�6`   $	��120��6x   ��6�   �� *enginetypes+ 6�   �� *SelectedEngineType+�� 5$   
   -
   5         ��Name$ addcar��5$      $��Dodaj��6<   $
��Left=�6L   $��236,423,0,0q�6g   $	��Top=�6|   $��75��6�   ��6!   �� *AddCar+{�6�   �� *AreButtonsActivated+�� 5%   
   -   5        $ viewdetails��5%      $
��Usun��6D   $
��Left=�6S   $��132,423,0,0q�6n   $	��Top=�6�   $��75��6�   ��6&   �� *	DeleteCar+{�6�   �� *AreButtonsActivated+�� 5&   
   -   5        $ editcar��5&      $��Edytuj��6>   $
��Left=�6O   $��
29,423,0,0q�6j   $	��Top=�6~   $��75��6�   ��6"   �� *	EditCar+{�6�   �� *AreButtonsActivated+� 5)   
   -   5        $��	EditPopup��5*      $��0,0,0,0q�5+       � HorizontalOffset$
 -100��5,       � VerticalOffset$
 -100��5-       � AllowsTransparency . $��
MousePoint=�5/      ��5)      �� *	popupopen+.��52      � 
�������$	��364��6%   .+�54      �� 
��� � �$��3q�6-   $��0,0,0,0q�6A   $	��174��6R   $	��Top=�6_   �� 55      -   5        $ editname_label��55      $��Nowa nazwa:��60   $
��Left=�6F   $��	10,22,0,0q�6a   $	��Top=�6t   $��91��6�   �� 56      -   5        $ editdate_label��56      $��Następny
serwis:��60   $
��Left=�6T   $��	10,48,0,0q�6o   $	��Top=�6�   $	��115��6�   $��46��6�   �� 57      -   5        $ editenginetype_label��57      $��Typ silnika��66   $
��Left=�6L   $��	10,79,0,0q�6g   $	��Top=�6z   $	��115��6�   $��46��6�   �� 58      -   5        $ editname��58      $
��Left=�6,   $��23��6G   $��
101,25,0,0q�6S   $
 Wrap=�6g   $	��Top=�6�   $	��120��6�   ��6{   �� *	CarName+6�   �� 59      -   5        $ editdate��59      $
��Left=�6,   $��23��6G   $��
101,53,0,0q�6S   $
 Wrap=�6g   $	��Top=�6�   $	��120��6�   ��6{   �� *NextCarService+6�   �� 5;      -   5        $ cancel��5;      $��Anuluj��6I   $
��Left=�6Z   $��
50,130,0,0q�6u   $	��Top=�6�   $��75��6�   ��6)   �� *CancelPopup+6�   �� 5<      -   5        $ confirm��5<      $��Zapisz��6K   $
��Left=�6\   $��165,130,0,0q�6w   $	��Top=�6�   $��75��6�   ��6*   �� *ConfirmPopup+6�   �� 5=      -   5        $ enginetypecomboBox��5=      $
��Left=�67   $��
101,81,0,0q�6R   $	��Top=�6f   $	��120��6~   ��6�   �� *enginetypes+ 6�   �� *SelectedEngineType+5>      5B      5K      5L      