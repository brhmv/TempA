   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5   	   1    +SchoolBus.Presentation.Views.StudentAddView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SchoolBus.Presentation.Views     5   	     � Title$  StudentAddView��5   	   $	��400��6    $	��600��6-    � WindowStartupLocation$ CenterScreen=�6:   
�������.��5	      �� .+�5
   
   �� $��20(�6   $
��Bold"�6   $��	FirstName��60   $
��Left=�6D    �� Left$ 44��6_   $	��Top=�6p   
 �� Top$ 7��6�   �� 5   
   $��20(�6   $��30��6F   $	��200��6R   $ 10��6^   $ 44��6o   $
��Left=�6   $	��Top=�6�   ��6    �� *NewStudent.FirstName+6�   �� 5   
   $��20(�6   $
��Bold"�6   $��LastName��60   $	 416��6C   $
��Left=�6U   $��Center=�6p   $ 5��6�   �� 5   
   $��20(�6   $
��Bold"�6   $�� ��60   $	 313��6;   $	 125��6M   $��Center=�6^   $	��Top=�6{   �� 5   
   $��20(�6   $
��Bold"�6   $��Class
��60   $	 122��6J   $	 141��6\   $��Center=�6m   $	��Top=�6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Parent
��60   $	 407��6F   $	 139��6X   $��Center=�6i   $	��Top=�6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Address
��60   $	 258��6G   $ 64��6Y   $
��Left=�6i   $	��Top=�6�   �� 5   
   $��20(�6   $��30��6E   $	��200��6Q   $	 380��6]   $ 42��6o   $
��Left=�6   $��Center=�6�   ��6    �� *NewStudent.LastName+6�   �� 5   
   $��20(�6   $��30��6D   $	��200��6P   $	 201��6\   $	 103��6n   $��Center=�6   $	��Top=�6�   ��6    �� *NewStudent.Address+6�   �� 5   
   $	��250��69   $	��100��6E   $ 32��6R   $	 227��6c   $��Center=�6�   $	��Top=�6�    �� SelectedItem 6   �� *SelectedClass+��6t   �� *	Classes+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��120 �6/   �� 5      $	��120 �6/   .+�5      �� $��0��6$   $��16(�6H   $��Center=�6V   $��Center=�6q    �� TextAlignment$ Center=�6�   ��64   �� *Id+6�   �� 5      $��1��6$   $��16(�6J   $��Center=�6X   $��Center=�6s   ��64   �� *Name+6s   5      5       5"      �� 5$   
   $	��250��6:   $	��100��6F   $	 318��6S   $	 227��6e   $��Center=�6�   $	��Top=�6�    6   �� *SelectedParent+��6v   �� *	Parents+��5%      �� 5&      .R�5'      �  5(      �� 5)      $	��120 �6/   �� 5*      $	��120 �6/   .+�5,      �� $��0��6$   $��16(�6O   $��Center=�6]   $��Center=�6x   $ Center=�6�   ��64   �� *	FirstName+6�   �� 5-      $��1��6$   $��16(�6N   $��Center=�6\   $��Center=�6w   ��64   �� *
LastName+6w   5.      5/      51      �� 53   
   $ 33��6   $	 179��6'    �� Orientation$ 
Horizontal=�68   
���   �$��Center=�6e   $	��Top=�6�   $	��250��6�   .+�54      �� $��DemiBold"�6   $��25(�6*   $	��106��68   $��50��6D   
�������$��Id��6c   $��Center=�6p   $��Center=�6�   �� 55      $��DemiBold"�6   $��25(�6*   $	��116��68   $��50��6D   
�������$
��Name��6c   $��Center=�6r   $��Center=�6�   56      �� 58   
   $	 318��6   $	 177��6(   $ 
Horizontal=�69   
���   �$��Center=�6f   $	��Top=�6�   $	��250��6�   .+�59      �� $��DemiBold"�6   $��25(�6*   $	��117��68   $��50��6D   
�������$
��Name��6c   $��Center=�6r   $��Center=�6�   �� 5:      $��DemiBold"�6   $��25(�6*   $	��144��68   $��50��6D   
�������$��LastName��6c   $��Center=�6v   $��Center=�6�   5;      �� 5=   
   
���   �
�������$	��Add��6V   $��20(�6d   $
��Bold"�6r   $	��106��6�   $��30��6�   $	 248��6�   $	 338��6�   $��Center=�6�   $	��Top=�6�   ��6   �� *
Add_Button+6�   5>      5?      