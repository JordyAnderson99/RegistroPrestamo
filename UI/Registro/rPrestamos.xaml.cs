using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RegistroPrestamo.BLL;
using RegistroPrestamo.Entidades;

namespace RegistroPrestamo.UI.Registro
{
    /// <summary>
    /// Interaction logic for rPersonas.xaml
    /// </summary>
    public partial class rPrestamos : Window
    {
        Prestamo prestamo;
        public rPrestamos()
        {
            InitializeComponent();
            DataContext= prestamo;
        }


        private void Limpiar(){
            this.prestamo = new Prestamo();
            this.DataContext= prestamo;
        }

        private bool Validar(){
            bool esValido = true;

            if(ConceptoTextBox.Text.Length ==0){
                esValido = true;
                MessageBox.Show("Transaccion Fallida" , "Fallo", 
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e){
              var prestamos = PrestamoBLL.Buscar(Utilidades.ToInt(PrestamoIdTextBox.Text));

            if(prestamos != null){
                    this.prestamo = prestamos;
            }
            else{
                    this.prestamo = new Prestamo();
            }
            this.DataContext = this.prestamo;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            var paso = PrestamoBLL.Guardar(prestamo);

            if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if(PrestamoBLL.Eliminar(Utilidades.ToInt(PrestamoIdTextBox.Text))){

                Limpiar();
                MessageBox.Show("Registro eliminado!" , "Exito" , MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("No fue posible eliminar", "Fallo",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
