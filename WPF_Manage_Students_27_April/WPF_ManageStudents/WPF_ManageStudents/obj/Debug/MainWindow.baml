   M S B A M L   `   `   `  ����M  IWPF_ManageStudents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_ManageStudentsWPF_ManageStudents  5   	   M+clr-namespace:WPF_ManageStudents.PropertiesWPF_ManageStudents.Properties  5   	   #    WPF_ManageStudents.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_ManageStudents     5   	   <Resx+clr-namespace:WPF_ManageStudents.Properties     5   	   -   5        -   'WPF_ManageStudents.Properties.Resources    appName � Title# Z  5
   	   $	��450��5   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      �  � 	Resources 5   
   *   $WPF_ManageStudents.ConvertBoolToText   bTop��%   &	          5      6&   5       � ColumnDefinitions 5   
   �� 5      $
��233* �6   �� 5      $
��567* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��469* �6   .+�5   
   �� $
��Left=�6   $
��Wrap=�5      $	��Top=�5      $��	15,20,0,0q�5      $��16(�5       
��� d �$
��Bold"�5"      $��0��5#      $��21��5$         manageStudents#��Z 6    �� 5&   
   -   5        $��Lbx_Students��5&      $
��Left=�6&   $	��252��6A   $	��Top=�5'      $	��185��6*   $��	15,52,0,0q�66   $��1��6I   ��5(      �� 5)      .R�5*      �� $	��0,4q�6    �� 5+      �6   �� *	firstName+ �� 5,      $� ��6    �� 5-      $
��Bold"�68   �6   �� *
lastName+68   �� 5.      �� 5/      �6   �� *	matNumber+50      51      53      �� 55   
   $
��Left=�56      $	��239��57      $	��Top=�58      $	��300��59      $��1��5:      $��1��6   $��	19,59,0,0q�5;       � DataContext 5<      �� 	 �� ElementName$	 Lbx_Students��
 �� Path$
 SelectedItem�.+�5=      � $��Stretch=�6   $��0,0,5,15q�61   .+�5>      �� $
��Left=�62   $��14(�6M   $
��Bold"�6[   ��6   �� *name+6[   �� 5?      $��Right=�67   $��14(�6S   ��6   �� *	matNumber+6S   5B      �� 5D       �� Orientation$ 
Horizontal=�6   $	��0,5q�62   .+�5E      ��    	firstName#��Z 6   $
��Wrap=�6G   $��66��6[   �� 5F       �� TextWrapping$
 Wrap=�65   $	��212��6I   ��6   �� *	firstName+6I   5G      �� 5I      $ 
Horizontal=�6   $	��0,5q�62   .+�5J      ��    lastName#��Z 6   $
��Wrap=�6F   $��66��6Z   �� 5K      $
 Wrap=�64   $	��212��6H   ��6   �� *
lastName+6H   5L      �� 5N      $ 
Horizontal=�6   $	��0,5q�62   .+�5O      �� $��Gender��6   $
��Wrap=�6*   $��66��6>   �� 5P      -   5        $��CoBx_gender��5P      $��45��6N    �� SelectedItem 6.   �� *gender+6N   5Q      �� 5S      -   5        $��Cobx_Picked��5S      $��
67,10,0,10q�6k   $
��Left=�5T      $	��212��62    5S   *   �� *picked+ �� 	Converter# [  5T   2   �� 5V      -   5        $��Go to Window��5V      6-   �� 5W      $ 
Horizontal=�6   $�� 0,10q�62   .+�5X      �� -   5        $
��Next��5X      $	��5,0q�6>   �� 5Y      -   5        $
��Prev��5Y      $	��5,0q�6>   5[      �� 5]      -   5        $��
CoBox_Lang��5]      6)   5`      �� 5b   
   $��115,309,0,0q�6   $ 
Horizontal=�6+   $
��Left=�6D   $	��Top=�6_   $��85��6w   $��45��6�   $��1��6�   .+�5c      �� -	   5         ��Name$ Btn_Del��5c      $��-��6<     Btn_Ctl#��[ 6J   $	��5,0q�6w   $��35��6�   $��31��6�   �� 5d      -
   5        $ Btn_Add��5d      $��+��6&   #��[ 64   $	��5,0q�6a   $��35��6n   $��31��6y   6�   5e      �� 5i   
   $��	15,10,0,0q�6   $ Vertical=�5j      $
��Left=�5k      $	��Top=�61   $	��180��5l      $��34��6"   $��1��6.   .+�5m      �� $
��Wrap=�6   $'��!Enter student name to filter list��5n      $
��Left=�5o      $	��Top=�5p      $��9(�5q      
�������$��14��5r   *   �� 5s      $ 
Horizontal=�6   .+�5t      �� -   5         ��Name$ 
Tbx_filter��5t      $��18��5u      $
 Wrap=�5v      $	��144��5w       � ToolTip$0 *Enter part of first or last name to filter��5x      5y      �� 5z      $��10(�6X   $��Black"�6f   $��Center=�6y   $��10,0,0,0q�6�   ��6   �� $	 Lbx_Students��$
 Items.Count�6�   �� 5{      -   5        $��G��5{      6%   5|      5}      5      5�      