   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Library.MVVM.ViewLibrary.MVVM.View  5      "    Library.MVVM.View.ReaderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Library.MVVM.View     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ /Theme/ControlButton.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��40 �6   .+�5   
   �� $��
Czytelnicy��6   $��30(�6%   $��10,0,0,0q�5      $
��Bold"�6"   
�������5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��readers��5      $��1��6"   $��	10,0,20,0q�5      $��15(�6&      AutoGenerateColumns .     CanUserAddRows .     GridLinesVisibility$ Vertical=�5      $��Center=�5          RowBackground
 ���� ��5      ��  �� Path$ readerBase.readers�	 �� SelectedIndex	 5      �� $ SelectedReader���5"      �� 5#      .��5$      � 
 � Color$
 #E4E4E4��6#    � Offset$	 0.0Q�63   � 5%      $
 #DEDEDE��6#   $ 1Q�63   5&         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      MinWidth$	 150Q�61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*      �� $	 _id�  5+      $ Imię Nazwisko��6%   $	 250Q�6<    5,      �� $ _name�5/      �� 50   
   -   5        $��DeleteReader��50      $��Usuń��6%   $��75��64   $��30��51      $��15(�6   $��2��52      $��Right=�6   $��0,0,20,0q�53         ControlButton#��[  54      56      57      