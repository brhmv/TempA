   M S B A M L   `   `   `  ����Q  MSchoolBus.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBus.Presentation.ViewsSchoolBus.Presentation.Views  5   	   -    'SchoolBus.Presentation.Views.CarAddView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SchoolBus.Presentation.Views     5   	     � Title$  
AddCarView��5      $	��450��5   	   $	��800��5	   	   
�������.��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   �� 
���   �$��0��6#   $��Center=�60   $��Center=�6K   $��50(�6h   $��
ExtraBlack"�6v   $��Normal$�6�   .��6�   	Add Car6�   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6?   .+�5      �� 
���   �.��6'   	Car Model62   �� 5      -   5        $��Name_txt��5      $	��450��6C   $��20(�6O   
���������6&   �� *NewCar.Name+6q   �� 5      
���   �.��6'   
Seat Count63   �� 5      -   5        $��SeatCount_txt��5      $	��450��6N   $��20(�6Z   
���������6+   �� *NewCar.SeatCount+6|   �� 5      
���   �.��6'   Seria No of the Car6<   �� 5       -   5        $��SeriaNo_txt��5       $	��450��6H   $��20(�6T   
���������6)   �� *NewCar.Number+6v   5"      �� 5$   
   $��2��6   $	��250��6   
���   �
���������6*   �� *
Add_Button+.��6o   Save6u   5%      5'      