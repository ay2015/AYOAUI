   M S B A M L   `   `   `  ����@  <OA.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Ay.Framework.WPF.ControlsAy.Framework.WPF.Controls  5   	   )clr-namespace:OA.UI.ViewsOA.UI.Views  5   	        OA.UI.Views.AyExportWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;control'clr-namespace:Ay.Framework.WPF.Controls     5   	   +localclr-namespace:OA.UI.Views     5   	   (   "Ay.Framework.WPF.Controls.AyWindow    TitleBarHeight$  32Q�61    � Title$ 员工信息导出��5	   	   $	��400��6   $	��855��6%    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�5
         MaxButtonVisibility$ 	Collapsed=�68      SkinButtonVisibility$ 	Collapsed=�6X      MinButtonVisibility$ 	Collapsed=�6y   .��5      � $��	0,-32,0,0q�6   
�������.+�5   
   ]� ��. .+�5      �� -   5         ��Name$ title��5      $��32��6$   $	��Top=�60      s.main.top.color5#���   6E   5      � 5      $��
15,20,20,0q�6   .+�5      �� -   5         ��Name$ 
tabControl��5        AyTabControl#���  61   $	��300��6Y   $	��Top=�6f   .@�5      �� $��导出设置��6   	 �� 
IsSelected	 . $
��Bold"�6>   .��5      � 
 � ColumnDefinitions
 5      �� 5   "   $	��140 �63   6A   �� 5   "   $��* �63   6?    � RowDefinitions 5      �� 5   "   $	��140 �60   6?   �� 5   "   $��* �60   6=   .+�5      �� $��模板:��6(   ���#000$��0,0,25,0q�6E   $��Right=�6W   $��Center=�6s   $��Normal"�6�   6�   *   $Ay.Framework.WPF.Controls.AyComboBox  5      -   5          Name$ cboEmployeeIdentity��5   �   $��1��61   $��Normal"�6A   $
��Left=�6U   $��Center=�6p   ���#FFFFFF �� 
IsEditable .   w� TextPath$ Content��5        s.main.top.logo.color4#���  6<   $��85��5      $��24��6   .@�5   "   �� $��--请选择--��6/   $
��Left=�6A    �� 
IsSelected . 6\   �� 5    "   $��标准模板��6/   $
��Left=�6>   5!      5#      5$      5%      �� 5&      -   5         ��Name$ toolBar_btn��5&   K   $��0,0,-6,0q�6   $��Right=�6/    �� Orientation$ 
Horizontal=�6`   $��24��6y   $	��Top=�6�   .+�5'      �� -   5         ��Name$
 btn1��5'      $��24��6+   $
��10,2q�67   $��0,0,6,0q�6F     TabRightButtonStyle#���  6W   $��确定��6�   �� 5(      -   5        $
 btn2��5(      $��24��6+   $
��10,2q�67   $��0,0,6,0q�6F   #���  6W   $��取消��6�   5)      5*      5+      5,      5-      