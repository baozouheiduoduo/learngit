   M S B A M L   `   `   `  ����C  ?MES_BASE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MES_BASE.CommonMES_BASE.Common  5      !    MES_BASE.Views.Dialog_Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %cclr-namespace:MES_BASE.Common  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5      $	��280��5	      $	��350��6   .��5
      � ���#1976d2 � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��1.5* �6   .+�5   
   ��    	GroupName#���   6   .��5      �� $��
15 15 15 0q�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6.   
�������$��25��6T   $��30��6_   $��5q�6k   �� 5        	User_Name)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6   .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextBoxViewMargin$ 1 0 1 0q�5         FloatingScale$
 0.00Q�5      $��Center=�5   0   $��Center=�6M   $��30��5      $��16(�6"   $	��200��60   $��0 0 0 1q�5      
�������  MaterialDesignTextBoxBase#��[ 5       � Cursor$ IBeam��6I   ��5      �� *
UserName+.��5   X   5      5      �� 5      $ 
Horizontal=�6   .+�5        $
 Lock=�6.   
�������$��25��6Q   $��30��6\   $��5q�6h   G� 5      -   5         G�Name$ PasswordBox��5   "     User_Password# �  67   $ 1 0 1 0q�5      $
 0.00Q�5       	   HasClearButton	 . $��Center=�5"      $��Stretch=�6;   $��30��5#      $��16(�6*   $	��200��68   $��0 0 0 1q�5$      
�������$ IBeam��6P   '   !MES_BASE.Common.PasswordBoxHelper
   Password
 5%      �� *
Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.  (System.Windows.Interactivity.Interaction   	Behaviors 5&      )   #MES_BASE.Common.PasswordBoxBehavior  5'      5)      5*      �� 5+      $ 
Horizontal=�6   $��	10 5 10 0q�66   .+�5,      ��   Message#���  6    6C   �� 5-      $��WrapWithOverflow=�66   $��40��6V   $	��180��6b   ��6    �� *Info+6b   5.      5/      50      �� 51   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�52      ��  , (MaterialDesignRaisedSecondaryLightButton#��[ 6   $	��100��53       � ToolTip$= 7Resource name: MaterialDesignRaisedSecondaryLightButton��54       	 login#���  55      $
 Hand��57      $��
0 20 20 20q�6%   ��53   #   �� *SaveCommand+��56      ��  �� RelativeSource ��  �� AncestorType$ WindowL�57   ;   �� 58       + 'MaterialDesignRaisedSecondaryDarkButton#��[ 6   $	��100��59      $3 -Resource name: MaterialDesignRaisedDarkButton��5:        exit#���  5;      $
 Hand��5=      ��59   #   �� *CancelCommand+��5<      ��  �� $ WindowL�5=   (   5>      5?      5@      