   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5      U/clr-namespace:SchoolBus.Presentation.ViewModels!SchoolBus.Presentation.ViewModels  5   ;   1    +SchoolBus.Presentation.Views.CreateRideView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      6local*clr-namespace:SchoolBus.Presentation.Views  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1*cmd http://www.galasoft.ch/mvvmlight  5      @
viewmodels/clr-namespace:SchoolBus.Presentation.ViewModels  6;   
�������
���   �$��1q�5
   ^   .��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��4* �6   .+�5   
   �� $��0��6   .+�5      �� $
��Ride��6   
���   �
�������$��25(�6J   $
��Bold"�6X    �� Left$ 49��6k   $��Center=�6|   $	��Top=�6�   
 �� Top$ -1��6�   �� 5      $��
-Car Name:��6   $��20(�6)   $
��Bold"�67   $ 39��6I   $��Center=�6Y   $	��Top=�6v   $ -4��6�   �� 5      $��-Number:��6   $��20(�6'   $
��Bold"�65   $	 102��6H   $��Center=�6Y   $	��Top=�6v   $ -4��6�   �� 5      $��-Seats:��6   $��20(�6&   $
��Bold"�64   $	 157��6G   $��Center=�6X   $	��Top=�6u   $ -3��6�   �� 5      $��-Students 
  count:��6   $��20(�6;   $
��Bold"�6I   $	 195��6\   $��Center=�6m   $	��Top=�6�   $ -4��6�   �� 5      $��20(�6A   $ 65��6O   $
��Left=�6_   $	��Top=�6z   $ 10��6�   ��6   �� *CarOfSelectedDriver.Name+6�   �� 5      $��20(�6C   $	 128��6S   $��Center=�6d   $	��Top=�6�   $ 10��6�    J� RenderTransformOrigin$ 0.633,-0.367&�6�   ��6   �� *CarOfSelectedDriver.Number+6�   �� 5      $��20(�6F   $	 159��6V   $��Center=�6g   $	��Top=�6�   $ 71��6�   $ 0.633,-0.367&�6�   ��6   �� *CarOfSelectedDriver.SeatCount+6�   �� 5      $��20(�68   $	 218��6H   $��Center=�6Y   $	��Top=�6v   $	 108��6�   $ 0.633,-0.367&�6�   ��6   �� *CountOfStudents+6�   �� 5      $ 8��68   $	 305��6H   $��35��6Y   $	��140��6e   
���������6   �� *	Drivers+ �� SelectedItem 6�   �� *SelectedDriver+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ SelectionChanged��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5       /  )GalaSoft.MvvmLight.Command.EventToCommand     PassEventArgsToCommand$
 True��6V   	   Command	 6-   �� *DriverChangedCommand+6V   5!      5#      �� 5%      
���   �
�������$	��Add��6^   $��20(�6l   $
��Bold"�6z   $	��106��6�   $��30��6�   $ 31��6�   $	 394��6�   $
��Left=�6�   $��Center=�6�   ��6   �� *AddRide_Button+6�   5&      � 5(   
   $��1��6   
 � RowDefinitions
 5)      �� 5*      $��* �6    �� 5+      $��* �6    .+�5.      �� $��0��6   .+�50      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�67   $��Center=�6R   $	��635��6m   .+�51      �� $��DemiBold"�6   $��25(�62   $	��159��6@   $��50��6L   $��	FirstName��6X   $��Center=�6l   $��Center=�6�   �� 52      $��DemiBold"�6   $��25(�62   $	��141��6@   $��50��6L   $��LastName��6X   $��Center=�6k   $��Center=�6�   �� 53      $��DemiBold"�6   $��25(�62   $	��116��6@   $��50��6L   $��Parent��6X   $��Center=�6i   $��Center=�6�   �� 54      $��DemiBold"�6   $��25(�62   $	��116��6@   $��50��6L   $��Class��6X   $��Center=�6h   $��Center=�6�   �� 55      $	��100��6<   $��35��6H   
���   �
�������$	��Add��6z   $��20(�6�   $
��Bold"�6�   $��0q�6�   ��6   �� *
Add_Button+6�   56      �� 58      $	��635��6e   $	��175��6q   $
��Left=�6   $��Center=�6�   $ 50��6�   $��0q�6�   
���   � 6   �� *SelectedStudent1+��6D   �� *
Students+��59      �� 5:      .R�5;      �   5<   "   �� 5=   &   $	��135 �67   �� 5>   &   $	��135 �67   �� 5?   &   $	��135 �67   �� 5@   &   $	��135 �67   .+�5C   "   �� $��0��6,   $��16(�6W   $��Center=�6e   $��Center=�6�    �� TextAlignment$ Center=�6�   ��6<   �� *	FirstName+6�   �� 5D   "   $��1��6,   $��16(�6V   $��Center=�6d   $��Center=�6   ��6<   �� *
LastName+6   �� 5E   "   $��2��6,   $��16(�6^   $��Center=�6l   $��Center=�6�   ��6<   �� *Parent.FirstName+6�   �� 5F   "   $��3��6,   $��16(�6X   $��Center=�6f   $��Center=�6�   ��6<   �� *
Class.Name+6�   5G      5H      5J      5K      �� 5M      $��1��6   .+�5N      �� $ 
Horizontal=�6   $
��Left=�69   $��Center=�6T   $	��635��6o   .+�5O      �� $��DemiBold"�6   $��25(�62   $	��159��6@   $��50��6L   $��	FirstName��6X   $��Center=�6l   $��Center=�6�   �� 5P      $��DemiBold"�6   $��25(�62   $	��141��6@   $��50��6L   $��LastName��6X   $��Center=�6k   $��Center=�6�   �� 5Q      $��DemiBold"�6   $��25(�62   $	��116��6@   $��50��6L   $��Parent��6X   $��Center=�6i   $��Center=�6�   �� 5R      $��DemiBold"�6   $��25(�62   $	��116��6@   $��50��6L   $��Class��6X   $��Center=�6h   $��Center=�6�   �� 5S      $	��100��6?   $��35��6K   
���   �
�������$��Remove��6}   $��20(�6�   $
��Bold"�6�   $��0q�6�   ��6   �� *Remove_Button+6�   5T      �� 5V      $	��635��6n   $	��175��6z   $
��Left=�6�   $��Center=�6�   $ 50��6�   
���   �$��0q�6�    6   �� *SelectedStudent2+��6E   �� *StudentsToRemove+��5W      �� 5X      .R�5Y      �   5Z   "   �� 5[   &   $	��135 �67   �� 5\   &   $	��135 �67   �� 5]   &   $	��135 �67   �� 5^   &   $	��135 �67   .+�5a   "   �� $��0��6,   $��16(�6W   $��Center=�6e   $��Center=�6�   $ Center=�6�   ��6<   �� *	FirstName+6�   �� 5b   "   $��1��6,   $��16(�6V   $��Center=�6d   $��Center=�6   ��6<   �� *
LastName+6   �� 5c   "   $��2��6,   $��16(�6^   $��Center=�6l   $��Center=�6�   ��6<   �� *Parent.FirstName+6�   �� 5d   "   $��3��6,   $��16(�6X   $��Center=�6f   $��Center=�6�   ��6<   �� *
Class.Name+6�   5e      5f      5h      5i      5j      5k      5l      