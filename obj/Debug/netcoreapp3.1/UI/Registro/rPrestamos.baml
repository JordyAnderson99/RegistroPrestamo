   M S B A M L   `   `   `  ����K  GRegistroPrestamo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:RegistroPrestamo.UI.RegistroRegistroPrestamo.UI.Registro  5   	   -    'RegistroPrestamo.UI.Registro.rPrestamos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:RegistroPrestamo.UI.Registro     5   	     � Title$  Registro de Prestamo��5   	   $	��430��6&   $	��450��63   .��5	      � .+�5
   
   �� $��-120,90,-1,-1q�6   $��Center=�6.   $��Center=�6I   .+�5      �� $��
PrestamoId��6   $
��Bold"�6+   $
��15px(�6=   $��120,-125,1,1q�6M   $��SimSun-ExtB)�6c   $��Normal$�6|   �� 5      -   5         ��Name$ PrestamoIdTextBox��5      $��50��6P   $��25��6[   $��10,-225,0,0q�6g   ��63   �� *
PrestamoId+6g   �� 5      -   5         ��Name$ BuscarButton��5      $��240,-225,0,0q�6,   $	��120��6B   $��40��6P   $��     Buscar��6^   $
��Bold"�6�   �� 5      $��/Imagenes/Buscar.png��6   $��30��63   $��30��6>   $��160,-225,0,0q�6K   �� 5      $��	PersonaId��6   $
��Bold"�6*   $
��15px(�6<   $��120,-90,1,1q�6L   $��SimSun-ExtB)�6a   $��Normal$�6z   �� 5      -   5         ��Name$ PersonaIdComboBox��5      $��80��6Y   $��25��6d   $��40,-150,0,0q�6p    �� SelectedValue 64   �� *	PersonaId+6p   �� 5      $��Fecha��6   $
��Bold"�6&   $��13.5px(�68   $��120,-50,1,1q�6J   $��SimSun-ExtB)�6_   $��Normal$�6x   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaDatePicker��5      $	��190��6T   $��30��6`   $��150,-80,0,0q�6l      SelectedDate 64   �� *Fecha+6l   �� 5      $��Concepto��6   $
��Bold"�6*   $
��15px(�6<   $��120,-10,1,1q�6L   $��SimSun-ExtB)�6a   $��Normal$�6z   �� 5      -   5        $ ConceptoTextBox��5      $	��190��6M   $��25��6Y   $��150,-30,0,0q�6e   ��62   �� *
Concepto+6e   �� 5       $��Monto��6   $
��Bold"�6&   $
��15px(�68   $��
120,10,1,1q�6H   $��SimSun-ExtB)�6\   $��Normal$�6u   �� 5!      -   5        $ MontoTextBox��5!      $	��190��6F   $��25��6R   $��150,-30,0,0q�6^   ��6.   �� *Monto+6^   �� 5$      $��Balance��6   $
��Bold"�6(   $
��15px(�6:   $��
120,10,1,1q�6J   $��SimSun-ExtB)�6^   $��Normal$�6w   �� 5%      -   5        $ BalanceTextBox��5%      $	��190��6J   $��27��6V   $��150,-30,0,0q�6b   ${�false��6w   ��60   �� *	Balance+6w   �� 5)      -   5        $ NuevoButton��5)      $��-120,20,0,0q�6+   $	��100��6@   $��40��6N   $��        Nuevo��6\   $
��Bold"�6�   �� 5*      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-180,-40,0,0q�6J   �� 5-      -	   5        $ GuardarButton��5-      $��140,-40,0,0q�6-   $	��100��6B   $��40��6P   $��        Guardar��6^   $
��Bold"�6�   �� 5.      $��/Imagenes/Guardar.jpg��6   $��35��64   $��35��6?   $��
80,-40,0,0q�6L   �� 51      -
   5        $ EliminarButton��51      $��390,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��          Eliminar��6_   $
��Bold"�6�   �� 52      $��/Imagenes/Eliminar.png��6   $��40��65   $��40��6@   $��330,-40,0,0q�6M   53      54      55      