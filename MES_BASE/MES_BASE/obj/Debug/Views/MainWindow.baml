   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	    MES_BASE   MES_BASE.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5   	    	  Title � Title# �   5   	   $	��800��6)   $
��1280��66   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $	��14* �6   .+�5   
   � $��0��6   ���#003C8F.+�5      o�  o� 
IsMainMenu . .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryDark=�6%   ���#002171.@�5      m�   User#���  6   .@�5      m�   	UserLogin#���  6    m� Icon 6D   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ AccountArrowRight=�6~   m� 5        
UserLogOff#���  6    6E     $ AccountArrowlEFT=�6~   m� 5        UserManagement#���  6    6I     $ AccountGroup=�6~   m� 5        OperatoreRegister#���  6    6L     $ AccountEdit=�6�   5      m� 5        SystemSetting#���  6   .@�5      m�   DatabaseSetting#���  6    m� Command 6J   ��  6^     $ DatabaseCog=�m� 5        TypeSetting#���  6    6F   ��  6Z     $ 	ChartTree=�m� 5       	 
MES_Switch#��� 	 6    6E   ��  6Y     $ Switch=�m� 5       
 AlarmDefinition#��� 
 6    6J   ��  6^     $ 
AlarmPanel=��� 5      m� 5        LanguageChange#���  6    6I     $ 	Translate=�.@�5      m�   EN#���  6#    m� CommandParameter$ en_US��6d    6A   �� *ChangeLanguage+ 5      �� 5   "   $ ��/Assets/Images/English.bmp��6(   $��UniformToFill=�6L   5!      m� 5"        CN#���  6#   $ zh_CN��6d    6A   �� *ChangeLanguage+ 5#      �� 5$   "   $��/Assets/Images/China.bmp��6(   $��UniformToFill=�6J   5&      5'      5(      5)      5*      � 5+   
   $��1��6   	 � ColumnDefinitions	 5,      �� 5-      $��2* �6#   �� 5.      $��9* �6#   .+�50      � $��0��6   ���#004ba0.+�51      �� 
 �� Orientation$
 Vertical=�6   .+�52      �� ���#003C8F.+�53      ��   FunctionArea#���  6$   
�������$��12(�6]    �� TextAlignment$
 Left=�6k   $��Center=�6�   $
��10 5q�6�   54      R� 55      -   5         R�Name$ treeView��55   O     MaterialDesignTreeView#��[ 6   .   (System.Windows.Interactivity.Interaction   Triggers 56      /   )System.Windows.Interactivity.EventTrigger  57         	EventName$ SelectedItemChanged��6-   .   (System.Windows.Interactivity.TriggerBase   Actions. 58   "   6   0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *MenuTreeChanged+   CommandParameter 59   8   ��  �� ElementName$ treeView�� �� Path$ SelectedItem�5:      .@�5<      Q� #���  6'   $��18(�6Q   .@�5=      Q� 
 � Tag$ 	UserLogin��6+   ��5>   "   �� 5?   &   $
 
Horizontal=�61   $��0q�6J   .+�5@   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountArrowRight=�6B   �� 5A   *   $��8 0 0 0q�64   #���  6E    $  MaterialDesignSubtitle2TextBlock#��[ 6h   5B   '   5D      Q� 5E      $ 
UserManage��6+   ��5F   "   �� 5G   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5H   *     $ AccountGroup=�6B   �� 5I   *   $��8 0 0 0q�64     
UserManage#���  6E   #��[ 6i   5J   '   5L      Q� 5M      $ OperatoreRegister��6+   ��5N   "   �� 5O   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5P   *     $ AccountEdit=�6B   �� 5Q   *   $��8 0 0 0q�64   #���  6E   #��[ 6p   5R   '   5T      Q� 5U      $ 
UserLogOff��6+   ��5V   "   �� 5W   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5X   *     $ AccountArrowLeft=�6B   �� 5Y   *   $��8 0 0 0q�64   #���  6E   #��[ 6i   5Z   '   5\      5]      Q� 5^      #���  6'   $��18(�6P   .@�5_      Q� ��5`   "   �� 5a   &   $
 
Horizontal=�61   $��0q�6J   .+�5b   *     $ DatabaseCog=�6B   �� 5c   *   $��8 0 0 0q�64   #���  6E   #��[ 6n   5d   '   5f      Q� 5g      ��5h   "   �� 5i   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5j   *     $ 	ChartTree=�6B   �� 5k   *   $��8 0 0 0q�64   #���  6E   #��[ 6j   5l   '   5n      Q� 5o      ��5p   "   �� 5q   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5r   *     $ Switch=�6B   �� 5s   *   $��8 0 0 0q�64   #��� 	 6E   #��[ 6i   5t   '   5v      Q� 5w      ��5x   "   �� 5y   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5z   *     $ 
AlarmPanel=�6B   �� 5{   *   $��8 0 0 0q�64   #��� 
 6E   #��[ 6n   5|   '   5~      5      Q� 5�        ProductionManagement#���  6'   $��18(�6W   .@�5�      Q� ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0q�6J   .+�5�   *     $ Notebook=�6B   �� 5�   *   $��8 0 0 0q�64     ProductionPlan#���  6E   #��[ 6m   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ NotebookMultiple=�6B   �� 5�   *   $��8 0 0 0q�64     HistoryPlan#���  6E   #��[ 6j   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ Bathtub=�6B   �� 5�   *   $��8 0 0 0q�64     StationOperator#���  6E   #��[ 6n   5�   '   5�      5�      Q� 5�        ProductionMonitor#���  6'   $��18(�6T   .@�5�      Q� ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0q�6J   .+�5�   *     $ Notebook=�6B   �� 5�   *   $��8 0 0 0q�64   #���  6E   #��[ 6m   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ NotebookMultiple=�6B   �� 5�   *   $��8 0 0 0q�64   #���  6E   #��[ 6j   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ Bathtub=�6B   �� 5�   *   $��8 0 0 0q�64   #���  6E   #��[ 6n   5�   '   5�      5�      Q� 5�        DataManagement#���  6'   $��18(�6Q   .@�5�      Q� ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0q�6J   .+�5�   *     $ DatabaseSearch=�6B   �� 5�   *   $��8 0 0 0q�64     
DataSearch#���  6E   #��[ 6i   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ TimelineClock=�6B   �� 5�   *   $��8 0 0 0q�64     	CycleTime#���  6E   #��[ 6h   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ Repeat=�6B   �� 5�   *   $��8 0 0 0q�64     ReworkMonitor#���  6E   #��[ 6l   5�   '   5�      Q� 5�      ��5�   "   �� 5�   &   $
 
Horizontal=�61   $��0 0 0 0q�6J   .+�5�   *     $ MonitorDashboard=�6B   �� 5�   *   $��8 0 0 0q�64     AlarmMonitor#���  6E   #��[ 6k   5�   '   5�      5�      5�      5�      5�      � 5�      $��1��6   ���#2E6BB1.+�5�      �� !	  Prism.Regions.RegionManager 	  
RegionName$ ContentRegion��6!   5�      5�      5�      5�      