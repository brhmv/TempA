   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5   	   -    'SchoolBus.Presentation.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SchoolBus.Presentation.Views     5   	     � Title$  	SchoolBus��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��500��6A   $	��900��6N   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��8* �6   .+�5   
   �� .+�5      �� 
���   �
�������$��15(�6a   $��Create Ride��6o   $
��Bold"�6�   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *CreateRideCommand+6�   �� 5      
���   �
�������$��15(�6[   $��Rides��6i   $
��Bold"�6y   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *RideCommand+6�   �� 5      
���   �
�������$��15(�6\   $��Class��6j   $
��Bold"�6z   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *ClassCommand+6�   �� 5      
���   �
�������$��15(�6^   $��Student��6l   $
��Bold"�6~   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *StudentCommand+6�   �� 5      
���   �
�������$��15(�6^   $��Parent��6l   $
��Bold"�6}   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *ParentCommand+6�   �� 5      
���   �
�������$��15(�6]   $��Driver��6k   $
��Bold"�6|   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *DriverCommand+6�   �� 5      
���   �
�������$��15(�6Z   $	��Car��6h   $
��Bold"�6v   $��30��6�   $��	0,10,0,10q�6�   $��0q�6�   ��6   �� *
CarCommand+6�   5      �� 5   
   $��1��6   ��6*   �� *CurrentViewModel+6Q   5      5      