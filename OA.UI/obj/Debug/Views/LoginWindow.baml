   M S B A M L   `   `   `  ����@  <OA.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Ay.Framework.WPF.ControlsAy.Framework.WPF.Controls  5      )clr-namespace:OA.UI.ViewsOA.UI.Views  5   	       OA.UI.Views.LoginWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;control'clr-namespace:Ay.Framework.WPF.Controls     5      +localclr-namespace:OA.UI.Views     5   	     � Title$   ��5	   	   $	��476��6   $	��948��6    � 
ResizeMode$ NoResize=�6,    � WindowStartupLocation$ CenterScreen=�5
      (   "Ay.Framework.WPF.Controls.AyWindow   SkinButtonVisibility$ 	Collapsed=�68      MaxButtonVisibility$ 	Collapsed=�6Y      MinButtonVisibility$ 	Collapsed=�6y      CloseButtonVisibility$ 	Collapsed=�6�    � 	Resources 5         LoginButton.Static.Brush  LoginButton.Hover.Brush  LoginButton.Peessed.Brush ! LoginOtherButton.Static.Brush   LoginOtherButton.Hover.Brush " LoginOtherButton.Peessed.Brush  LoginButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name J� SnapsToDevicePixels'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration   GeneratedEasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9	  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value ��Name �� ContentStringFormat �� ContentStringFormat  LoginOtherButton��%Z  &	        &	 !     &	 @     &	 _     &	 �     &	 �     &	 �     7  7  &	 ]    7  7  ��5   
   	#FFFCB944��6=   ��5   
   #FFCC00��6:   ��5   
   #D5AD0C��6;   ��5   
   	#99FFFFFF��6B   ��5   
   #FFFFFF��6?   ��5   
   	#B2FFFFFF��6B   �� 5   
   " ��6)   .�5      �� 	 �@�FocusVisualStyle
 61   Z� �� 5      	 � ��
 �#D5E6F06+   �� 5      	 � ��
 �	#FF7070706,   �� 5      	 � ��
 �#FFFFFF6+   �� 5      	 � ��$
 1q�60   �� 5      	 � ��$
 Center=�6;   �� 5      	 � ��$
 Center=�69   �� 5      	 � ��$
 1q�6(   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5       �� $ border��6!   $��0q�62    . ���	#FFFCB944 5!        5"   "   CommonStates�� 5#   &     5$   *   $ 0:0:0.3D�6;    5%   .     5&   2   $ EaseOut=�6=   5(   +   . 5*   &     
Normal��62     5+   &   	MouseOver��. 5,   *   �� .��5-   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ border��6�   .g�5.   2     $ 0��6F   8   6R   5/   /   50   +   51   '     52   &   Pressed��. 53   *   �� .��54   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ border��6�   .g�55   2     $ 0��6F   8  6R   56   /   57   +   58   '     59   &   Disabled��. 5:   *   �� .��5;   .   U� $ (UIElement.Opacity)�6L   $ border��6|   .\�5<   2   	  $ 0��6G   $	 0.5Q�6S   5=   /   5>   +   5?   '   5@   #   ._�5C      �� $ contentPresenter��6/   #��z��6I   #��z��6}   # z 6�   |�.  #��z��6�   #��z��62  ��. # z 6p  #��z��6�  5D      5F      5H      5I      �� 5J   
   " ��6)   .�5K      �� 	 �@�FocusVisualStyle
 61   Z� �� 5L      	 � ��
 �	#FFDDDDDD6+   �� 5M      	 � ��
 �	#FF7070706,   �� 5N      	 � ��
 �#5891916+   �� 5O      	 � ��$
 1q�60   �� 5P      	 � ��$
 Center=�6;   �� 5Q      	 � ��$
 Center=�69   �� 5R      	 � ��$
 1q�6(   �� 5S      	 � ��
 5T      �� 5U      " ��6&   .R�5V      �� $ border��6!   $��0q�62    . ���#D5E6F0 5W        5X   "   CommonStates�� 5Y   &     5Z   *   $ 0:0:0.3D�6;    5[   .     5\   2   $ EaseOut=�6=   5^   +   . 5`   &     
Normal��62     5a   &   	MouseOver��. 5b   *   �� .��5c   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ border��6�   .g�5d   2     $ 0��6F   8   6R   5e   /   5f   +   5g   '     5h   &   Pressed��. 5i   *   �� .��5j   .   �� $0 *(Panel.Background).(SolidColorBrush.Color)�6K   $ border��6�   .g�5k   2     $ 0��6F   8  6R   5l   /   5m   +   5n   '     5o   &   Disabled��. 5p   *   �� .��5q   .   U� $ (UIElement.Opacity)�6L   $ border��6|   .\�5r   2   	  $ 0��6G   $	 0.5Q�6S   5s   /   5t   +   5u   '   5v   #   ._�5y      �� $ contentPresenter��6/   #��z��6I   #��z��6}   # z 6�   |�.  #��z��6�   #��z��62  ��. # z 6p  #��z��6�  5z      5|      5~      5      5�      .��5�      � $��	0,-24,0,0q�6   ��5�   
   �� 5�       �� ImageSource$4 ./OA.UI;component/SystemResources/Images/u0.png��6   .+�5�   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   $��	0,11,10,0q�6b   .+�5�      -
   'Ay.Framework.WPF.Controls.AyImageButton
  -   5          
 Name$  btnMinWindow��5�   ?   -   'Ay.Framework.WPF.Controls.AyImageButton!   Click$! btnMinWindow_Click��6$   $��0,0,0,0q�6U   " 
  
RenderMode$" HorizonFour=�5�      $��25��6*   $��21��65   # 
  Icon$6# 0/OA.UI;component/SystemResources/Images/minW.png��6A   
  5�      -   5        $  btnCloseWindow��5�   A   $! btnCloseWindow_Click��6$   $��0,0,0,0q�6Y   $" HorizonFour=�5�      $��25��6*   $��21��65   $7# 1/OA.UI;component/SystemResources/Images/exits.png��6A   5�      �� 5�   
   .+�5�      �� $5��//OA.UI;component/SystemResources/Images/u21.png��6   $ �� Left$$ 30��6M   
% �� Top$% 31��6^   $��Uniform=�6n   �� 5�      $4��./OA.UI;component/SystemResources/Images/u4.png��6   $	$ 358��6L   $% 39��6^   $��Uniform=�6n   �� 5�      $��24(�6   $��	新宋体)�6&   $	$ 435��67   $% 60��6I   
�������AY人事管理信息系统6x   �� 5�      -   5        & ��Name$& wrongTip��5�   m   $��12(�6   $��	新宋体)�6&   $	$ 358��67   $	% 146��6I   
�������请输入用户名和密码6�   )   #Ay.Framework.WPF.Controls.AyTextBox  5�      -   5        '  Name$' 
tb_EmpName��5�   7   ���#ABADB3$��34��6K   
�������$	$ 358��6j   ( �� TextWrapping$( NoWrap=�5�       $�� ��66   )   Mask$) 	用户名��6>   $	% 183��6I   $	��239��6Z   $��Center=�6f   .��6�   5�      G� 5�      -   5        $��pb��5�      $��34��6%   $	% 240��61   $	��239��6B   $	$ 358��6N   $��Center=�6`   $��0q�6�   $��5,0,0,0q�6�   * J� OpacityMask* 5�      �� 5�      + �� EndPoint$+ 0.5,1&�6*   , �� 
StartPoint$, 0.5,0&�6;   .��5�      � - � Color$- Black��6'   . � Offset$. 1Q�65   � 5�      $- White��6'   $. 0.019Q�65   5�      ��5�      �� 5�      " G�6   .�5�      �� 	 � ��$
 23��63   6@   �� 5�      	 � ��$

 Left=�6@   6O   �� 5�      	 � ��$	
 Top=�6>   6L   �� 5�      2   ,Ay.Framework.WPF.Controls.PasswordBoxMonitor	 �@ IsMonitoring
 . 6U   �� 5�      	 � ��
 5�      �� 5�   "   " G�62   .R�5�   &   �� $��Bd��6-   #��z��68   #��z��6c   #��z��5�       . ._�5�   *   � .+�5�   .   �� / ��Name$/ PART_ContentHost��6;   # z 6U   �� 5�   .   $��myStackPanel��6i   $ 
Horizontal=�69   $y�	Collapsed=�6R   .+�5�   2   �� $
��Left=�6<   $��12(�6W   $��Center=�6e   ���#AAAAAA$��密码��6�   $��10,0,0,0q�6�   5�   /   5�   +   5�   '   0 �� Triggers0 5�   &   P� 5�   *   1 P� Property1 � {�2 P� Value2 .  . �5�   .   �� 3 �� 
TargetName$3 myStackPanel��6K   	 � y�$
 	Collapsed=�6e   5�   +   P� 5�   *   1 �@ PasswordLength$2 0��6g   . �5�   .   �� $3 myStackPanel��6K   	 � y�$
 Visible=�6e   5�   +   5�   #   5�      5�      5�      �� 5�      -   5        4 ��Name$4 btnLogin��5�   #   5 � Cursor$
5 Hand��6   $��	登   录��65   $	$ 358��6\   $��18(�6n   $	% 321��6|   #���  6�   $	��239��6�   $��41��6�   F� 5�      �����fS&@t*��fS&�s�	$��290.054��6.   $	$ 638��6?   6 �� Stretch$
6 Fill=�6Q   
�������$	% 127��6o   $��3��6�   
�������$��3��6�   * 5�      
� 5�      .��5�      � $- Black��6'   � 5�      $. 1Q�6'   5�      5�      �� 5�      -   5        $4 	btnRenShi��5�   #   $
5 Hand��6   $��人事信息管理��66   $$ 682.011��6G   $��14(�6]   $	% 156��6k   #��[ 6|   $��185.989��6�   $��40��6�   �� 5�      -   5        $4 btnRenShi_Copy��5�   #   $
5 Hand��6   $��人事信息管理��6;   $$ 682.011��6L   $��14(�6b   $	% 216��6p   #��[ 6�   $��185.989��6�   $��40��6�   �� 5�      -	   5        $4 btnRenShi_Copy1��5�   #   $
5 Hand��6   $��人事信息管理��6<   $$ 682.011��6M   $��14(�6c   $	% 278��6q   #��[ 6�   $��185.989��6�   $��40��6�   5�      5�      5�      