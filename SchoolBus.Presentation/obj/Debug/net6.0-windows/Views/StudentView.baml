   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5      .    (SchoolBus.Presentation.Views.StudentView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:SchoolBus.Presentation.Views     5      .��5	      �� .+�5
   
   ��   �� Orientation$  
Horizontal=�6   $
��Left=�6.   $	��319��6I    �� Left$	 289��6U   
 �� Top$ 10��6g   $��Center=�6w   .+�5      �� $	��100��67   $��50��6C   $	��Add��6O   $��0q�6]   $��26(�6q   $
��Bold"�6   
���   �
���������6   �� *
Add_Button+6�   �� 5      $	��100��67   $��50��6C   $��Delete��6O   $��0q�6`   $��26(�6t   $
��Bold"�6�   
���   �
�������$��10,0,0,0q�6�   ��6   �� *Delete_Button+6�   5      �� 5   
   $��1��6   $ 63��6"   $ 73��63   $  
Horizontal=�6C   $��Center=�6]   $	��Top=�6z   $	��674��6�   .+�5      �� $��DemiBold"�6   $��25(�6*   $	��106��68   $��50��6D   $��Id��6P   $��Center=�6]   $��Center=�6�   �� 5      $��10,0,0,0q�6   $��DemiBold"�6&   $��25(�6<   $	��141��6J   $��50��6V   $��	FirstName��6b   $��Center=�6v   $��Center=�6�   �� 5      $��DemiBold"�6   $��25(�6*   $	��145��68   $��50��6D   $��LastName��6P   $��Center=�6c   $��Center=�6�   �� 5      $��DemiBold"�6   $��25(�6*   $	��137��68   $��50��6D   $��Parent��6P   $��Center=�6a   $��Center=�6�   �� 5      $��DemiBold"�6   $��25(�6*   $	��111��68   $��50��6D   $��Class��6P   $��Center=�6`   $��Center=�6�   5      �� 5   
   $��2��6   $	��674��6   $	��300��6+   $	 124��68   
���   �
�������$
��True��6o   $	��Top=�6�   $ 63��6  $��Center=�6+  ��6�   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedStudent+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��135 �6/   �� 5      $	��135 �6/   �� 5      $	��135 �6/   �� 5      $	��135 �6/   �� 5       $	��135 �6/   .+�5#      �� $��0��6$   $��16(�6H   $��Center=�6V   $��Center=�6q   ��64   �� *Id+6q   �� 5$      $��1��6$   $��16(�6O   $��Center=�6]   $��Center=�6x    �� TextAlignment$ Center=�6�   ��64   �� *	FirstName+6�   �� 5%      $��2��6$   $��16(�6N   $��Center=�6\   $��Center=�6w   ��64   �� *
LastName+6w   �� 5&      $��3��6$   $��16(�6V   $��Center=�6d   $��Center=�6   ��64   �� *Parent.FirstName+6   �� 5'      $��4��6$   $��16(�6P   $��Center=�6^   $��Center=�6y   ��64   �� *
Class.Name+6y   5(      5)      5+      5,      5-      