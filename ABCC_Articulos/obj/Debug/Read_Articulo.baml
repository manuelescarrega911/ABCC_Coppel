   M S B A M L   `   `   `  ����I  EABCC_Articulos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ABCC_ArticulosABCC_Articulos  5   	   "    ABCC_Articulos.Read_Articulo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35RMaterialDesing9http://schemas.microsoft.com/netfx/2009/xaml/presentation    D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ABCC_Articulos     5   	   -   5          � Title$  Read_Articulo��5   	   $	��450��6   $	��800��6,    � WindowStyle$
 None=�68    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6e   .��5
      � .+�5   
   �� ���	#FF6A32B6$��3��69   $��	0,0,0,390q�6M   5      �� 5   
   $��Consultar Articulo��6   $
��Left=�6-   $��228,0,0,390q�6H   $	��349��6]   $��Arial Rounded MT Bold)�6i   
������ $��36(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $	��SKU��6   $��	22,87,0,0q�6   $
��Left=�61   $	��Top=�6L   $��30��6d   $��46��6p   $��Arial)�6{   $
��Bold"�6�   $��16(�6�    J� RenderTransformOrigin$ 0.857,0.653&�6�   6�   �� 5   
   -   5        $��Text_Sku��5   G   $
��Left=�6   $��24��6-    �� 	MaxLength$ 6��69   $��	73,87,0,0q�6W    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��213��6�   $ 
0.375,0.13&�6�   $��Arial)�6�   $��14(�6�   6�   �� 5   
   -   5        $��Button_Buscar��5   �   $��Buscar��6   $
��Left=�6"   $��
311,83,0,0q�6>   $	��Top=�6R   $	��126��6j   $��29��6w   ���	#FF963AB7���	#FF963AB7
�������$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.14Q�6$   �� 5      T� 5       T� Y$ -0.198Q�6)   5      5      �� 5   
   -   5        $��Regresar��5      $
��Left=�6$   $��
449,83,0,0q�6@   $	��Top=�6T   $	��126��6l   $��29��6y   ���	#FF963AB7���	#FF963AB7
�������$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      $ -0.14Q�6$   �� 5       T� 5!      $ -0.198Q�6)   5"      5$      &   System.Windows.Controls.DataGrid  5'   
   -   5        	  Name$	 Tabla_InfoSku��5'   �   $
��Left=�6   $	��288��6.   $��
15,132,0,0q�6;   $	��Top=�6O   $	��775��6g   $ 0.5,0.5&�6s   
   
IsReadOnly
 .    Columns 5(      z�5,      V� 5-      .~�5.      �� �� 5/      $ -0.216Q�6$   �� 50       �� Angle$ 0.449Q�6&   T� 51       T� X$ 0.008Q�6)   $ -0.984Q�63   52      54      �� 56   
   -   5        $��Depa_Clas_Famili��56   �   $ ��Departamento-Clase-Familia��6   $
��Left=�66   $��
586,83,0,0q�6R   $	��Top=�6f   $	��194��6~   $��29��6�   ���	#FF963AB7���	#FF963AB7
�������$ 0.5,0.5&�6�   z�57      V� 58      .~�59      �� �� 5:      $ -0.14Q�6$   �� 5;      T� 5<      $ -0.198Q�6)   5=      5?      5A      5B      