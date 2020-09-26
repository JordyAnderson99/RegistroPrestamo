using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RegistroPrestamo.UI.Registro;
using RegistroPrestamo.UI.Consulta;
using RegistroPrestamo.BLL;

namespace RegistroPrestamo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroPersonasButton_Click(object sender, RoutedEventArgs e){
            rPersonas rp = new rPersonas();
            rp.Show();
        }

        private void RegistroPrestamosButton_Click(object sender, RoutedEventArgs e){
           rPrestamos rPres = new rPrestamos();
            rPres.Show();
        }

        private void ConsultaPersonasButton_Click(object sender, RoutedEventArgs e){
           cPersonas cp = new cPersonas();
            cp.Show();
        }

        private void ConsultaPrestamosButton_Click(object sender, RoutedEventArgs e){
           cPrestamos cPres = new cPrestamos();
            cPres.Show();
        }
    }
}
