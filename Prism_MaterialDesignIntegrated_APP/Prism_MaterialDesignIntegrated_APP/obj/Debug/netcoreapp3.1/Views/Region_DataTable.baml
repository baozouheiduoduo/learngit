   M S B A M L   `   `   `  ����&  "Prism_MaterialDesignIntegrated_APP?    9Prism_MaterialDesignIntegrated_APP.Views.Region_DataTable   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5      .��5      �  � RowDefinitions 5   
   �� 5	      $
��0.1* �6   �� 5
      $
��0.9* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5 5 0 0q�6.   .+�5      ��  #  MaterialDesignFlatLightBgButton#��[  6   $��Refresh��5      ��5   N   �� *	Refresh+5      5      �� 5   
   $��1��6   $��5q�6"   .+�5      &   System.Windows.Controls.DataGrid     
IsReadOnly$
 True��6      AutoGenerateColumns$ False��6)      CanUserResizeColumns$ False��5         CanUserResizeRows$ False��64      SelectionMode$ Extended=�6N      CanUserReorderColumns$ False��5      	 �� AlternationCount$	 2��65   
   RowHeaderWidth$
 1Q�6J      CanUserAddRows$ False��6]   ���	#FFFAFAFA��5      �� *ProductList+   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5       4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5      ,  &System.Windows.Controls.DataGridColumn   Header 5      �� 5      
������ ._�5   "   �� 5         HeaderStyle 5       �� 5!       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 6O   .�5"   "   ��  �� Property � �� �� Value$ Center=�6O   5#      5%      0  *System.Windows.Controls.DataGridTextColumn  5'      $ 产品型号��5)         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5*         
Foreground �#747474   Binding 5(      �� *Type+ 5+      �� 5,      "  6$   .�5-   "   ��  � ��$
 Left=�6O   �� 5.   "    � �� �#7474746?   �� 5/   "    � �� 50   &   �� 51   *   .R�52   .   �� $
��Wrap=�53   1    �� TextAlignment$
 Left=�55   1   ��54   1   �� 55   1   56   +   58   #   59      5;        5<      $ 产品特征码��5>      $	 180 5?       �#747474 5=      �� *Code+ 5A      �� 5B      "  6$   .�5C   "   ��  � ��$
 Left=�6O   �� 5D   "    � �� �#7474746?   �� 5E   "    � �� 5F   &   �� 5G   *   .R�5H   .   �� $
��Wrap=�5I   1   $
 Left=�5K   1   ��5J   1   �� 5K   1   5L   +   5N   #   5O      5Q        5R      $ 产品质量��5T      $	 100 5U       �#747474 5S      �� *	Quality+ 5W      �� 5X      "  6$   .�5Y   "   ��  � ��$
 Left=�6O   �� 5Z   "    � �� �#7474746?   �� 5[   "    � �� 5\   &   �� 5]   *   .R�5^   .   �� $
��Wrap=�5_   1   $
 Left=�5a   1   ��5`   1   �� 5a   1   5b   +   5d   #   5e      5g        5h      $ 特征码等级��5j      $	 100 5k       �#747474 5i      �� *	CodeLevel+ 5m      �� 5n      "  6$   .�5o   "   ��  � ��$
 Left=�6O   �� 5p   "    � �� �#7474746?   �� 5q   "    � �� 5r   &   �� 5s   *   .R�5t   .   �� $
��Wrap=�5u   1   $
 Left=�5w   1   ��5v   1   �� 5w   1   5x   +   5z   #   5{      5}        5~      $ 其他备注��5�      $	 100 5�       �#747474 5      �� *Description+ 5�      �� 5�      "  6$   .�5�   "   ��  � ��$
 Left=�6O   �� 5�   "    � �� �#7474746?   �� 5�   "    � �� 5�   &   �� 5�   *   .R�5�   .   �� $
��Wrap=�5�   1   $
 Left=�5�   1   ��5�   1   �� 5�   1   5�   +   5�   #   5�      5�      5�      5�      5�      5�      