   M S B A M L   `   `   `  ����D  @Project18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project18	Project18  5   	       Project18.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project18     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��810��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��600 �6   �� 5       $��10 �6   �� 5!      $	��170 �6   �� 5"      $��* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridView��5$      $��0,0,0,25q�6)   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5%         SelectionMode$ Single=�5&         AutoGenerateColumns .     
IsReadOnly .  $��16(�5*      $��1��5+      $��16��5,      $��1��5-      ��5(      ��    Columns 5.   
   0  *System.Windows.Controls.DataGridTextColumn  5/      -   5        	ClassName��,  &System.Windows.Controls.DataGridColumn	   Header$#	 Класс животного��51   %   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 50   %   �� *	ClassName+52   %     53      -   5        TypeOfAnimal��$	 Тип питания��55   %    54   %   �� *TypeOfAnimal+55   %     56      -   5        Name��$	 Название��58   %    57   %   �� *Name+58   %   5;      �� 5<   
   -   5         ��Name$ 	AddButton��5<      $'��!Добавить животное��6$   $��3��6X   $��1��6h   �� 5=   
   -   5        $ DeleteButton��5=      $%��Удалить животное��6'   $��3��6]   $��3��6m   �� 5>   
   -   5        $ SaveButtonDoc��5>      $3��-Сохранить коллекцию в Word��6(   $��3��6M   $��5��6]   �� 5?   
   -   5        $ SaveButtonTxt��5?      $2��,Сохранить коллекцию в txt��6(   $��3��6L   $��7��6\   �� 5@   
   -	   5        $ SaveButtonJson��5@      $3��-Сохранить коллекцию в Json��6)   $��3��6N   $��9��6^   �� 5A   
   -
   5        $ LoadButtonJson��5A      $0��*Загрузить коллекцию Json��6)   $��3��6L   $��13��6\   �� 5B   
   -   5         ��Name$ TextBoxJsonLoadText��5B       �� TextWrapping$
 Wrap=�6/   $�� ��6C   $	��160��6K   $��3��6W   $��15��6g   5D      5E      