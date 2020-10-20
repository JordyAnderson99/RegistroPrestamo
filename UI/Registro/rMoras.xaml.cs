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
using RegistroPrestamo.Entidades;
using RegistroPrestamo.BLL;

namespace RegistroPrestamo.UI.Registro
{
    /// <summary>
    /// Interaction logic for rMoras.xaml
    /// </summary>
    public partial class rMoras : Window
    {
        private Moras moras = new Moras();
        
        public rMoras()
        {
            InitializeComponent();
            PrestamoIdComboBox.ItemsSource= PrestamoBLL.GetList(p =>true);
            PrestamoIdComboBox.SelectedValuePath= "PrestamosId";
            PrestamoIdComboBox.DisplayMemberPath="PrestamoId";            
            this.DataContext= moras;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = moras;
        }

        private void Limpiar(){
            this.moras = new Moras();
            this.DataContext= moras;
        }

        private bool Validar(){
            bool esValido = true;

            if(PrestamoIdComboBox.Text.Length ==0){
                esValido = false;
                MessageBox.Show("Transaccion Fallida" , "Fallo", 
                MessageBoxButton.OK, MessageBoxImage.Warning);
                                
            }            
            /*else if (ValorTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Ha ocurrido un error, Inserte el prestamo", "ERROR",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }*/


            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e){
              var moras = MorasBLL.Buscar(this.moras.MoraId);

            if(moras != null){
                    this.moras = moras;
                Cargar();
            }
            else{
                    this.moras = new Moras();
            }
            this.DataContext = this.moras;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            
                var paso = MorasBLL.Guardar(moras);
                if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if(PrestamoBLL.Eliminar(Utilidades.ToInt(MoraIdTextBox.Text))){

                Limpiar();
                MessageBox.Show("Registro eliminado!" , "Exito" , MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("No fue posible eliminar", "Fallo",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            var filaDetalle = new MorasDetalle(moras.MoraId, Convert.ToInt32(PrestamoIdComboBox.SelectedIndex+1), FechaDatePicker.DisplayDate, Convert.ToInt32(ValorTextBox.Text));

            moras.Detalle.Add(filaDetalle);
            Cargar();
                        
            ValorTextBox.Clear();
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                moras.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }
    }
}
