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

namespace RegistroPrestamo.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cPrestamos.xaml
    /// </summary>
    public partial class cPersonas : Window
    {
        public cPersonas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Consulta.ItemsSource = null;
            var listado = new List<Persona>();

            if (DesdeDatePicker.SelectedDate != null)
            {
                listado = PersonaBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);
            }
            else
            {
                listado = PersonaBLL.GetList(c => true);
            }

            if (HastaDatePicker.SelectedDate != null)
            {
                listado = PersonaBLL.GetList(c => c.Fecha.Date <= HastaDatePicker.SelectedDate);
            }
            else
            {
                listado = PersonaBLL.GetList(c => true);
            }
            Consulta.ItemsSource = listado;
        }
    }
}