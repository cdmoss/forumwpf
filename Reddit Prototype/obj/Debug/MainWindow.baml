   M S B A M L   `   `   `  ����K  GReddit Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Reddit_PrototypeReddit_Prototype  5   	   !    Reddit_Prototype.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Reddit_Prototype     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$	  All��5   	   $	��450��6   $	��800��6"      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 1Q�6-   � 5      $ 	#FF9A32C1��6   $ 1Q�61   � 5      $ 	#FF7F299F��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��109* �6   �� 5      $	��22* �6   6-    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5       $	��10* �6   6,   .+�5"   
   �� $��1��6   $��1��6'   .��5#      �� -   5        $��stkPosts��5#      5$      �� 5%   
   -   5        	 ��Name$	 btnLogin��5%      $��Login��6#   $��2��63   $
��10,3q�6C   $	��112��6Q   6]   �� 5&   
   -   5        $��btnPost��5&      $
��Post��6    $��2��6/   $
��Left=�6?   $��	10,10,0,0q�6Z   $��1��6m   $	��Top=�6z   $	��112��6�   $	��361��6�   6�   �� 5'   
   $	��All��6   $��1��6   $
��Left=�6.   $��10,7,0,0q�6I   $	��Top=�6[   $��92��6s   $��Center=�6~   �� 5(   
   $��Popular��6   $��1��6"   $
��Left=�62   $��	107,7,0,0q�6M   $	��Top=�6`   $��92��6x   $��Center=�6�   �� 5)   
   $
��News��6   $��1��6   $
��Left=�6/   $��	204,7,0,0q�6J   $	��Top=�6]   $��72��6u   $��Center=�6�   �� 5*   
   $��The Other News��6   $��1��6)   $
��Left=�69   $��	281,7,0,0q�6T   $	��Top=�6g   $	��112��6   $��Center=�6�   �� 5+   
   $��Sports��6   $��1��6!   $
��Left=�61   $��	398,7,0,0q�6L   $	��Top=�6_   $��92��6w   $��Center=�6�   �� 5,   
   $��Gaming��6   $��1��6!   $
��Left=�61   $��	495,7,0,0q�6L   $	��Top=�6_   $��92��6w   $��Center=�6�   
 J� RenderTransformOrigin$
 	1.58,0.37&�6�   5-      5.      