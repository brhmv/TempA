   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5      *    $SchoolBus.Presentation.Views.CarView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:SchoolBus.Presentation.Views     5      .��5	      �� .+�5
   
   ��   �� Orientation$  
Horizontal=�6   $��Center=�6.   $	��337��6K    �� Left$	 241��6W   
 �� Top$	 378��6i   $	��Top=�6z   .+�5      �� 
�������$	��100��6H   $��50��6T   $	��Add��6`   $��0q�6n   $��26(�6�   $
��Bold"�6�   
���   ���6   �� *
Add_Button+6�   �� 5      
�������$	��100��6J   $��50��6V   $��Delete��6b   $��0q�6s   $��26(�6�   $
��Bold"�6�   
���   �$��10,0,0,0q�6�   ��6   �� *Delete_Button+6�   �� 5      
�������$	��100��6J   $��50��6V   $��Update��6b   $��0q�6s   $��26(�6�   $
��Bold"�6�   
���   �$��10,0,0,0q�6�   ��6   �� *Update_Button+6�   5      �� 5   
   $��1��6   $ 63��6"   $ 15��63   $  
Horizontal=�6C   $��Center=�6^   $	��Top=�6{   $	��674��6�   .+�5      �� $��10,0,0,0q�6   $��DemiBold"�6'   $��25(�6=   $	��100��6K   $��50��6W   $��Id��6c   $��Center=�6p   $��Center=�6�   �� 5      $��10,0,0,0q�6   $��DemiBold"�6'   $��25(�6=   $	��232��6K   $��50��6W   $��Car Name��6c   $��Center=�6v   $��Center=�6�   �� 5      $��DemiBold"�6   $��25(�6+   $	��155��69   $��50��6E   $��Number��6Q   $��Center=�6b   $��Center=�6�   �� 5      $��DemiBold"�6   $��25(�6+   $	��178��69   $��50��6E   $��
Seat Count��6Q   $��Center=�6f   $��Center=�6�   5      �� 5   
   $��2��6   $	��300��6   $ 66��6,   
���   �
�������$
��True��6b   $	��Top=�6�   $ 63��6�   $��Center=�6�   $	��674��6  $��0q�6d  ��6�   �� *Cars+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6  �� *SelectedCar+$ PropertyChanged=���5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��100 �6/   �� 5      $	��300 �6/   �� 5      $	��110 �6/   �� 5      $	��130 �6/   .+�5"      �� $��0��6$   $��16(�6H   $��Center=�6V   $��Center=�6q    �� TextAlignment$ Center=�6�   ��64   �� *Id+6�   �� 5#      $��1��6$   $��16(�6J   $��Center=�6X   $��Center=�6s   $ Center=�6�   ��64   �� *Name+6�   �� 5$      $��2��6$   $��16(�6L   $��Center=�6Z   $��Center=�6u   ��64   �� *Number+6u   �� 5%      $��3��6$   $��16(�6O   $��Center=�6]   $��Center=�6x   ��64   �� *	SeatCount+6x   5&      5'      5)      5*      5+      