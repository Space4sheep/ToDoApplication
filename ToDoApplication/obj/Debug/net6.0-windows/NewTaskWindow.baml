   M S B A M L   `   `   `  ����J  FToDoApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ToDoApplicationToDoApplication  5   	   #    ToDoApplication.NewTaskWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ToDoApplication     5   	     � Title$  Нова задача��5   	   $	��350��6   $	��300��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��60 �6   .+�5   
   �� $��1��6   $��
12,0,12,12q�6"   .+�5      �� -   5         ��Name$ CancelButton��5      $��Відміна��6+   $��0,0,0,8q�6=   6N   �� 5      -   5        $ 
SaveButton��5      $��Зберегти��6)   6<   5      �� 5   
   $��12,12,12,12q�6   .+�5      �� -   5         ��Name$ TaskNameTextBlock��5      $
��Wrap=�63   $��Назва задачі��6G   $��0,0,0,4q�6[   �� 5      -   5         ��Name$ NameTextBox��5       �� TextWrapping$
 Wrap=�6+   $	��200��6?   $
��Left=�6K   $��0,0,0,8q�6f   �� 5      -   5         ��Name$ IsCompeteCheckBox��5      $#��Задача виконана��62   $��0,0,0,8q�6L   �� 5      $
��Wrap=�6   $��Опис задачі��6,   $��0,0,0,4q�6?   �� 5      -   5        $ DescriptionTextBox��5      $
 Wrap=�62   $	��200��6F   $
��Left=�6R    �� AcceptsReturn$
 True��6m   $	��118��6�   5      5      5      