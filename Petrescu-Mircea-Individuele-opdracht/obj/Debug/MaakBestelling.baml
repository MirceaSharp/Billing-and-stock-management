   M S B A M L   `   `   `  ����_  [Petrescu-Mircea-Individuele-opdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Petrescu_Mircea_Individuele_opdracht$Petrescu_Mircea_Individuele_opdracht  5   	   9    3Petrescu_Mircea_Individuele_opdracht.MaakBestelling   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Petrescu_Mircea_Individuele_opdracht     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  MaakBestelling��5	   	   $	��450��6    $	��800��6-    � WindowStyle$
 None=�69    � 
ResizeMode$ NoResize=�6L   .��5
      � $��15,3,-15,-3q�6   .+�5   
   � -   5         �Name$ TitleBar��5      $
��Left=�6@   $��21��6[   $��	79,-3,0,0q�6g   $	��Top=�6z   $	��706��6�   ���	#FF267A7A.+�5      �� -   5         ��Name$ btnClose��5       $�� ��6   $
��Left=�6I   $��21��6d   $��	666,0,0,0q�6p   $	��Top=�6�   $��40��6�   
�������6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Power=�6&   $��	680,2,0,0q�63    J� RenderTransformOrigin$ 11.562,0.854&�6F   $��12��6k   �� 5      -   5        $ btnMinimize��5      $
��Left=�6D   $��21��6_   $��	620,0,0,0q�6k   $	��Top=�6~   $��46��6�   $ -0.179,1.591&�6�   
�������.��5        $ WindowMinimize=�6+   
���   �$ 0.188,0.797&�6l   ��6V   Z� 6l   5      5      � 5   
   $
��Left=�6   $	��450��6*   $	��Top=�67   $��94��6O   ���	#FFB3AEBB$��
-15,-3,0,0q�6q   .+�5      �� -   5        $ btnToevoegen��5   3   $��Toevoegen
��6   $
��Left=�6d   $��28��6   $��0,87,0,0q�6�   $	��Top=�6�   $��94��6�   $��11(�6�   5      �� 5   
   -   5        $��txtBestellingID��5      $
��Left=�6)   $��35��6D   $��
326,79,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��155��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $��lblBestellingID��5      $��Bestelling ID	��6'   $
��Left=�6D   $��36��6_   $��
163,79,0,0q�6k   $	��Top=�6   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $��lblDatum��5      $��Datum Opgemaakt��6    $
��Left=�6:   $��36��6U   $��163,124,0,0q�6a   $	��Top=�6v   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -	   5        $��lblLeverancierID��5      $��Leverancier ID��6(   $
��Left=�6A   $��36��6\   $��163,167,0,0q�6h   $	��Top=�6}   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -
   5        $��lblPersoneelslidID��5      $��Personeelslid ID��6*   $
��Left=�6E   $��36��6`   $��163,209,0,0q�6l   $	��Top=�6�   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $��	lblKantID��5      $��Klant ID��6!   $
��Left=�64   $��36��6O   $��163,250,0,0q�6[   $	��Top=�6p   $	��138��6�   ���	#FFBEE8BF6�   �� 5   
   -   5        $��CmbLeverancierID��5      $
��Left=�6+   $��36��6F   $��326,168,0,0q�6R   $	��Top=�6g   $	��155��6   ���	#FFBEE8BF6�   �� 5   
   -   5        $��CmbPersoneelslidID��5      $
��Left=�6-   $��36��6H   $��326,209,0,0q�6T   $	��Top=�6i   $	��155��6�   ���	#FFBEE8BF6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
DatePicker��5      ���	#FFBEE8BF   DisplayDate$ 
2019-12-20��6?   $
��Left=�6X   $��36��6s   $��326,124,0,0q�6   $	��Top=�6�   $	��155��6�   �� 5   
   -   5        	 ��Name$	 
CmbKlantID��5      $
��Left=�6'   $��36��6B   $��326,250,0,0q�6N   $	��Top=�6c   $	��155��6{   ���	#FFBEE8BF6�   5!      5"      