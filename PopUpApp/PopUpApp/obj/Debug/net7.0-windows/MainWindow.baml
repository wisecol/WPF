   M S B A M L   `   `   `  ����C  ?PopUpApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PopUpAppPopUpApp  5   	       PopUpApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PopUpApp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1080��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o   
������� � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5       �� #��[ 6   5!      .��5%      � 
�������.+�5'   
   � -   5         �Name$ GridMain��5'      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1020��6e   � 5(   
   $��60��6   $	��Top=�6   ���	#FF5C99D6.+�5)      �� $��Design com WPF��6   $��Center=�6.   $��Center=�6K   $��22(�6f   �� 5*      $
��Noah��6   $��Center=�6$   $��16(�6?   �� 5+      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5,      �� $��Noah Seo��6   $��Center=�6,   $��16(�6G   '  !MaterialDesignThemes.Wpf.PopupBox  5-      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen$ False��6`      PopupContent. 5.      �� $	��150��6!   .+�5/      �� $��Account��6!   �� 50      $��Settings��6!   �� 51      $
��Help��6!   �� 52      �� 53      -   5         ��Name$ BtnPopUpLogout��53   !   $��Logout��69   6J   54      55      56      57      � 59   
   -   5        $ GridMenu��59      $��60��6!   $
��Left=�6,   ���	#FF31577E.+�5;      �� .+�5<      � $	��150��6   
�������.+�5=      �� -   5        $ ButtonCloseMenu��5=      $��60��66   $��60��6A   $	��Top=�6z   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5>      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF31577E   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5?      �� 5@      -   5        $ ButtonOpenMenu��5@      $��60��65   $��60��6@   $	��Top=�6y   $��Right=�6�   ��6L   Z� ��6b   Z� .��5A        ���	#FF31577E$
 Menu=�6I   $��25��6U   $��25��6`   5B      5C      �� 5F      -   5        ���	#FF5C99D6$��Hidden=�5F   2   .@�5G      �� -   5         ��Name$ ItmHome��5G   #   $��60��64   .��5H      �� $ 
Horizontal=�6%   .+�5I        $ ViewDashboard=�66   $��25��6K   $��25��6V   $��10q�6b   $��Center=�6n   �� 5J      $
��Home��6(   $��Center=�64   $��20 10q�6O   5K      5L      �� 5M      -   5        $ 	ItmCreate��5M   #   $��60��66   .��5N      �� $ 
Horizontal=�6%   .+�5O        $ Pencil=�66   $��25��6D   $��25��6O   $��10q�6[   $��Center=�6g   �� 5P      $��Create��6(   $��Center=�66   $��20 10q�6Q   5Q      5R      �� 5S      -	   5        $ 
ItmTickets��5S   $   $��60��68   .��5T      �� $ 
Horizontal=�6%   .+�5U        $ Ticket=�66   $��25��6D   $��25��6O   $��10q�6[   $��Center=�6g   �� 5V      $��Tickets��6(   $��Center=�67   $��20 10q�6R   5W      5X      �� 5Y      -
   5        $ 
ItmMessage��5Y   $   $��60��68   .��5Z      �� $ 
Horizontal=�6%   .+�5[        $ Message=�66   $��25��6E   $��25��6P   $��10q�6\   $��Center=�6h   �� 5\      $��Message��6(   $��Center=�67   $��20 10q�6R   5]      5^      �� 5_      -   5        $ 	ItmGitHub��5_   $   $��60��67   .��5`      �� $ 
Horizontal=�6%   .+�5a        $ Github=�66   $��25��6D   $��25��6O   $��10q�6[   $��Center=�6g   �� 5b      $��GitHub��6(   $��Center=�66   $��20 10q�6Q   5c      5d      5e      5f      5g      5h      5i      