   M S B A M L   `   `   `  ����@  <OA.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Ay.Framework.WPF.ControlsAy.Framework.WPF.Controls  5   	   clr-namespace:OA.UIOA.UI  5   	       OA.UI.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;control'clr-namespace:Ay.Framework.WPF.Controls     5   	   %localclr-namespace:OA.UI     5   	   (   "Ay.Framework.WPF.Controls.AyWindow    Loaded$  AyWindow_Loaded��5      $	��900��5   A   $
��1600��6N   $
��1465��6[   $	��738��6k   (   "Ay.Framework.WPF.Controls.AyWindow   TitleVisibility$ 	Collapsed=�6{    � WindowStartupLocation$ CenterScreen=�5   +    � WindowState$ 	Maximized=�6P   
������� � Title$ XX公司HR演示系统��5
   	    � 	Resources 5         MainTabItemStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name J� SnapsToDevicePixels �� CornerRadius �� EndPoint �� 
StartPoint � Color � Offset'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name �� ContentStringFormat �� ContentStringFormat��%T  &	        �� 5   
   " 	�6)   .�5      ��  �@�Cursor$
 Hand��6'   �� 5       �@�FocusVisualStyle 61   Z� 6D   �� 5       � ��$ Center=�69   6J   �� 5       � ��$ Center=�6;   6L   �� 5       � �� 5      �� 5      "	 	�6&   .R�5      �� $
 radioButtonBorder��6!   ���#5E6261 . $��1,1,1,0q�6n   $ 5,5,0,0��6�   ��5      �� 5   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5   &   � $ 	#FFEBF3F2��63   $ 0Q�6E   � 5   &   $ 	#FF9CC1BC��63   $ 1Q�6E   5   #    5        5   "   CheckStates�� 5   &     5    *   $ 0:0:0.3D�6;   . 5"   &     Checked��. 5#   *   �� .��5$   .   �� $N H(Panel.Background).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6K   $ radioButtonBorder��6�   .g�5%   2     $ 0��6F   $ White��6R   5&   /   �� 5'   .   $N H(Panel.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6K   $ radioButtonBorder��6�   .g�5(   2     $ 0��6F   $ 	#FFEFEFEF��6R   5)   /   5*   +   5+   '     5,   &   	Unchecked��62     5-   &   Indeterminate��62   5.   #   ._�50      �� $ contentPresenter��6/   #��z��6I   #��z��51      # z 6<   |�.  #��z��52      #��z��6[   ��. # z 53   3   #��z��54      55      58      5:      5;      5=      .��5>      � $��	0,-24,0,0q�6    � ColumnDefinitions 5?   
   �� 5@      $	��175 �6   �� 5A      $��* �6    � RowDefinitions 5C   
   �� 5D      $��68 �6   �� 5E      $��* �6   �� 5F      $��27 �6   .+�5H   
   �� $��68��6   $��0��6   $��2��6-   }�. ��5I      �� 5J      $ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5K      � $ #64A5A5��6#   $ 0Q�63   � 5L      $ #568D8D��6#   $ 1Q�63   5M      .+�5P      A� -   5          A�Name$  logo_bg��5P      $	��222��6'   $	��222��63   
! �� Top$
! -164��6@   " J� RenderTransformOrigin$" 0.5,0.5&�6R   # �� Left$
# 29.5��6r   ��5R      
� 5S      $ 
� RadiusY$$ 0.429Q�6*   % 
� Center$% 0.331,0.514&�6:   & 
� GradientOrigin$& -0.263,0.022&�6O   ' 
� RadiusX$' 0.665Q�6m   .��5T      � $ 	#FFE7F3F0��6'   $ 0.484Q�69   � 5U      $ 	#FF63A3A3��6'   $ 1Q�69   � 5V      $ 	#FF578F8F��6'   $ 1Q�69   � 5W      $ 	#FF578F8F��6'   $ 0.919Q�69   � 5X      $ White��6'   $ 0.634Q�65   5Y      5[      �� 5o      -   5        ( ��Name$( img_CompanyLogo��5o      $	��154��6-   $��68��69   $,��&SystemResources/images/companyLogo.png��6E   6w   �� 5p      $��39��6   ) �� Bottom$) 0��6%   * �� Orientation$* 
Horizontal=�67   $	# 173��6P   .+�5q      	� $	��1,0q�6   $��Bottom=�6+   $��桌面��6F   $��39��6S   $��	15,5,15,0q�6_   #���   6s   6�   	� 5r      $	��1,0q�6   $��Bottom=�6+   $��个人��6F   $��39��6S   $��	15,5,15,0q�6_   #���   6s   5s      	� 5t      $	��1,0q�6   $��Bottom=�6+   $��公共��6F   $��39��6S   $��	15,5,15,0q�6_   #���   6s   5u      	� 5v      $	��1,0q�6   $��Bottom=�6+   $��协同��6F   $��39��6S   $��	15,5,15,0q�6_   #���   6s   5w      	� 5x      $	��1,0q�6   $��Bottom=�6+   $��人事��6F   $��39��6S   $��	15,5,15,0q�6_   #���   6s   + d� 	IsChecked$
+ TrueY�6�   5y      	� 5z      $	��1,0q�6   $��Bottom=�6+   $��经理查询��6F   $��39��6U   $��	15,5,15,0q�6a   #���   6u   5{      	� 5|      $	��1,0q�6   $��Bottom=�6+   $��考勤排班��6F   $��39��6U   $��	15,5,15,0q�6a   #���   6u   5}      	� 5~      $	��1,0q�6   $��Bottom=�6+   $��绩效考核��6F   $��39��6U   $��	15,5,15,0q�6a   #���   6u   5      	� 5�      $	��1,0q�6   $��Bottom=�6+   $��薪资社保��6F   $��39��6U   $��	15,5,15,0q�6a   #���   6u   5�      	� 5�      $	��1,0q�6   $��Bottom=�6+   $��人事分析��6F   $��39��6U   $��	15,5,15,0q�6a   #���   6u   6�   5�      5�      � 5�   
   $��0,0,0,0q�6   $��1��6!   $��0��6/   $��2��6?   }�. ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ 	#FFCAE0DC��6#   $ 0Q�65   � 5�      $ 	#FF5E9B9B��6#   $ 1Q�65   5�      .+�5�      A� $��-124,-106,-129.654,-99q�6   ��5�      
� 5�      $$ 0.502Q�6*   $' 0.502Q�6:   .��5�      � $ 	#B2C9DFDC��6'   $ 0.994Q�69   � 5�      $ 	#B2FFFFFF��6'   $ 0.813Q�69   5�      5�      *   $Ay.Framework.WPF.Controls.AyTreeView  5�      -   5        ,  Name$, 
tvLeftMenu��5�   Y   -   
AyTreeMode$- IconText=�5�   !   !.   FirstAyTreeViewItemPadding$. 0q�68   $��0,15,0,0q�6W   ���#000000$��14(�5�   )   /   SelectedRightSJXOpacity$/ 0Q�68   0   
IconHeight$0 16Q�5�   *   1   	IconWidth$1 18Q�6:   2 $� IsVirtualizing2 .  3   TreeViewItemHeight$3 26Q�5�   W   4   TreeViewAnimationIsOpen4 . ���	#00FFFFFF$��0q�5�   )   ���#FFFFFF$��Center=�6S   $	��154��6p   $��Stretch=�5�   )   5�      5�       � 5�   
   -   5        5  �Name$5 	frameMain��5�      $��1��6$   $��1��64   $��Stretch=�6A   
�������$��Stretch=�5�      6  � NavigationUIVisibility$6 Hidden=�5�      5�      �� 5�   
   -   5        7 ��Name$7 sp_userInfo��5�      $��2��6*   $* 
Horizontal=�67   .+�5�      �� -   5        8 ��Name$8 tb��5�      $��Center=�6$   $��15,0,0,0q�6?   	用户：6V   �� 5�      -   5        $8 tb_user��5�      
���  ��$��Center=�6:   AY君(ayjs.net)6d   5�      � 5�   
   $��1��6   $��Stretch=�6   $��Stretch=�6=   }�. ���#CFE1E1$��2��6�    5�      �� 5�      $��* �6#   �� 5�      $	��180 �6#   �� 5�      $	��154 �6#   .+�5�      �� $* 
Horizontal=�6   $��Center=�62   $��10,0,0,0q�6M   .+�5�      �� $+��%SystemResources/Images/icon/clock.png��6   $��Center=�6G   $��16��6b   $��16��6m   $��Uniform=�6y   �� 5�      $��Center=�6   登录时间：6>   �� 5�      -   5        $8 userLoginTime��5�   7   $��Center=�6   09:506U   �� 5�      $��Center=�6   $��10,0,0,0q�67   在线时间：6P   �� 5�      -	   5        $8 userOnlineTime��5�   7   $��Center=�6   136S   �� 5�      $��Center=�6   分钟6;   5�      �� 5�      $* 
Horizontal=�6   $��Center=�62   $��1��6N   .+�5�      �� $-��'SystemResources/Images/icon/25103_s.png��6   $��Center=�6I   $��16��6d   $��16��6o   $��Uniform=�6{   9 � Cursor$
9 Hand��6�   : � ToolTip$: 	发件箱��6�   �� 5�      $-��'SystemResources/Images/icon/24005_s.png��6   $��Center=�6I   $��16��6d   $��16��6o   $��Uniform=�6{   $
9 Hand��6�   $: 即时沟通��6�   $��5,0,0,0q�6�   �� 5�      $-��'SystemResources/Images/icon/24002_s.png��6   $��Center=�6I   $��16��6d   $��16��6o   $��Uniform=�6{   $
9 Hand��6�   $: 	便笺本��6�   $��5,0,0,0q�6�   �� 5�      $-��'SystemResources/Images/icon/24001_s.png��6   $��Center=�6I   $��16��6d   $��16��6o   $��Uniform=�6{   $
9 Hand��6�   $: 日程事务��6�   $��5,0,0,0q�6�   5�      �� 5�      $* 
Horizontal=�6   $��Center=�62   $��2��6N   .+�5�      �� $.��(SystemResources/Images/icon/mail_new.png��6   $��Center=�6J   $��16��6e   $��16��6p   $��Uniform=�6|   �� 5�      $��Center=�6   
���  ��.��6D   (6G   �� 5�      -
   5        $8 userMessageNumber��5�   7   $��Center=�6   
���  ��06g   �� 5�      $��Center=�6   
���  ��.��6E   )6H   �� 5�      $*��$SystemResources/Images/icon/flow.png��6   $��Center=�6F   $��16��6a   $��16��6l   $��Uniform=�6x   �� 5�      $��Center=�6   
���  ��.��6D   (6G   �� 5�      -   5        $8 
flowNumber��5�   7   $��Center=�6   
���  ��06`   �� 5�      $��Center=�6   
���  ��.��6E   )6H   �� 5�      $.��(SystemResources/Images/icon/Schedule.png��6   $��Center=�6J   $��16��6e   $��16��6p   $��Uniform=�6|   �� 5�      $��Center=�6   
���  ��.��6D   (6G   �� 5�      -   5        $8 ScheduleNumber��5�   7   $��Center=�6   
���  ��06d   �� 5�      $��Center=�6   
���  ��.��6E   )6H   5�      5�      5�      5�      