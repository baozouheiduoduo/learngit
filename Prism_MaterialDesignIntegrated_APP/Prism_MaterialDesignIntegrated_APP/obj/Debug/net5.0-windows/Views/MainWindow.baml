   M S B A M L   `   `   `  ����]  YPrism_MaterialDesignIntegrated_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:Prism_MaterialDesignIntegrated_APP.GlobalData-Prism_MaterialDesignIntegrated_APP.GlobalData  5   	   9    3Prism_MaterialDesignIntegrated_APP.Views.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   Ilocal;clr-namespace:Prism_MaterialDesignIntegrated_APP.GlobalData   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	   $	��700��5   !   $
��1200��6.    � Title 6	   �� *Title+'  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      NonClientFrameEdges$
 None=�6      GlassFrameThickness$ -1q�62      ResizeBorderThickness$ 0q�6K   6g   .��5      � 
������ $��1q�6$   .+�5   
   ]� .+�5      )  #MaterialDesignThemes.Wpf.DrawerHost  -   5          Name$ 
DrawerHost��5   (   $��0q�6<   $	��700��6G   $
��1200��6T   $��Center=�5   '   $��Center=�6D   $��2q�6_      MaterialDesignDivider#���   5   '      BottomDrawerCornerRadius 	20 20 0 05   '   $	��Top=�6L     SecondaryHueLightBrush   BottomDrawerBackground# �  5   '   	   OpenMode$	 Standard=�6i   
   IsLeftDrawerOpen$

 True��5   '   ��5      �� 5       �� 
TargetType"  6    �� BasedOn# [B 6C   5%         LeftDrawerContent 5'      �� 5(      $��0q�6!   ���#EEE.+�5)      � $
��Left=�6   $	��230��65   $	��700��6A   ���#EEE � RowDefinitions 5*      �� 5+   "   $��0.15* �60   �� 5,   "   $��0.75* �60   �� 5-   "   $
��0.1* �60   .+�5/      � ���	#ffa6b1b1.+�50   "   ��  �� Orientation$ 
Horizontal=�6-   $��	10 0 10 0q�6F   $��Center=�6Y   $
��Left=�6t   .+�51   &   �� $��/Assets/Images/Face5.png��6,   $��70��6N   $��	0 10 0 10q�6Y   �� 52   &   $��12(�6w   $
��Bold"�6�   $��Center=�6�   $
��5 30q�53   0   $��WrapWithOverflow=�6>   ��52   0   �� *Access+>   8Prism_MaterialDesignIntegrated_APP.GlobalData.GlobalData   CurrentUser �� Source# Z 53   >   �� 54   &   $��20(�6Q   $
��Bold"�6_   $��Center=�6q   $
��5 30q�55   0   $��WrapWithOverflow=�6>   ��54   0   �� *CurrentUserName+55   >   57   #   �� 58   "   $��Right=�6-   $��16q�6I   .+�59   &   �� $��45��6`      CloseDrawerCommand#��Z 5:   -   "  System.Windows.Controls.Dock   Left#��Z 5;   -   $��Right=�6U    ! MaterialDesignFlatLightButton#��[ 5<   -   
���������59   -   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 	ArrowLeft=�5<   d   5=   #   5>      � 5A      $��1��6#   .+�5B   "   �� $ Vertical=�6-   $��4 4 0 4q�6D   .+�5C   &   	�  % !MaterialDesignTabRadioButtonRight#��[ 62   $��4 4 0 4q�5D   &    d� 	IsChecked$
 TrueY�67   $
��Left=�6H     PrimaryHueMidBrush#���  5E   &   ��5F   2   �� *OpenDashboard+.��5G   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5H   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ViewDashboardVariant=�6F   �� 5I   .   $��4 0 0 0q�68   $��	DashBoard��6I   5J   +   5K   '   	� 5L   &   #��[ 62   $��4 4 0 4q�5M   &   $ FalseY�67   $
��Left=�6I   #���  5N   &   ��5O   2   �� *OpenDataTable+.��5P   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5Q   .     $ 
TableLarge=�6F   �� 5R   .   $��4 0 0 0q�68   $��	DataTable��6I   5S   +   5T   '   	� 5U   &   #��[ 62   $��4 4 0 4q�5V   &   $ FalseY�67   $
��Left=�6I   #���  5W   &   .��5X   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5Y   .     $ ChartBar=�6F   �� 5Z   .   $��4 0 0 0q�68   $��	DataChart��6I   5[   +   5\   '   	� 5]   &   #��[ 62   $��4 4 0 4q�5^   &   $ FalseY�67   $
��Left=�6I   #���  5_   &   ��5`   &   �� *OpenUserManage+.��5a   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5b   .     $ AccountEdit=�6F   �� 5c   .   $��4 0 0 0q�68   $��
UserManage��6I   5d   +   5e   '   	� 5f   &   #��[ 62   $��4 4 0 4q�5g   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5h   &   .��5i   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5j   .     $ Smiley=�6F   �� 5k   .   $��4 0 0 0q�68   $��to be define��6I   5l   +   5m   '   	� 5n   &   #��[ 62   $��4 4 0 4q�5o   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5p   &   .��5q   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5r   .     $ Smiley=�6F   �� 5s   .   $��4 0 0 0q�68   $��to be define��6I   5t   +   5u   '   	� 5v   &   #��[ 62   $��4 4 0 4q�5w   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5x   &   .��5y   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5z   .     $ Smiley=�6F   �� 5{   .   $��4 0 0 0q�68   $��to be define��6I   5|   +   5}   '   	� 5~   &   #��[ 62   $��4 4 0 4q�5   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5�   &   .��5�   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5�   .     $ Smiley=�6F   �� 5�   .   $��4 0 0 0q�68   $��to be define��6I   5�   +   5�   '   	� 5�   &   #��[ 62   $��4 4 0 4q�5�   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5�   &   .��5�   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5�   .     $ Smiley=�6F   �� 5�   .   $��4 0 0 0q�68   $��to be define��6I   5�   +   5�   '   	� 5�   &   #��[ 62   $��4 4 0 4q�5�   &   $ FalseY�67   ${�false��6I   $
��Left=�6[   #���  5�   &   .��5�   *   �� $ 
Horizontal=�65   $��40 0 0 0q�6N   $	��160��6`   .+�5�   .     $ Smiley=�6F   �� 5�   .   $��4 0 0 0q�68   $��to be define��6I   5�   +   5�   '   5�   #   5�      � 5�      $��2��6#   .+�5�   "   �� .+�5�   &   �� #��Z 6-   #��Z 6o   $
��10 4q�5�   )   $��Center=�67     MaterialDesignFlatButton#���  6T   $��
CLOSE THIS��5�   )   5�   #   5�      5�      5�      .��5�      �  5�      �� 5�      $��0.15* �6(   �� 5�      $��0.85* �6(   .+�5�      � ���#008477.+�5�      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Custom=�64   ���#008477
�������$��
16 16 16 0q�5�   4   $}�False��6I   .��5�      ]� .+�5�   "   ��  % !MaterialDesignFlatSecondaryButton#��[ 6)    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   )   $��Right=�6]   
���������5�   )     *WindowClose+��5�   )   �� *CloseWindow+�� 5�   "   #��[ 6)   $/ )Resource name: MaterialDesignRaisedButton��5�   )   $��Right=�6]    � Cursor$
 Hand��5�   \   
���������6)     *WindowMinimize+6j   '	  !MaterialDesignThemes.Wpf.PopupBox	  5�   "   $��Right=�6:    	  PlacementMode$ BottomAndAlignRightEdges=�6Q    	  PopupContent. 5�   &   �� .@�5�   *   �� $��Github��66   �� 5�   *   $��Twitter��66   �� 5�   *   $��Google��66   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   .+�5�   &   �� $��45��6a      OpenDrawerCommand#��Z 5�   -   #��Z 5�   -   
�������#��[ 5�   -   ��5�   -     $ 
ArrowRight=�5�   -   �� 5�   &   $��Center=�60   $
��16 0q�6K   $%��Material Design In XAML Toolkit��6Y   $��18(�6�   %
  MaterialDesignThemes.Wpf.Badged
  5�   &    
  Badge$	 123��6<   $��Center=�6H   .��5�   *   �� $��Some action��61   ���#3cb4a66G   5�   '   5�   #   5�      5�      5�      �� 5�      $��1��6%   !  Prism.Regions.RegionManager   
RegionName$ MainContentRegion��62   5�      5�      5�      5�      5�      