   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Library.MVVM.ViewLibrary.MVVM.View  5      %    Library.MVVM.View.RentTitleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Library.MVVM.View     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ /Theme/ControlButton.xaml?�6%   %    5      .��5      �� $	��400��6   $	��250��6   $	��Top=�5      $��	0,100,0,0q�6%   
�������$��2q�5   &    �� CornerRadius$ 10��5      ._�5   
   �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��	Wypożycz��6   
�������$��30(�5      $
��Bold"�6"   $��20,0,0,0q�5      $��0��6&   �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   $��	20,0,20,0q�5      $��Center=�6,   .+�5       �� $��Tytuł��6   $��20(�6(   $	��100��5!      
�������6$   �� 5"      -   5         ��Name$ RentedTitle��5"      $	��250��6/   $��30��5#      $��15(�5$      $��Center=�6(   ��5#   &   ��  �� Path$ 	rentTitle�5$   (   5%      �� 5&      $��2��6   $ 
Horizontal=�6&   $��	20,0,20,0q�5'      $��Center=�6,   .+�5(      �� $��	Czytelnik��6   $��20(�6,   $	��100��5)      
�������6$   �� 5*      -   5        $ 
ReaderRent��5*      $	��250��6.   $��30��5+      $��15(�5,      $��Center=�6(   ��5+   &   �� $ 
rentReader�5,   (   5-      �� 5.      $��3��6   $ 
Horizontal=�6&   $��	20,0,25,0q�5/      $��Center=�6,   $��Right=�50      .+�51      �� -   5         ��Name$ 
AcceptRent��51      $��
Potwierdź��6-   $��30��52      $��75��6%   $��15(�60   $��0,0,10,0q�53         ControlButton#��[  54      �� 55      -   5        $ 
RejectRent��55      $��Anuluj��6-   $��30��56      $��75��6%   $��15(�60   #��[  58      59      5:      5;      5<      