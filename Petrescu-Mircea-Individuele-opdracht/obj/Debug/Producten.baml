   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   4    .Petrescu_Mircea_Individuele_opdracht.Producten   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	Producten��5	   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�6G   .��5
      � .+�5   
   � -   5        $��TitleBar��5      $
��Left=�6>   $��21��6Y   $��94,0,0,0q�6e   $	��Top=�6w   $	��706��6�   ���	#FF267A7A.+�5      �� -   5         ��Name$ btnClose��5       $�� ��6   $
��Left=�6I   $��19��6d   $��	666,2,0,0q�6p   $	��Top=�6�   $��40��6�   
�������6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Power=�6&   $��	680,2,0,0q�63    J� RenderTransformOrigin$ 11.562,0.854&�6F   $��12��6k   5      � 5   
   $
��Left=�6   $	��450��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB.+�5      �� -   5        $ btnToonAlles��5   *   $��
Toon alles��6   $
��Left=�6[   $��28��6v   $��0,34,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $ 	btnToonID��5   (   $��Toon ID:��6   $
��Left=�6T   $��28��6o   $��0,81,0,0q�6{   $	��Top=�6�   $��94��6�   �� 5      -   5        $��btnToevoegen��5      $��	Toevoegen��6)   $
��Left=�6=   $��28��6X   $��	0,156,0,0q�6d   $	��Top=�6w   $��94��6�   6�   �� 5      -   5        $��btnVerwijderen��5      $��Verwijderen��6+   $
��Left=�6A   $��28��6\   $��	0,260,0,0q�6h   $	��Top=�6{   $��94��6�   6�   �� 5      $��Update��6   $
��Left=�6&   $��28��6A   $��	0,209,0,0q�6M   $	��Top=�6`   $��94��6x   �� 5      -   5         ��Name$ txtProductID��5      $
��Left=�6,   $��30��6G   $��	0,111,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��94��6�   ���	#FF80BB7A6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgShowProducten��5      $
��Left=�6*   $	��377��6E   $��	94,21,0,0q�6R   $	��Top=�6e   $	��706��6}      SelectionMode$ Extended=�6�   	   SelectionUnit$	 FullRow=�6�   
   Columns
 5      5  /MaterialDesignThemes.Wpf.DataGridComboBoxColumn  5      5      �� 5   
   -	   5        $��btnMinimize��5      $
��Left=�6?   $��22��6Z   $��	713,0,0,0q�6f   $	��Top=�6y   $��46��6�   $ -0.179,1.591&�6�   
�������.��5        $ WindowMinimize=�6'   
���   �$ 0.188,0.797&�6h   ��6R   Z� 6h   5      5!      5"      