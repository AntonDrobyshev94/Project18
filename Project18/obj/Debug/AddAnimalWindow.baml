   M S B A M L   `   `   `  ����D  @Project18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project18	Project18  5   	       Project18.AddAnimalWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project18     5   	     � Title$  AddAnimalWindow��5   	   $	��210��6!   $	��500��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��60 �6   �� 5      $	��150 �6   �� 5      $��20 �6   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ TxtClassAnimal��5       �� TextWrapping$
 Wrap=�6*   $�� ��6>   $��3��6F   $��1��6V   �� 5   
   -   5        $ TxtTypeOfAnimal��5      $
 Wrap=�6+   $�� ��6?   $��3��6G   $��3��6W   �� 5    
   -   5        $ TxtName��5       $
 Wrap=�6#   $�� ��67   $��3��6?   $��5��6O   �� 5!   
   -   5         ��Name$ CreateButton��5!      $��Добавить��6'   $��1��6:   $��7��6J   �� 5"   
   -   5        $ CancelButton��5"      $��Отменить��6'   $��3��6:   $��7��6J   $��	38,0,19,0q�6W   �� 5#   
   $
 Wrap=�6   $!��Класс животных��6&    �� TextAlignment$ Center=�6<   $	��120��6S   $��1��6_   $��1��6o   �� 5$   
   $
 Wrap=�6   $��Тип питания��6&   $ Center=�69   $	��120��6P   $��1��6\   $��3��6l   �� 5%   
   $
 Wrap=�6   $��Название��6&   $ Center=�66   $	��120��6M   $��1��6Y   $��5��6i   5&      5'      