   M S B A M L   `   `   `  ����F  BCarGoNowApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarGoNowAppCarGoNowApp  5   	   !    CarGoNowApp.EmpolyeeProfile   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CarGoNowApp     5   	     � Title$  EmployeeProfile��5      $	��600��60   $
��1200��6=   $	��600��5	   	   $
��1200��6   .��5      � $	��950��6   $	��550��6   .+�5   
   � $��105,-15,-125,-15q�6   ��5      �� 5       �� ImageSource$ \Resources\car2.jpg��6    �� Opacity$	 0.3Q�6?   .+�5      �� -   5         ��Name$ contentControl��5      5      � 5   
   ���	#FFEEEDEF$��-125,-15,845,-15q�6&   .+�5      �� $
��Left=�6   $��80��6/   $��5,5,0,0q�6;   $	��Top=�6L   $	��200��6d   $��\Resources\logo.png��6p   �� 5      -   5         ��Name$ manage_bill_btn��5      $��3,372,0,155q�6.   ���	#FFEEEDEF��6Z   Z� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��\Resources\bill.ico��6   $��64��69   $��47��6D    J� RenderTransformOrigin$ 0.158,0.637&�6P   �� 5      $��Bills��6    $��Center=�6-   $
��Bold"�6H   $��18(�6Z   $	��127��6h   5      5      �� 5      -   5        $ manage_rs_btn��5      $��0,302,0,225q�6,   ���	#FFEEEDEF$��Right=�6�   $	��228��6�   ��6X   Z� .��5      �� $ 
Horizontal=�6   .+�5      �� $ ��\Resources\reservation.ico��6   $��59��6@   $��52��6K   $��0,0,5,0q�6W   �� 5       $��Reservations��6    $��Center=�64   $
��Bold"�6O   $��18(�6a   $	��121��6o   5!      5"      �� 5#      -   5        $ manage_cu_btn��5#      $��0,235,0,292q�6,   ���	#FFEEEDEF$��Right=�6�   $	��230��6�   ��6X   Z� .��5$      �� $ 
Horizontal=�6   .+�5%      �� $��\Resources\clients.ico��6   $��64��6<   $��48��6G   $��0,0,5,0q�6S   �� 5&      $��Clients��6    $��Center=�6/   $
��Bold"�6J   $��18(�6\   $	��110��6j   5'      5(      �� 5)      -   5        $ manage_car_btn��5)      $��0,164,0,363q�6-   ���	#FFEEEDEF$��Right=�6�   $	��230��6�   ��6Y   Z� .��5*      �� $ 
Horizontal=�6   .+�5+      �� $��\Resources\car.ico��6   $��61��68   $��36��6C   $��0,0,5,0q�6O   $ 
0.08,0.498&�6`   �� 5,      $
��Cars��6    $��Center=�6,   $
��Bold"�6G   $��18(�6Y   $	��116��6g   5-      5.      �� 5/      -   5        $ manage_settings_btn��5/      $��
0,442,0,85q�62   ���	#FFEEEDEF$��Right=�6�   $	��228��6�   ��6]   Z� .��50      �� $ 
Horizontal=�6   .+�51      �� $��\Resources\settings.ico��6   $��55��6=   $��42��6H   $��0,0,5,0q�6T   �� 52      $��Settings��6    $��Center=�60   $
��Bold"�6K   $��18(�6]   $	��115��6k   53      54      �� 55      -   5        $ signout_btn��55      $��
0,505,2,22q�6*   ���	#FFEEEDEF$��Right=�6�   $	��228��6�   ��6U   Z� .��56      �� $ 
Horizontal=�6   .+�57      �� $��\Resources\logout.ico��6   $��58��6;   $��41��6F   $��0,0,5,0q�6R   �� 58      $��Sign Out��6    $��Center=�60   $
��Bold"�6K   $��18(�6]   $	��115��6k   59      5:      5<      5=      5>      