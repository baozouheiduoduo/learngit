   M S B A M L   `   `   `  ����  MES_BASE&     MES_BASE.Views.Region_UserManage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5      .��5      �  � RowDefinitions 5   
   �� 5	      $��9* �6   �� 5
      $��1* �6   .+�5   
   ��    UserList#���   6   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�67      
Foreground
 �����.��5      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .  ���#004ba0   CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�5   N   	   CanUserReorderColumns	 .  
 �� AlternationCount$
 2��5   5      RowHeaderWidth$ 0Q�6J      CanUserAddRows .  ��5      �� *
UserList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 XXID��6)      
Visibility$ 	Collapsed=�67      Width5  /System.Windows.Controls.DataGridLengthConverter$ 33 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *Number+6i   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5        UserName# �  5      $	 150 5       0 ,MaterialDesignDataGridTextColumnEditingStyle   EditingElementStyle# [ 5       5      �� *
UserName+5        5        Password# �  5      $	 150 5      # [ 5       5      �� *
Password+5        5        
UserAccess# �  5!      $ * 5"      # [ 5#       5       �� *Access+5$      5'      5(      5)      5*      