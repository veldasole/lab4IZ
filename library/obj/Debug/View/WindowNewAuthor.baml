   M S B A M L   `   `   `  ����B  >library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:library.Viewlibrary.View  5   	   "    library.View.WindowNewAuthor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:library.View     5   	     � Title$  WindowNewAuthor��5   	   $	��200��6!   $	��260��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��75* �6   .+�5   
   �� $��0��6   $��0��6!   $��Код:��61   $��Right=�6=   $��Center=�6Y   $��5q�6t   �� 5   
   $��1��6   $��0��6!   $��Фамилия:��61   $��Right=�6A   $��Center=�6]   $��5q�6x   �� 5   
   $��2��6   $��0��6!   $��Имя:��61   $��Right=�6=   $��Center=�6Y   $��5q�6t   �� 5   
   -   5         ��Name$
 TbId��5      $��0��6    $��1��6-   $��20��6=   $��50��6I   $
��Left=�6T   $��Center=�6o   $��5q�6�   {�.  ��6�   �� *Id+6�   �� 5   
   -   5        $ 
TbLastName��5      $��1��6&   $��1��63   $��20��6C   $	��130��6O   $
��Left=�6[   $��Center=�6v   $��5q�6�   ��6�   �� *
LastName+�� 5   
   -   5        $ TbFirstName��5      $��2��6'   $��1��64   $��20��6D   $	��130��6P   $
��Left=�6\   $��Center=�6w   $��5q�6�   ��6�   �� *	FirstName+�� 5   
   $��0��6   $��2��6%   $��3��69    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   .+�5      �� -   5         ��Name$ BtSave��5      $��Сохранить��6%   $��25��69   $��Right=�6E   $	��Top=�6a   $��	5,10,10,5q�6y    �� 	IsDefault . 6�   �� 5      -   5        $ BtCansel��5      $��Отменить��6'   $��25��6:   $��Right=�6F   $	��Top=�6b   $��	5,10,10,5q�6z    �� IsCancel . 6�   5      5       5!      