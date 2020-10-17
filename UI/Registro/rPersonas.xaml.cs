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
    public partial class rPersonas : Window
    {
        Persona persona = new Persona();
        Prestamo prestamo = new Prestamo();
        public rPersonas()
        {
            InitializeComponent();
            DataContext= persona;
        }

        private void Limpiar(){
            this.persona = new Persona();
            this.DataContext= persona;
            prestamo.Monto += persona.Balance;
            this.persona.Fecha= DateTime.Now;
        }

        private bool Validar(){
            bool esValido = true;

            if(NombresTextBox.Text.Length ==0){
                esValido = false;
                MessageBox.Show("Transaccion Fallida" , "Fallo", 
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e){
            var personas = PersonaBLL.Buscar(Utilidades.ToInt(PersonaIdTextBox.Text));

            if(persona != null){
                    this.persona = personas;
            }
            else{
                    this.persona = new Persona();
            }
            this.DataContext = this.persona;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            var paso = PersonaBLL.Guardar(persona);

            if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if(PersonaBLL.Eliminar(Utilidades.ToInt(PersonaIdTextBox.Text))){

                Limpiar();
                MessageBox.Show("Registro eliminado!" , "Exito" , MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("No fue posible eliminar", "Fallo",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
