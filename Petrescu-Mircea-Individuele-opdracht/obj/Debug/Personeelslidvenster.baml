   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   ?    9Petrescu_Mircea_Individuele_opdracht.Personeelslidvenster   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Personeelslid��5	   	   $	��450��6   $	��800��6,    � 
ResizeMode$ NoResize=�68    � WindowStyle$
 None=�6N   .��5
      � .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��	94,0,-8,0q�6g   $	��Top=�6z   $	��706��6�   ���	#FF267A7A.+�5      �� -   5         ��Name$ btnClose��5       $�� ��6   $
��Left=�6I   $��21��6d   $��	666,0,0,0q�6p   $	��Top=�6�   $��40��6�   
�������6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Power=�6&   $��	680,2,0,0q�63    J� RenderTransformOrigin$ 11.562,0.854&�6F   $��12��6k   �� 5      -   5        $��btnMinimize��5      $
��Left=�6B   $��22��6]   $��
620,0,0,-1q�6i   $	��Top=�6}   $��46��6�   $ -0.179,1.591&�6�   
�������.��5        $ WindowMinimize=�6+   
���   �$ 0.188,0.797&�6l   ��6V   Z� 6l   5      5      � 5   
   $
��Left=�6   $	��450��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB.+�5      �� -   5        $ btnToonAlles��5   *   $��
Toon alles��6   $
��Left=�6[   $��28��6v   $��0,34,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $��btnToevoegen��5   )   $��	Toevoegen��6   $
��Left=�6X   $��28��6s   $��0,87,0,0q�6   $	��Top=�6�   $��94��6�   �� 5      -   5        $��btnVerwijderen��5   +   $��Verwijderen��6   $
��Left=�6^   $��28��6y   $��	0,192,0,0q�6�   $	��Top=�6�   $��94��6�   �� 5      -   5        $��	btnUpdate��5   &   $��Update��6   $
��Left=�67   $��28��6R   $��	0,139,0,0q�6^   $	��Top=�6q   $��94��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgShowEmployees��5      $
��Left=�6*   $	��245��6E   $��	94,21,0,0q�6R   $	��Top=�6e   $	��522��6}   �� 5   
   -	   5         ��Name$ txtPersoneelslidID��5      $
��Left=�6.   $��35��6I   $��270,272,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��156��6�   ���	#FFBEE8BF6�   �� 5   
   -
   5        	 ��Name$	 lblPersoneelslidID��5      $��Personeelslid ID��6,   $
��Left=�6G   $��36��6b   $��117,271,0,0q�6n   $	��Top=�6�   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $ txtVoornaam��5      $
��Left=�6'   $��35��6B   $��270,323,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��35��6B   $��271,376,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $	 lblVoornaam��5      $��Voornaam��6%   $
��Left=�68   $��36��6S   $��117,323,0,0q�6_   $	��Top=�6t   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $	 lblPassword��5      $��Password��6%   $
��Left=�68   $��36��6S   $��117,376,0,0q�6_   $	��Top=�6t   $	��138��6�   ���	#FFBEE8BF6�   5!      5"      