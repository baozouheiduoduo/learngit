   M S B A M L   `   `   `  ����&  "Prism_MaterialDesignIntegrated_APP:    4Prism_MaterialDesignIntegrated_APP.Views.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5       � Title$ Loging please...��5      $	��500��6'   $	��900��64   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5	   
      NonClientFrameEdges$
 None=�6      GlassFrameThickness$ -1q�62      ResizeBorderThickness$ 0q�6K   6g   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.6* �6   6.   �� 5      $
��0.4* �6   6.   .+�5   
   � ���#eee.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6M   $��0q�6j   .+�5      �� $)��#/Assets/Images/人物对话-坐.png��6   $	��350��6;   $	��350��6G   5      5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      �� 5      $��299.604 �6    .+�5      �� ���	#FF4DB6AC6   �� 5      $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Leaf=�6*   
�������$��40��6I   $��40��6T   $��10q�6`   �� 5      $��Welcome!��6   $��Center=�6,    $   MaterialDesignHeadline1TextBlock#��[  5      
�������$��36(�5   /   5       �� 5!      $ 
Horizontal=�6   $	��Top=�62   $��Right=�6J   .+�5"      ��  % !MaterialDesignFlatSecondaryButton#��[ 6   
 � ToolTip$/
 )Resource name: MaterialDesignRaisedButton��5#       � Cursor$
 Hand��5$   H   ��6   0  *MaterialDesignThemes.Wpf.PackIconExtension  *WindowMinimize+6H   �� 5&      #��[ 6   $/
 )Resource name: MaterialDesignRaisedButton��5'      ��5(        *WindowClose+5*      �� 5+      $	��120��6   $	��120��6!   $��2��6.   $	��Top=�6?    �� CornerRadius$ 60��6W   $��	0,120,0,0q�6i   $��1q�5,      ���#A5CEF0 J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.         
BlurRadius$ 20Q�6'      ShadowDepth$ 5Q�67      	Direction$	 265Q�6G      Opacity$	 0.3Q�6W      Color$
 Gray��6e   ��50      �� 51       �� ImageSource$( "/Assets/Images/蓝绿色星空.png��6!   53      �� 54      $��1��6   $��Bottom=�6&   $	��240��6A   $��0 0 0 50q�6M   .+�55      �� $ 
Horizontal=�6   $��Center=�66   .+�56        $	 Account=�6.   
�������$��25��6O   $��30��6Z   $��5q�6f   �� 57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ UserName��6   .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextBoxViewMargin$ 1 0 1 0q�58         FloatingScale$
 0.00Q�59      $��Center=�5:   0   $��Center=�6M   $��30��5;      $��16(�6"   $	��200��60   $��0 0 0 1q�5<      
�������  MaterialDesignTextBoxBase#��[ 5=      $ IBeam��6I   ��5:      �� *
UserName+.��5=   X   5>      5?      �� 5@      $ 
Horizontal=�6   $��Center=�66   .+�5A        $
	 Lock=�6.   
�������$��25��6L   $��30��6W   $��5q�6c   �� 5J      $ Password��6   $ 1 0 1 0q�5K      $
 0.00Q�5L      $��Center=�5M   0   $��Center=�6M   $��30��5N      $��16(�6"   $	��200��60   $��0 0 0 1q�5O      
�������#��[ 5P      $ IBeam��6I   ��5M      �� *
Password+.��5P   X   5Q      5R      A� 5S       A� Rows$ 1��6   $��	0,10,0,20q�6'   .+�5T      ��   MaterialDesignDarkCheckBox#��[ 6   $��自动登录��6S   ���#BBB$��Center=�5U      �� 5V      #��[ 6   $��记住密码��6S   ���#BBB$��Center=�5W      �� 5X      $��Right=�6    $��Center=�6<   �� 5Y      .�6$   找回密码6*   5Z      5[      �� 5\       , (MaterialDesignRaisedSecondaryLightButton#��[ 6   $	��240��5]      
�������$=
 7Resource name: MaterialDesignRaisedSecondaryLightButton��5^      $��登  录��5_      $
 Hand��5a      ��5]   #   �� *LoginCommand+��5`      ��  �� RelativeSource ��  �� AncestorType
 Window5a      �� 5b      $��Center=�66   $��Center=�6Q   $��11(�6n   $	��0,5q�5c      
���  �� " MaterialDesignCaptionTextBlock#��[ 66   ��5b      �� *
ErrorMsg+5c   p   5d      5e      5h      5i      