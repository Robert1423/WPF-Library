   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Library.MVVM.ViewLibrary.MVVM.View  5      !    Library.MVVM.View.TitleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Library.MVVM.View     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ /Theme/ControlButton.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��40 �6   .+�5   
   �� $��Zasoby��6   $��30(�6!   $��10,0,0,0q�5      $
��Bold"�6&   
�������5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��ResourcesData��5      $��1��6(   $��	10,0,20,0q�5      $��15(�5         AutoGenerateColumns .     GridLinesVisibility$ Vertical=�5         CanUserAddRows .     
IsReadOnly .    RowBackground
 ���� ��5      �� 	 �� Path$	 titleBase.titles�
 �� SelectedIndex
 5!      �� $	 SelectedTitle���5#      �� 5$      .��5%      �  � Color$ #E4E4E4��6#    � Offset$	 0.0Q�63   � 5&      $ #DEDEDE��6#   $ 1Q�63   5'         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      MinWidth$ 90Q�5,   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5+   %   �� $		 _id�5,   %     5-      $ Autor��6%   $	 150Q�5/   %    5.   %   �� $	 _author�5/   %     50      $ Tytuł��6%   $	 150Q�52   %    51   %   �� $	 _title�52   %     53      $	 Typ��6%   $	 100Q�55   %    54   %   �� $	 _type�55   %     56      $ Data wydania��6%   $	 100Q�58   %    57   %   �� $	 _publishDateString�58   %     59      $ Ilość��6%   $ 50Q�5;   %    5:   %   �� $	 	_quantity�5;   %   5>      �� 5?   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��0,0,20,0q�5@      .+�5A      �� $��Pokaż��6   $��15(�6%   $��10,0,0,0q�5B      $��50��6*   $��Center=�5C      
�������5D      �� 5E      -   5        $��TypeBox��5E       �� 
IsEditable .   �� 
IsReadOnly . $	��200��5H      $��30��6#   $��	10,0,10,0q�5I      $��15(�6*   $
 4��5J      .@�5K      �� $��	Książki��6   $��15(�61   �� 5L      $��Filmy��6   $��15(�6/   �� 5M      $��
Czasopisma��6   $��15(�64   �� 5N      $��Prace naukowe��6   $��15(�67   �� 5O      $��Wszystko��6   $��15(�62   5P      �� 5Q      -   5        $��Filtr��5Q      $��Filtruj��6"   $��75��64   $��30��5R      $��15(�6!      ControlButton#��[  5T      �� 5U      -   5        $��RemoveTitle��5U      $��Usuń��6(   $��75��67   $��30��5V      $��15(�6!   $��
246,0,20,0q�5W      #��[  5Y      5Z      5\      5]      