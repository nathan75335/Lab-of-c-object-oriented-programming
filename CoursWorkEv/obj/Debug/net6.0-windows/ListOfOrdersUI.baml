   M S B A M L   `   `   `  ����F  BCoursWorkEv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CoursWorkEvCoursWorkEv  5           CoursWorkEv.ListOfOrdersUI   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CoursWorkEv     5        N� Title$  ListOfOrdersUI��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridDataTrash��5      $��Center=�6.   $��Center=�6I   $	��430��5         AutoGenerateColumns$ False��6!   $��	0 0 0 100q�6=   
������ ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ UserName��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
UserName+  5      $ * 6%   $
 Name��6/    6=   �� *NameOfPizza+  5      $ * 6%   $ Price��6/    6>   �� *Price+  5      $ * 6%   $
 Time��6/    6=   �� *TimeOfOrder+ � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value��%�   '        �� 5      "  6   .�5      �� 	 � ��

 ��� �63   �� 5      	 � ��$
 1q�68   �� 5      	 � ��

 �   �63   �� 5      	 � ��$
 20(�61   �� 5      	 � ��$
 50��6/   5!      5"      5#      5$      5%      