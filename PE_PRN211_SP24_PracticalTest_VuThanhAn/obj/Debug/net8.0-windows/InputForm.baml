   M S B A M L   `   `   `  ����a  ]PE_PRN211_SP24_PracticalTest_VuThanhAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:PE_PRN211_SP24_PracticalTest_VuThanhAn&PE_PRN211_SP24_PracticalTest_VuThanhAn  5   	   6    0PE_PRN211_SP24_PracticalTest_VuThanhAn.InputForm   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:PE_PRN211_SP24_PracticalTest_VuThanhAn     5   	     � Title$  	InputForm��5   	   $	��450��6   $	��800��6(   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��Book ID:��6   $��0��6#   $��0��60   $��Center=�6@   $��5q�6[   �� 5   
   -   5        $��BookIdTextBox��5      $��0��6'   $��1��64   $��5q�6D   $	��200��6O   �� 5   
   $��
Book Name:��6   $��1��6%   $��0��62   $��Center=�6B   $��5q�6]   �� 5    
   -   5        $��BookNameTextBox��5       $��1��6)   $��1��66   $��5q�6F   $	��200��6Q   �� 5#   
   $��Description:��6   $��2��6'   $��0��64   $��Center=�6D   $��5q�6_   �� 5$   
   -   5        $��DescriptionTextBox��5$      $��2��6,   $��1��69   $��5q�6I   $	��200��6T   $��60��6`    �� TextWrapping$
 Wrap=�6l    �� AcceptsReturn$
 True��6�   �� 5'   
   $��Publication Date:��6   $��3��6,   $��0��69   $��Center=�6I   $��5q�6d   (  "System.Windows.Controls.DatePicker  5(   
   -   5        $��PublicationDatePicker��5(      $��3��62   $��1��6?   $��5q�6O   $	��200��6Z   �� 5+   
   $��	Quantity:��6   $��4��6$   $��0��61   $��Center=�6A   $��5q�6\   �� 5,   
   -   5        $��QuantityTextBox��5,      $��4��6)   $��1��66   $��5q�6F   $	��200��6Q   �� 5/   
   $��Price:��6   $��5��6!   $��0��6.   $��Center=�6>   $��5q�6Y   �� 50   
   -   5        $��PriceTextBox��50      $��5��6&   $��1��63   $��5q�6C   $	��200��6N   �� 53   
   $��Author:��6   $��6��6"   $��0��6/   $��Center=�6?   $��5q�6Z   �� 54   
   -   5        $��AuthorTextBox��54      $��6��6'   $��1��64   $��5q�6D   $	��200��6O   �� 57   
   $��Book Category:��6   $��7��6)   $��0��66   $��Center=�6F   $��5q�6a   �� 58   
   -   5        $��BookCategoryComboBox��58       �� DisplayMemberPath$ BookGenreType��6/    �� SelectedValuePath$ BookCategoryId��6Q   $��7��6t   $��1��6�   $��5q�6�   $	��200��6�   �� 5;   
    �� Orientation$ 
Horizontal=�6   $��8��6.   $��2��6;   $��Right=�6O   $��5q�6k   .+�5<      �� -	   5        $	��Add��5<      $��80��6#   $��5q�6.   69   �� 5=      -
   5        $��Cancel��5=      $��80��6&   $��5q�61   6<   5>      5?      5@      