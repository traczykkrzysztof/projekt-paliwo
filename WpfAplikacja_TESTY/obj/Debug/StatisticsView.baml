   M S B A M L   `   `   `  ����M  IWpfAplikacja_TESTY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAplikacja_TESTYWpfAplikacja_TESTY  5      '    !WpfAplikacja_TESTY.StatisticsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfAplikacja_TESTY     5      .��5	      � ��5
   
   �� 5        �� ImageSource$   Images/page_background.png��6   .+�5   
   �� $
��Left=�6   $	��392��6,   $��	10,10,0,0q�69   $	��Top=�6L   $	��568��6d   .+�5      �� -   5         ��Name$ statystyki_title��5      $��
Statystyki��6.   $
��Left=�6C   $	��Top=�6^   $	��158��6v   $��30(�6�   $��53��6�    �� Left$ 55��6�   
 �� Top$ 56��6�   �� 5      -   5        $ highestconsumptionlabel��5      $&�� Najwyższe odnotowane spalanie: ��65   $
��Left=�6_   $	��Top=�6z   $��27��6�   $ 50��6�   $	 145��6�   �� 5      -   5        $ lowestconsumptionlabel��5      $&�� Najniższe odnotowane spalanie: ��64   $
��Left=�6^   $	��Top=�6y   $��28��6�   $ 50��6�   $	 172��6�   �� 5      -   5        $# carwithlowestconsumptionlabel��5      $(��"Najbardziej oszczędny jest pojazd��6;   $
��Left=�6g   $	��Top=�6�   $��28��6�   $ 50��6�   $	 200��6�   �� 5      -   5        $$ carwithhighestconsumptionlabel��5      $%��Najmniej oszczędny jest pojazd��6<   $
��Left=�6e   $	��Top=�6�   $��28��6�   $ 50��6�   $	 226��6�   �� 5      -   5        $ highestconsumption_value��5      $
��Left=�6]   $	��Top=�6x   $��76��6�   $��28��6�   $	 247��6�   $	 139��6�   ��66   �� *HighestConsumption+6�   �� 5      -   5        $ lowestconsumption_value��5      $
��Left=�6[   $	��Top=�6v   $��79��6�   $��23��6�   $	 247��6�   $	 172��6�   ��65   �� *LowestConsumption+6�   �� 5      -   5        $$ carwithlowestconsumption_value��5      $
��Left=�6m   $	��Top=�6�   $	��122��6�   $��28��6�   $	 249��6�   $	 195��6�   ��6<   �� *CarNameWithLowestConsumption+6�   �� 5      -	   5        $% carwithhighestconsumption_value��5      $
��Left=�6o   $	��Top=�6�   $	��122��6�   $��26��6�   $	 249��6�   $	 228��6�   ��6=   �� *CarNameWithHighestConsumption+6�   �� 5      -
   5        $ numberofentrieslabel��5      $ ��Liczba wpisów tankowania:��62   $
��Left=�6V   $	��Top=�6q   $��28��6�   $ 50��6�   $	 254��6�   �� 5      -   5        $ numberofcarslabel��5      $$��Liczba zapisanych samochodów:��6/   $
��Left=�6W   $	��Top=�6r   $��28��6�   $ 50��6�   $	 282��6�   �� 5      -   5        $ numberofentriesvalue��5      $
��Left=�6S   $	��Top=�6n   $��23��6�   $	 249��6�   $	 254��6�   $��76��6�   ��62   �� *EntriesCount+6�   �� 5      -   5        $ numberofcarsvalue��5      $
��Left=�6M   $	��Top=�6h   $��28��6�   $	 249��6�   $	 282��6�   $��76��6�   ��6/   �� *	CarsCount+6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5      $
��Left=�6)   $	��Top=�6D   $	��219��6\   $	��494��6i   $ 50��6�   $	 315��6�      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     DataGridStyle#���   6  ��6u   �� *CarsWithConsumption+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Pojazd��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *	groupname+  5      $&	  Srednie zuzycie paliwa (l/100km)��6)   
 6S   �� *averageconsumption+5!      5"      5$      5%      