   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Library.MVVM.ViewLibrary.MVVM.View  5      !    Library.MVVM.View.RentsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Library.MVVM.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��60 �6   �� 5      �� 5      $��40 �6   .+�5   
   �� $��Wypożyczone��6   $��30(�6&   $��10,0,0,0q�5      $
��Bold"�6&   
�������5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��	10,0,20,0q�6    $��15(�5         CanUserAddRows .     AutoGenerateColumns .     GridLinesVisibility$ Vertical=�5         RowBackground
 ���� ��5      ��  �� Path$ rentBase.rents���5      �� 5      .��5      �  � Color$ #E4E4E4��6#    � Offset$	 0.0Q�63   � 5      $ #DEDEDE��6#   $ 1Q�63   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 Zasób��6%   
   MinWidth$
 75Q�5"   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5!   %   �� $ 	RentTitle�5"   %     5#      $	 Tytuł��6%   $	
 150Q�5%   %    5$   %   �� $ _rented._title�5%   %     5&      $	 	Czytelnik��6%   $
 75Q�5(   %    5'   %   �� $ RentName�5(   %     5)      $	 Nazwisko��6%   $	
 100Q�5+   %    5*   %   �� $ _rentedBy._name�5+   %     5,      $	 Data wypożyczenia��6%   $	
 120Q�6@    5-   %   �� $
 Date�  5.      $	 Data zwrotu��6%   $	
 120Q�6:    5/   %   �� $ ExpDate�51      52      53      