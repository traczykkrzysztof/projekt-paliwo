   M S B A M L   `   `   `  ����M  IWpfAplikacja_TESTY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAplikacja_TESTYWpfAplikacja_TESTY  5      &     WpfAplikacja_TESTY.RefuelingView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfAplikacja_TESTY     5      .��5	      � $��
-113,0,0,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  fuelconsumptiontable��5
         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .  $
��Left=�6�   $��
137,24,0,0q�6�   $	��Top=�6�   $	��200��6�   $	��496��6�   ��61   �� *RefuelingList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Dystans��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
distance+  5      $ Ilosc litrow��6%    6;   �� *numberofliters+  5      $ Spalanie��6%    67   �� *consumption+  5      $ Pojazd��6%    65   �� *	carname+  5      $ Data tankowania��6%    6>   �� *refuelingdate+5      �� 5   
   $
��Left=�6   $	��191��6,   $��137,250,0,0q�69   $	��Top=�6N   $	��570��6f   .+�5      �� -   5         ��Name$ distance��5      $��23��6(    �� Left$	 218��64   	 �� TextWrapping$
	 Wrap=�6F   

 �� Top$
 67��6t   $	��120��6�   ��6Z   �� *
Distance+6�   �� 5      -   5        $ liters1��5      $��23��6'   $	 218��63   $
	 Wrap=�6E   $
 95��6y   $	��120��6�   ��6Y   �� *NumberOfLiters+6�   �� 5      -   5         ��Name$ carsbox1��5       �� DisplayMemberPath$
 Name��6q   $	 217��6�   $	
 125��6�   $	��120��6�   ��6*   �� *	Combolist+ �� SelectedItem 6L   �� *SelectedCar+6�   �� 5      -   5         ��Name$ savebutton1��5      $��Zapisz��6K   $ 10��6\   $	
 157��6m   $��75��6~   ��6*   �� *AddRefueling+6~   �� 5      -   5         ��Name$ titlelabel1��5      $��Nowe tankowanie��6)   $ 10��6C   $
 10��6T   $��25(�6d   �� 5      -   5        $ distancelabel1��5      $ ��Wprowadz pokonany dystans:��6,   $ 10��6Q   $
 64��6b   �� 5      -   5        $ literslabel1��5      $*��$Wprowadz ilosc zatankowanych litrow:��6*   $ 10��6Y   $
 90��6j   �� 5      -	   5        $ 	carlabel1��5      $��Wybierz pojazd:��6'   $ 10��6A   $	
 116��6R   �� 5      
�������$��2q�6(   $	��192��6<   $	��571��6I   &   System.Windows.Controls.Calendar  5      $	 375��6   $
 12��6)   $	��169��69   $	��180��6F      SelectedDate 6R   �� *RefuelingDate+�� 5      -
   5        $ reminderlabel1��5      $	 192��6Q   $	
 147��6c   $��79��6t   $	��226��6�   
���  ����6-   �� *ServiceReminder+6�   5"      5%      5&      