   M S B A M L   `   `   `  ����W  SHtmlParser(AppVestoTestTask), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HtmlParser_AppVestoTestTask_HtmlParser_AppVestoTestTask_  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   -    'HtmlParser_AppVestoTestTask_.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HtmlParser_AppVestoTestTask_     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$#  Html Page Parser for AppVesto��5	   	   $	��450��6/   $	��800��6<      VM � DataContext# [  6H    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�  '��       '�� H     '� �     '�� +    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 22(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 1q�60   �� 5       � ��$ Stretch=�6;   5      �� 5   
   " �6   .�5      ��  � ��$ 1,0,1,0q�60   �� 5       � ��
 ���� 6+   5      �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 0q�60   �� 5       � ��# Z�6,   �� 5       � ��$ 18(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 18(�6)   �� 5       � ��
 ���� 6+   �� 5       � ��$ 0q�60   5       5!      .��5"      �  � RowDefinitions 5#   
   �� 5$      $��30 �6   �� 5%      .+�5'   
   �� $��4��6   $��1��6&   ��63   �� *Videos+��5(      �� 5)      .R�5*      .   (HtmlParser_AppVestoTestTask_.ListBoxItem  5+      5-      � 5.   
   #��Z�6    � ColumnDefinitions 5/      �� 50      $
��153* �6#   �� 51      $
��202* �6#   �� 52      $
��277* �6#   �� 53      $
��160* �6#   .+�55      �� $��1,0,0,0q�6   $��1��61    �� SelectedIndex$ 0��6A   	 �� SelectedItem	 6S   �� *SortingType+
 �� Mode$
 OneWayToSource=�.@�56      ��Name ascending��6-   ��57      Name descending��6.   ��58      Duration ascending��61   ��59      Duration descending��62   5:      �� 5;      $
��Wrap=�6   $��
 Order by:��6,   �� 5<      $��Parse��6   $��3��6%   ��65   �� *Parse+{�6O   �� *IsButtonAvaible+� 5=      $��2��6    � Value 6*   �� *
Progress+5>      5?      5@      