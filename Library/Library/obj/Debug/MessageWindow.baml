   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.MessageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � WindowStyle$
  None=�5   	   $	��150��6   $	��300��6)   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Theme/ControlButton.xaml?�6%   %    5      .��5      ��  �� CornerRadius$ 10��6   $��2q�5      
���   ���5   
   �� 5      .��5      �  � Color$ #01030F��6   	 � Offset$		 0.0Q�6/   � 5      $ #040B45��6   $		 1.1Q�6/   5      ._�5   
   � 
 � RowDefinitions
 5      �� 5      $��40 �6    �� 5      �� 5       $��30 �6    .+�5"      �� -   5        $
��Info��5"      $��Błąd!��6    $��20(�60   $
��Bold"�5#      $��20,0,0,0q�6&   $��Center=�5$      
�������5%      �� 5&      -   5        $��MessageText��5&      $��1��6+   $��	20,0,20,0q�68   $��15(�5'      
�������6&   �� 5(      -   5        $��Accept��5(      $��2��6#   $��75��60   $��20��6;   $��Right=�5)      $��	0,0,20,10q�5*      $��Ok��6(      ControlButton#��[  5,      5-      5.      5/      