   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   7    1Petrescu_Mircea_Individuele_opdracht.Categorieën   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Categorieën��5	   	   $	��450��6   $	��800��6*    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�6J   .��5
      � .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��	94,0,-8,0q�6g   $	��Top=�6z   $	��706��6�   ���	#FF267A7A.+�5      � $
��Left=�6   $	��417��6.   $	��Top=�6;   $��94��6S   ���	#FFB3AEBB$��-94,0,0,-396q�6v   .+�5      �� -   5         ��Name$ btnToonAlles��5   .   $��
Toon alles��6   $
��Left=�6_   $��28��6z   $��0,34,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $ btnToevoegen��5   -   $��	Toevoegen��6   $
��Left=�6C   $��28��6^   $��0,82,0,0q�6j   $	��Top=�6|   $��94��6�   $��12(�6�   �� 5      -   5        $ 	btnUpdate��5   *   $��Update��6   $
��Left=�6=   $��28��6X   $��	0,180,0,0q�6d   $	��Top=�6w   $��94��6�   6�   �� 5      -   5        $ btnVerwijderen��5   /   $��Verwijderen��6   $
��Left=�6G   $��28��6b   $��	0,132,0,0q�6n   $	��Top=�6�   $��94��6�   $��12(�6�   �� 5      -   5        $��txtCategorieNaam��5      $
��Left=�62   $��30��6M   $��	0,296,0,0q�6Y    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $��94��6�   ���	#FF4CAF506�   �� 5      -   5        $��txtCategorieID��5      $
��Left=�60   $��32��6K   $��	0,235,0,0q�6W   $
 Wrap=�6j   $	��Top=�6~   $��94��6�   ���	#FF4CAF506�   �� 5      $��Categorie ID��6   $
��Left=�6/   $��22��6J   $��
10,213,0,0q�6V   $	��Top=�6j   $��66��6�   $��10(�6�   �� 5      $��Categorie Naam:��6   $
��Left=�62   $��22��6M   $��
10,274,0,0q�6Y   $	��Top=�6m   $��66��6�   $��8(�6�   5      �� 5      -   5        $ btnClose��5      $
��Left=�6>   $��19��6Y   $��666.333,2,-0.333,0q�6e   $	��Top=�6�   $��40��6�   
�������6�   �� 5      -	   5        $ btnMinimize��5      $
��Left=�6D   $��22��6_   $��
620,0,0,-1q�6k   $	��Top=�6   $��46��6�    J� RenderTransformOrigin$ -0.179,1.591&�6�   
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6+   
���   �$ 0.188,0.797&�6l   ��6V   Z� 6l   5        5      $ Power=�6&   $ 11.562,0.854&�63   $��12��6X   $��	678,2,0,0q�6c   5      &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dgShowCategories��5      $
��Left=�6-   $	��270��6H   $��	94,26,0,0q�6U   $	��Top=�6h   $	��698��6�   5      5      