   M S B A M L   `   `   `  ����K  GReddit Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Reddit_Prototype.User_ControlReddit_Prototype.User_Control  5      (    "Reddit_Prototype.User_Control.Post   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Reddit_Prototype.User_Control     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��4* �6   6*   �� 5      $��3* �6   6*   �� 5      $��4* �6   6*   .+�5   
   �� -   5        $��lblName��5      $��Title Goes Here��6   $��Stretch=�69   $��Stretch=�6W   $��22(�6t   �� 5   
   -   5        $��
txtContent��5      $��Stretch=�6&   $��1��6D   $
��Wrap=�6Q   $��	TextBlock��6e   $��Stretch=�6v   $��2��6�   �� 5   
   -   5        $��scrollComments��5      $��3��6-   $��2��6:   $	��100��6N   .��5      �� -   5        $��stkPostComments��5      5      �� 5   
   $��Add A Comment��6   $��Stretch=�6*   $��2��6H   $��Stretch=�6U   $��2��6q   .��5      �   5      �� 5      $��9* �6'   64   �� 5      $��1* �6'   64   .+�5      �� -   5        $	��Add��5      $��1��6'   $��Stretch=�67   $��Stretch=�6U   6q   �� 5       -   5        $��
txtComment��5       $��Stretch=�6,    �� TextWrapping$
 Wrap=�6J   $��TextBox��6^   $��Stretch=�6m   5!      5"      �� 5#   
   -   5        $��	lblPoster��5#      $��Label��6!   $��1��61   $��Stretch=�6A   $��Stretch=�6_   5$      5%      