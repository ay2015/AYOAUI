   M S B A M L   `   `   `  ����@  <OA.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OA.UI.ViewsOA.UI.Views  5      E'clr-namespace:Ay.Framework.WPF.ControlsAy.Framework.WPF.Controls  5      &     OA.UI.Views.EmployeeBaseInfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:OA.UI.Views     5      ;control'clr-namespace:Ay.Framework.WPF.Controls     5        N� Title$  EmployeeBaseInfoPage��5
       � 	Resources 5       "  FormTextBoxBaseControlTemplate �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%P  &	        �� 5   
   " ��6A   .R�5      �� $ border��6   #��z��6%   #��z��6Q   #��z��6�    . ._�5      �� $ PART_ContentHost��6   |�.  $��Hidden=�6K   $��Hidden=�6r   5       5      P� 5       � {� .  . �5      �� $	 border��60   
 �@J�Opacity$
 0.56Q�6D   5      5      5      .��5      � .+�5   
   �� .+�5      � .+�5      �� -   5         ��Name$ 
tb_empName��5      $
��Left=�6`   ��60   �� *	EmpName+ �� StringFormat$ {0}简历信息��6}   �� 5      $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5      �� -   5         ��Name$ saveInfo��5       � Cursor$
 Hand��6/   $��24��6=   $
��10,2q�6I   $��5,0,0,0q�6X   ���#BCBCBC���#4A4A4A  SelectButtonStyle#���  5   )   $��保存��6U   ��5       �� 5!       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5"   "   �  � Color$ White��6/    � Offset$ 0Q�6=   � 5#   "   $ White��6/   $ 1Q�6=   � 5$   "   $ 	#FFF3F3F3��6/   $ 0.495Q�6A   � 5%   "   $ 	#FFFCFCFC��6/   $ 0.044Q�6A   5&      5(      �� 5)      -   5        $ export��5)      $
 Hand��6-   $��24��6;   $
��10,2q�6G   $��5,0,0,0q�6V   ���#BCBCBC���#4A4A4A#���  5*   )   $��导出��6U   ��5+      �� 5,      $ 0.5,1&�62   $ 0.5,0&�6C   .��5-   "   � $ White��6/   $ 0Q�6=   � 5.   "   $ White��6/   $ 1Q�6=   � 5/   "   $ 	#FFF3F3F3��6/   $ 0.495Q�6A   � 50   "   $ 	#FFFCFCFC��6/   $ 0.044Q�6A   51      53      54      56      �� 57        AyGroupboxStyleNormal#���  6     s.main.top.logo.color4#���  6G   $��80��58      #���  6"   ��59      �� 5:      $��基本信息��6    $
��Bold"�6,   5;      .��5=      �  � ColumnDefinitions 5>      �� 5?      $��1* �6+   �� 5@      $
��2.5* �6+   �� 5A      $��16 �6+   �� 5B      $��1* �6+   �� 5C      $
��2.5* �6+   �� 5D      $��16 �6+    � RowDefinitions 5F      �� 5G      $��24 �6(   �� 5H      $��24 �6(   .+�5J      �� -   5        $ 	t_empName��5J       $��姓名: ��63   $��Right=�6?   $��Center=�6[   6x   �� 5K      -   5         ��Name$ empName��5K   l   ���#000000���#D1DBDB$��Normal"�6J    �� 	MaxLength$ 4��6^   $��20��6}   $��Stretch=�6�   $��1��6�   $��Center=�5L   
    �� TextWrapping$ NoWrap=�6&   $
��Left=�6U   $��0,0,0,1q�6x   #���   6�   ��6<   �� *	EmpName+6�   �� 5M      -   5        $ xing_empName��5M       $�� *��66   $
��Left=�6@   $��Center=�6[   
���  ��$��2��6�   6�   �� 5O      -   5        $ t_empSex��5O       $��性别: ��62   $��Right=�6>   $��Center=�6Z   $��3��6u   6�   �� 5P      $ 
Horizontal=�6!   $��4��6:   .+�5Q      	� -   5         	�Name$ rb_male��5Q   �   $	��3,4q�6&   $��24��64   $��Center=�6@   ���#000000$��Normal"�6q    	� 	GroupName$ sexGroup��6�   $	��男��6�   	� 5R      -	   5        $ 	rb_female��5R   �   $	��3,4q�6&   $��24��64   $��Center=�6@   ���#000000$��Normal"�6q   $ sexGroup��6�   $	��女��6�   5S      �� 5T      -
   5        $ xing_empSex��5T       $�� *��65   $
��Left=�6?   $��Center=�6Z   
���  ��$��5��6�   6�   �� 5V      -   5        $ t_empRelation��5V       $��关系: ��67   $��Right=�6C   $��Center=�6_   $��1��6{   6�   �� 5W      $ 
Horizontal=�6!   $��1��6:   $��1��6J   .+�5X      �� -   5         ��Name$ 
onlyZhiShu��5X   w   $	��3,4q�6#   $��24��61   $��0,0,0,0q�6=   ���#000000$��Normal"�6c   $��	仅直属��6�   �� 5Y      -   5        $ 
onlyZhuZhi��5Y   f   $	��3,4q�6#   $��24��61   ���#000000$��Normal"�6R   $��	仅主职��6z   5Z      �� 5[      -   5        $ xing_empRelation��5[   ?   $��1��6!   $��2��6/   $�� *��6Y   $
��Left=�6c   $��Center=�6~   
���  ��6�   �� 5\      -   5        $ t_cboL��5\       $��员工类型: ��60   $��Right=�6>   $��Center=�6Z   $��1��6v   $��3��6�   6�   *   $Ay.Framework.WPF.Controls.AyComboBox  5^      -   5          Name$ cboEmployeeType��5^   X   $��Normal"�6)   $
��Left=�6=   ���#FFFFFF$��1��6�   $��4��6�    �� 
IsEditable .   w� TextPath$ Content��5_      #���  6<   $��Center=�5`   
   $	��100��6%   $��24��61   .@�5a      �� $��--请选择--��6'   $
��Left=�69     �� 
IsSelected  . 6T   �� 5b      $��--正式工--��6'   $
��Left=�69   �� 5c      $��--合同工--��6'   $
��Left=�69   �� 5d      $��--临时工--��6'   $
��Left=�69   �� 5e      $��试用期员工��6'   $
��Left=�67   5f      �� 5g      -   5        $ 	xing_cboL��5g   ?   $��1��6!   $��5��6/   $�� *��6R   $
��Left=�6\   $��Center=�6w   
���  ��6�   5i      5j      �� 5k      #���  6   $��自定义字段��6H   #���  6W   $��80��6�   #���  6�   5m      �� 5n      #���  6   $��附件��6H   #���  6T   $��80��6�   #���  6�   5p      �� 5q      #���  6   $��职位信息��6H   #���  6V   $��80��6�   #���  6�   5s      �� 5t      #���  6   $��联系方式��6H   #���  6V   $��80��6�   #���  6�   5v      �� 5w      #���  6   $��测试滚动条��6H   #���  6W   $	��150��6�   #���  6�   5y      5z      5|      5}      