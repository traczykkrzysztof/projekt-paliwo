   M S B A M L   `   `   `  ����M  IWpfAplikacja_TESTY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAplikacja_TESTYWpfAplikacja_TESTY  5      !    WpfAplikacja_TESTY.FirstRun   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfAplikacja_TESTY     5      .��5	      � .+�5   
   �� $
��Left=�6   $	��481��6,   $��	-79,0,0,0q�69   $	��Top=�6L   $	��555��6d   y�6p   �� *IsCanvasVisible+   	BoolToVis  �� 	Converter#  [  .+�5      �� -   5         ��Name$ welcome_label��5      $��Witaj!��6+   $
��Left=�6<   $	��Top=�6W   $��35(�6o    �� Left$ 97��6}   
 �� Top$ 56��6�   �� 5      -   5        $ 
info_label��5      $k��e Wygląda na to, że Twoja baza pojazdów i tankowań jest pusta.
 Kliknij poniżej, aby rozpocząć��6(   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $ 97��6�   $	 118��6�   �� 5      -   5         ��Name$ button��5      $��Dodaj pierwszy samochód��6%   $
��Left=�6g   $��222,289,0,0q�6�   $	��Top=�6�   $	��178��6�   $��48��6�   ��6G   �� *AddFirstCar+6�   5      �� 5   
   $
��Left=�6   $	��481��6,   $��0,10,0,0q�69   $	��Top=�6K   $	��594��6c   y�6o   �� *IsCarsViewEnabled+#  [  .+�5      !   WpfAplikacja_TESTY.CarsView  $
��Left=�6   $	��Top=�68   $	��481��6P   $	��570��6]   5      5      5      