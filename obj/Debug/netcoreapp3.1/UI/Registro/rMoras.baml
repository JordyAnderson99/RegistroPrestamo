   M S B A M L   `   `   `  ����K  GRegistroPrestamo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:RegistroPrestamo.UI.RegistroRegistroPrestamo.UI.Registro  5   	   )    #RegistroPrestamo.UI.Registro.rMoras   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:RegistroPrestamo.UI.Registro     5   	     � Title$  Registro de Moras��5   	   $	��465��6#   $	��600��60   .��5	      � $	��440��6   .+�5
   
   �� $��46,0,0,0q�6   $��Center=�6)   $
��Left=�6D   $	��500��6`   $	��650��6l   .+�5      �� $��MoraId��6   $
��15px(�6'   $��-390,125,1,1q�67   $��SimSun-ExtB)�6M   $��Normal$�6f   $��90��6y   �� 5      -   5         ��Name$ MoraIdTextBox��5      $��50��6H   $��25��6S   $��-220,-25,0,0q�6_   ��6/   �� *MoraId+6_   �� 5      -   5         ��Name$ BuscarButton��5      $��210,-40,0,0q�6,   $	��120��6A   $��40��6O   $��     Buscar��6]   $
��Bold"�6�   �� 5      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��140,-40,0,0q�6K   �� 5      $��Fecha��6   $��13.5px(�6&   $��-430,10,0,0q�68   $��SimSun-ExtB)�6M   $��Normal$�6f   $��48��6y   $��24��6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaDatePicker��5      $	��160��6T   $��25��6`   $��-110,-20,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5       �� Orientation$ Vertical=�6   .+�5      �� $��Detalle Moras��6   $��0,5,0,0q�62   .��5      �� .+�5      �� $��
PrestamoId��6    $
��15px(�67   $��0,10,1,1q�6G   $��SimSun-ExtB)�6Y   $��Normal$�6r   �� 5      -   5         ��Name$ PrestamoIdComboBox��5   #   $��80��6g   $��25��6r   $��-190,-25,0,0q�6~    �� SelectedValue 6A   �� *
PrestamoId+6~   �� 5       $��Valor��6    $
��15px(�63   $��230,-25,1,1q�6C   $��SimSun-ExtB)�6X   $��Normal$�6q   �� 5!      -   5        $ ValorTextBox��5!   "   $	��100��6R   $��25��6^   $��190,-25,0,0q�6j   ��6:   �� *Valor+6j   �� 5$      $ 
Horizontal=�6%   .+�5&      �� -   5        $ AgregarFilaButton��5&   %   $��5,10,0,0q�6@   .��5'   "   �� $ 
Horizontal=�6-   .+�5(   &   �� $��/Imagenes/Mas.png��6,   $��25��6G   �� 5)   &   $��Agregar fila��6,   $
��Bold"�6C   5*   #   5+      �� 5-      -   5        $ RemoverFilaButton��5-   %   $��
180,10,0,0q�6@   .��5.   "   �� $ 
Horizontal=�6-   .+�5/   &   �� $��/Imagenes/Menos.png��6,   $��25��6I   �� 50   &   $��Eliminar fila��6,   $
��Bold"�6D   51   #   52      54      &   System.Windows.Controls.DataGrid  56      -   5          Name$ DetalleDataGrid��56   #   	   
IsReadOnly$
	 true��6<   $	��100��6N   
   AutoGenerateColumns$
 False��6[   $��0,10,0,0q�6�   ��6w   �� *	Detalle+   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58   "   ,  &System.Windows.Controls.DataGridColumn   Header$. (               PrestamoId               ��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *
PrestamoId+  59   "   $. (               MoraId                   ��65    6g   �� *MoraId+  5:   "   $/ )                Valor                    ��65    6h   �� *Valor+5<      5>      5?      �� 5A      $ 
Horizontal=�6   .+�5C      �� $��Total��6   $��
340,15,0,0q�6,   $
��15px(�6@   $��SimSun-ExtB)�6P   �� 5D      -	   5        $ TotalTextBox��5D      $��25��6L   $��60��6X   $��8,15,0,0q�6c   ��64   �� *Total+6c   5E      5F      �� 5K      -
   5        $ NuevoButton��5K      $��-320,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6�   �� 5L      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-380,-40,0,0q�6J   �� 5O      -   5        $ GuardarButton��5O      $��-15,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6�   �� 5P      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��-75,-40,0,0q�6L   �� 5S      -   5        $ EliminarButton��5S      $��300,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6�   �� 5T      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��240,-40,0,0q�6M   5U      5V      5W      