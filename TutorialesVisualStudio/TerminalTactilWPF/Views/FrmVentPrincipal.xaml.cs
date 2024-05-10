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
using System.Windows.Shapes;
using System.Windows.Threading;
using TerminalTactilWPF.Viewmodels;

namespace TerminalTactilWPF.Views
{
    /// <summary>
    /// Lógica de interacción para FrmVentPrincipal.xaml
    /// </summary>
    public partial class FrmVentPrincipal : Window
    {
        DispatcherTimer timer = null;

        public FrmVentPrincipal()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.timer = new DispatcherTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(500); // Intervalo de 1/2 segundo
            this.timer.Tick += Timer_Tick;
            this.timer.Start();

            this.MuestraVentana(typeof(FrmPaginaPrueba1));
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (sender is DispatcherTimer miTimer)
            {
                miTimer.Stop();
                // Actualizar la fecha y la hora en el ViewModel
                ((VentPrincipalViewModel)this.DataContext).ActualizaFechaHora();

                miTimer.Start();
            }
        }

        public Page? MuestraVentana(Type type)
        {
            Page? page = null;

            if (type != null)
            {
                page = Activator.CreateInstance(type) as Page;

                if(page != null)
                    this.frameNavegacion.Navigate(page);
            }

            return page;
        }
    }
}
