   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   6    0Petrescu_Mircea_Individuele_opdracht.MaakProduct   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MaakProduct��5	   	   $	��610��6   $	��800��6*    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I   .��5
      � $��0,2,0,0q�6   .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��93,0,0,0q�6g   $	��Top=�6y   $	��706��6�   ���	#FF267A7A � ColumnDefinitions 5      �� 5      $
��427* �6#   �� 5      $
��279* �6#   .+�5      �� -   5         ��Name$ btnClose��5       $�� ��6   $
��Left=�6I   $��21��6d   $��	239,0,0,0q�6p   $	��Top=�6�   $��40��6�   
�������$��1��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Power=�6&   $��	253,2,0,0q�63    J� RenderTransformOrigin$ 11.562,0.854&�6F   $��12��6k   $��1��6v   �� 5      -   5        $ btnMinimize��5      $
��Left=�6D   $��21��6_   $��	193,0,0,0q�6k   $	��Top=�6~   $��46��6�   $ -0.179,1.591&�6�   
�������$��1��6�   .��5        $ WindowMinimize=�6+   
���   �$ 0.188,0.797&�6l   ��6V   Z� 6l   5      5      � 5   
   $
��Left=�6   $	��605��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB$��	0,0,0,-28q�6q   .+�5      �� -   5        $ btnToevoegen��5   .   $��
Toevoegen
��6   $
��Left=�6_   $��28��6z   $��0,87,0,0q�6�   $	��Top=�6�   $��94��6�   $��11(�6�   5      �� 5   
   -   5         ��Name$ txtProductID��5      $
��Left=�6(   $��35��6C   $��
326,79,0,0q�6O   	 �� TextWrapping$
	 Wrap=�6c   $	��Top=�6w   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        
 ��Name$
 lblProductID��5      $��
Product ID��6&   $
��Left=�6;   $��36��6V   $��
163,79,0,0q�6b   $	��Top=�6v   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $ txtNaam��5      $
��Left=�6#   $��35��6>   $��326,136,0,0q�6J   $
	 Wrap=�6_   $	��Top=�6s   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $
 lblNaam��5      $
��Naam��6!   $
��Left=�60   $��36��6K   $��163,136,0,0q�6W   $	��Top=�6l   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -	   5        $ txtInkoopprijs��5      $
��Left=�6*   $��35��6E   $��326,200,0,0q�6Q   $
	 Wrap=�6f   $	��Top=�6z   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -
   5        $
 lblInkoopprijs��5      $��Inkoopprijs��6(   $
��Left=�6>   $��36��6Y   $��163,200,0,0q�6e   $	��Top=�6z   $	��138��6�   ���	#FFBEE8BF6�   �� 5    
   -   5        $
 lblMarge��5       $��Marge��6"   $
��Left=�62   $��36��6M   $��163,258,0,0q�6Y   $	��Top=�6n   $	��138��6�   ���	#FFBEE8BF6�   �� 5!   
   -   5        $ txtMarge��5!      $
��Left=�6$   $��35��6?   $��326,259,0,0q�6K   $
	 Wrap=�6`   $	��Top=�6t   $	��155��6�   ���	#FFBEE8BF6�   �� 5"   
   -   5        $
 
lblEenheid��5"      $��Eenheid��6$   $
��Left=�66   $��36��6Q   $��163,309,0,0q�6]   $	��Top=�6r   $	��138��6�   ���	#FFBEE8BF6�   �� 5#   
   -   5        $ 
txtEenheid��5#      $
��Left=�6&   $��35��6A   $��326,309,0,0q�6M   $
	 Wrap=�6b   $	��Top=�6v   $	��155��6�   ���	#FFBEE8BF6�   �� 5$   
   -   5        $
 lblBTW��5$      $	��BTW��6    $
��Left=�6.   $��36��6I   $��163,365,0,0q�6U   $	��Top=�6j   $	��138��6�   ���	#FFBEE8BF6�   �� 5%   
   -   5        $ txtBTW��5%      $
��Left=�6"   $��35��6=   $��326,366,0,0q�6I   $
	 Wrap=�6^   $	��Top=�6r   $	��155��6�   ���	#FFBEE8BF6�   �� 5&   
   -   5        $
 lblLeverancierID��5&      $��Leverancier ID	��6*   $
��Left=�6H   $��36��6c   $��163,412,0,0q�6o   $	��Top=�6�   $	��138��6�   ���	#FFBEE8BF6�   �� 5'   
   -   5        $ txtLeverancierID��5'      $
��Left=�6,   $��35��6G   $��326,413,0,0q�6S   $
	 Wrap=�6h   $	��Top=�6|   $	��155��6�   ���	#FFBEE8BF6�   �� 5(   
   -   5        $
 lblCategorieID��5(      $��Categorie ID��6(   $
��Left=�6?   $��36��6Z   $��163,466,0,0q�6f   $	��Top=�6{   $	��138��6�   ���	#FFBEE8BF6�   �� 5)   
   -   5        $ txtCategorieID��5)      $
��Left=�6*   $��35��6E   $��326,468,0,0q�6Q   $
	 Wrap=�6f   $	��Top=�6z   $	��155��6�   ���	#FFBEE8BF6�   5+      5,      