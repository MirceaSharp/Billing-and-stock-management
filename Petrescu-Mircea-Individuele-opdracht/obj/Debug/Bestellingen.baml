   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   7    1Petrescu_Mircea_Individuele_opdracht.Bestellingen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Bestellingen��5	   	   $	��450��6   $	��800��6+    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�6J   .��5      � .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��	94,0,-8,0q�6g   $	��Top=�6z   $	��706��6�   ���	#FF267A7A � ColumnDefinitions 5      �� 5      $
��411* �6#   �� 5      $
��295* �6#   .+�5      �� -   5         ��Name$ btnClose��5       $�� ��6   $
��Left=�6I   $��19��6d   $��255.333,2,0,0q�6p   $	��Top=�6�   $��40��6�   
�������$��1��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Power=�6&   $��269.333,2,0,0q�63    J� RenderTransformOrigin$ 11.562,0.854&�6J   $��12��6o   $��1��6z   �� 5      -   5        $ btnMinimize��5      $
��Left=�6D   $��22��6_   $��209.333,0,0,-1q�6k   $	��Top=�6�   $��46��6�   $ -0.179,1.591&�6�   
�������$��1��6�   .��5        $ WindowMinimize=�6+   
���   �$ 0.188,0.797&�6l   ��6V   Z� 6l   5      5      � 5   
   $
��Left=�6   $	��450��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB$��	0,0,0,-31q�6r   .+�5      �� -   5        $��btnToonAlles��5   *   $��
Toon alles��6   $
��Left=�6Y   $��28��6t   $��0,34,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $��	btnToonID��5   (   $��Toon ID:��6   $
��Left=�6Q   $��28��6l   $��0,81,0,0q�6x   $	��Top=�6�   $��94��6�   �� 5      -   5        $��btnToevoegen��5   )   $��	Toevoegen��6   $
��Left=�6=   $��28��6X   $��	0,156,0,0q�6d   $	��Top=�6w   $��94��6�   6�   �� 5      -   5        $��	btnUpdate��5   &   $��Update��6   $
��Left=�67   $��28��6R   $��	0,260,0,0q�6^   $	��Top=�6q   $��94��6�   6�   �� 5      -   5        $��btnVerwijderen��5   +   $��Verwijderen��6   $
��Left=�6A   $��28��6\   $��	0,209,0,0q�6h   $	��Top=�6{   $��94��6�   6�   �� 5      -	   5        $��
btnFactuur��5   '   $��Factuur��6   $
��Left=�6R   $��30��6m   $��	0,312,0,0q�6y   $	��Top=�6�   $��94��6�   5      �� 5    
   -
   5        $��txtBestellingID��5       $
��Left=�6)   $��30��6D   $��	0,111,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $��94��6�   ���	#FF80BB7A6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��dgShowBestellingen��5!      $
��Left=�6-   $	��225��6H   $��	94,21,0,0q�6U   $	��Top=�6h   $	��698��6�   �� 5"   
   -   5        $��
Statistics��5"      $
��Left=�6=   $��29��6X   $��	0,375,0,0q�6d   $	��Top=�6w   $��94��6�   $��
Statistics��6�   5$      5%      