   M S B A M L   `   `   `  ����&  "Prism_MaterialDesignIntegrated_APP?    9Prism_MaterialDesignIntegrated_APP.Views.Region_Dashboard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5      .��5      �  � RowDefinitions 5   
   �� 5	      $
��0.9* �6   �� 5
      $
��1.1* �6   .+�5   
   �� $
��10 0q�6   $��Center=�6#   .+�5      ��  $   MaterialDesignHeadline2TextBlock#��[  6   $��Welcome to XXXXXXX!��6R   5      7  1MaterialDesignThemes.Wpf.Transitions.Transitioner  5   
    �� SelectedIndex$ 0��6&   !   AutoApplyTransitionOrigins$
 True��68   $��1��6Z    J� InputBindings 5      �� 5      
 �� Key$
 Left��6      MovePreviousCommand �� Command# Z 6)   �� 5      $ Right��6      MoveNextCommand# Z 6*   .@�5      <  6MaterialDesignThemes.Wpf.Transitions.TransitionerSlide  ���#47b4a4C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6/   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *FadeIn+.��5      �  5      �� 5      $
��0.3* �6(   �� 5      �� 5      $��0.35* �6(   .+�5      ��  $  MaterialDesignHeadline4TextBlock#��[ 6    $��Part 1��6[   ���#ffffff$
��10 0q�6~   A� 5      
 A� Rows$
 1��6"   $��1��6+   .+�5       #  MaterialDesignThemes.Wpf.Card  $	��150��6.   .��5!      � ���#eee 5"   "   �� 5#   &   $	��100 �64   �� 5$   &   $��* �64   .+�5&   "   �� $��/Assets/Images/山竹.png��6(   $	��100��5'   (   $	��150��65   $
��Fill=�6A   �� 5(   "   $��0��6)    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 66   $��Right=�5)   )   $��Bottom=�6E   $��
0 0 16 -20q�6a    � Cursor$
 Hand��6u   .��5*   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Bike=�6>   5+   #   �� 5,   "   $��1��6-   $��8 8 8 0q�6;   .+�5-   &   �� $
��Bold"�60   	Cycling5/   '   �� 50   &   $
��Wrap=�60   $��Center=�6D   $H��BA great way to keep fit and forget about the constant grind of IT.��51   0   52   #   53      54        55      $	��150��6.   $
��10 0q�6:   .��56      � ���#eee 57   "   �� 58   &   $	��100 �64   �� 59   &   $��* �64   .+�5;   "   �� $��/Assets/Images/芒果.png��6(   $	��100��5<   (   $	��150��65   $
��Fill=�6A   �� 5=   "   $��0��6)   #��[ 66   $��Right=�5>   )   $��Bottom=�6E   $��
0 0 16 -20q�6a   .��5?   &     $
 Bike=�6>   5@   #   �� 5A   "   $��1��6-   $��8 8 8 0q�6;   .+�5B   &   �� $
��Bold"�60   	Cycling5D   '   �� 5E   &   $
��Wrap=�60   $��Center=�6D   $H��BA great way to keep fit and forget about the constant grind of IT.��5F   0   5G   #   5H      5I        5J      $	��150��6.   .��5K      � ���#eee 5L   "   �� 5M   &   $	��100 �64   �� 5N   &   $��* �64   .+�5P   "   �� $��/Assets/Images/苹果.png��6(   $	��100��5Q   (   $	��150��65   $
��Fill=�6A   �� 5R   "   $��0��6)   #��[ 66   $��Right=�5S   )   $��Bottom=�6E   $��
0 0 16 -20q�6a   .��5T   &     $
 Bike=�6>   5U   #   �� 5V   "   $��1��6-   $��8 8 8 0q�6;   .+�5W   &   �� $
��Bold"�60   	Cycling5Y   '   �� 5Z   &   $
��Wrap=�60   $��Center=�6D   $H��BA great way to keep fit and forget about the constant grind of IT.��5[   0   5\   #   5]      5^      5_      �� 5`      $��Right=�6!   $��Bottom=�6=    �� Orientation$ 
Horizontal=�6X   $��0 0 0 8q�6q   $��2��6�   .+�5a      ��  8 4MaterialDesignFloatingActionMiniSecondaryLightButton#��[ 6!    � ToolTip$: 4MaterialDesignFloatingActionMiniSecondaryLightButton��5b         MoveLastCommand#��Z 5c      $
 Hand��6^   .��5d        $ ArrowLeftBox=�66   5e      �� 5f       7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 6!   $9 3MaterialDesignFloatingActionMiniSecondaryDarkButton��5g      #��Z 5h      $
��10 0q�6^   .��5i        $ ArrowRightBox=�62   5j      5k      5l      5m        5n      ���#47b4a4	 6/     *FadeIn+.��5q      �  5r      �� 5s      $
��0.3* �6,   �� 5t      �� 5u      $��0.35* �6,   .+�5w      �� #��[ 6$   $��Part 2��6_   ���#ffffff$
��10 0q�6�   �� 5x      $��1��6%   $	��Top=�62   $
��10 0q�6J   .+�5y      ��    MaterialDesignBody2TextBlock#��[ 6(   $����Material Design是一个很好用的WPF样式库和控件集，对于稍微有点WPF基础的开发者非常友好。简单好用是我的第一感：直接使用NuGet就可以获取到资源包，通过其官方的DemoApp(MaterialDesignDemo)很容易使用控件和样式，上手贼快。 ��5z   )   $
��Wrap=�5{   )   
�������6=   �� 5|      �� 5}      #��[ 6$   $����对于喜欢钻研的同学来说，他具备完善的资料：GitHub源码和实例，也可以使用DemoApp中的对应控件的''和{}跳转到对应控件的源码，通过学习研究创作出更多的好看、好用的样式和控件.��5~   (   $
��Wrap=�5   (   
�������6<   5�      �� 5�      $��Right=�6%   $��Bottom=�6A   $ 
Horizontal=�6\   $��0 0 0 8q�6u   $��2��6�   .+�5�      �� #��[ 6%   $: 4MaterialDesignFloatingActionMiniSecondaryLightButton��5�      #��Z 5�      $
 Hand��6b   .��5�   "     $ ArrowLeftBox=�6:   5�      �� 5�      #��[ 6!   $9 3MaterialDesignFloatingActionMiniSecondaryDarkButton��5�      #��Z 5�      $
��10 0q�6^   .��5�        $ ArrowRightBox=�66   5�      5�      5�      5�        5�      ���#47b4a4	 6/     *FadeIn+.��5�      �  5�      �� 5�      $
��0.3* �6(   �� 5�      �� 5�      $��0.35* �6(   .+�5�      �� #��[ 6    $��Part 3��6[   ���#ffffff$��0��6~   $
��10 0q�6�   �� 5�      $��1��6!   $
��10 0q�6.   .+�5�      ��    MaterialDesignBody1TextBlock#��[ 6$   $��Open Source��5�       
�������$
��Wrap=�5�       �� 5�      #��[ 6$   $����最开始接触WPF是2017年11月份，相比当时自己也不大熟悉Winform，觉得WPF做的效果很好。但由于一些原因，公司也没有采用WPF进行项目开发。后来一直都是自己看看MSDN、《WPF编程宝典》、bilibili以及万能的百度等，自己也学到了很多。后来在2018年1月份，自己主张使用WPF开发了一个物联网设备监控系统，虽然遇到很多问题，但是最后的效果我觉得能甩Winform很远...自此，开始了漫长的WPF学习之旅。��5�       $
��Wrap=�5�       
�������64   �� 5�      6&   �� 5�      #��[ 6$   $����最开始应该是今年年初在Bilibili上的一次视频学习中，看到了Material Design，当时没多大在意。就在昨天，我在给新项目找一些框架资源时。发现很多人都对这个免费开源的UI组件赞不绝口，于是就去GitHub下了APPDemo和源码，当时的效果就把我惊艳到了。这个必须学...��5�       $
��Wrap=�5�       
�������64   5�      �� 5�      $��Right=�6!   $��Bottom=�6=   $ 
Horizontal=�6X   $��0 0 0 8q�6q   $��2��6�   .+�5�      �� #��[ 6!   $: 4MaterialDesignFloatingActionMiniSecondaryLightButton��5�      #��Z 5�      $
 Hand��6b   .��5�        $ ArrowLeftBox=�66   5�      �� 5�      #��[ 6!   $9 3MaterialDesignFloatingActionMiniSecondaryDarkButton��5�         MoveFirstCommand#��Z 5�      $
��10 0q�5�   !   .��5�        $ ArrowRightBox=�66   5�      5�      5�      5�      5�      5�      5�      