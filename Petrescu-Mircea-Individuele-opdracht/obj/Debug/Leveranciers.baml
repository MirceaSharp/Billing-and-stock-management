   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   7    1Petrescu_Mircea_Individuele_opdracht.Leveranciers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Leveranciers��5	   	   $	��450��6   $	��800��6+    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�6J   .��5
      � .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��94,0,0,0q�6g   $	��Top=�6y   $	��706��6�   ���	#FF267A7A6�   � 5   
   $
��Left=�6   $	��448��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB$��-1,2,0,0q�6r   .+�5      �� -   5         ��Name$ btnToonAlles��5   *   $��
Toon alles��6   $
��Left=�6[   $��28��6v   $��0,34,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $ btnToevoegen��5   )   $��	Toevoegen��6   $
��Left=�6?   $��28��6Z   $��0,82,0,0q�6f   $	��Top=�6x   $��94��6�   $��11(�6�   �� 5      -   5        $ 	btnUpdate��5   &   $��Update��6   $
��Left=�69   $��28��6T   $��	0,180,0,0q�6`   $	��Top=�6s   $��94��6�   6�   �� 5      -   5        $ btnVerwijderen��5   +   $��Verwijderen��6   $
��Left=�6C   $��28��6^   $��	0,132,0,0q�6j   $	��Top=�6}   $��94��6�   $��11(�6�   �� 5      -   5        $ 	btnToonID��5      $��Toon ID:��6(   $
��Left=�6S   $��28��6n   $��	0,242,0,0q�6z   $	��Top=�6�   $��94��6�   �� 5      -   5        $��txtLevID��5      $
��Left=�6&   $��28��6A   $��	0,289,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $��94��6�   ���	#FF4CAF506�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgShowSuppliers��5      $
��Left=�6,   $	��429��6G   $��	94,21,0,0q�6T   $	��Top=�6g   $	��706��6   �� 5   
   -	   5        $ btnClose��5      $
��Left=�6:   $��21��6U   $��	760,0,0,0q�6a   $	��Top=�6t   $��40��6�   
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6&    J� RenderTransformOrigin$ 11.562,0.854&�63   $��10��6X   5      �� 5   
   -
   5        $ btnMinimize��5      $
��Left=�6@   $��21��6[   $��	714,0,0,0q�6g   $	��Top=�6z   $��46��6�   $ -0.179,1.591&�6�   
�������.��5        $ WindowMinimize=�6'   
���   �$ 0.188,0.797&�6h   ��6R   Z� 6h   5      5      5      