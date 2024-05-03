﻿using System.Configuration;
using System.Data;
using System.Windows;
using TerminalTactilWPF.Views;

namespace TerminalTactilWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            FrmVentPrincipal frmVentPrincipal = new FrmVentPrincipal();

            frmVentPrincipal.Show();
        }
    }

}
