   M S B A M L   `   `   `  ����F  BWPF_QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_QuizAppWPF_QuizApp  5   	       WPF_QuizApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_QuizApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $
��387* �6    � ColumnDefinitions 5   
   �� 5      $	��21* �6   �� 5      $
��189* �6   .+�5   
   �� $��History Quiz��6   $
��Wrap=�6(   $��16(�5      $
��Left=�5      $��Center=�5      $
��Bold"�5      
����+��$��1��5      $��0,2,0,0q�6$   $��35��65   �� 5   
   $��1��6   $��0,17,0,0q�6%    �� Orientation$ Vertical=�67   $��1��6N   $	��310��5      $	��Top=�6!   $
��Left=�69   .+�5      �� $
��Wrap=�6/   $��50��5      $	��310��5       $
��Left=�5!      $	��Top=�5"      $��1��5#      $��14(�5$      $��1��5%      ��5      �� *qText+5%      �� 5&      -   5        $	��100��5&      $	��310��6#   $
��Left=�5'      $	��Top=�5(      $��0,15,0,0q�5)      ��5*      �� *	answers+��5,      �� 5-      .R�5.      �� $ 
Horizontal=�6%   $	��0,5q�6>   .+�5/      �� $��10��6(   $��10��50   (   
��� E��$��0,0,8,0q�52   (   �� 53      $��13(�6?   $
��Bold"�54   (   ��53   (   �� *aText+54   (   55      56      58      �� 59      -   5        $��Btn_newQuestion��5:      $��1��5;      $��
219,0,0,20q�6!   $��1��5<      $��Bottom=�5=      $
��Left=�5>      $��Next Question��5?      $��20��5@      $��90��5A      6    5B      5F      5G      