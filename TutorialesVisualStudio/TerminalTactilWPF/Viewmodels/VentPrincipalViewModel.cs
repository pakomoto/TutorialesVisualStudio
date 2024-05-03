using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalTactilWPF.Viewmodels
{
    public class VentPrincipalViewModel : ViewModelABS
    {
        public VentPrincipalViewModel() 
            : base()
        {
            this.Fecha = "21/03/2024";
            this.Hora = "13:05:06";
        }

        private string _Fecha = string.Empty;
        public string Fecha
        {
            get => this._Fecha;
            set
            {
                if (this._Fecha != value)
                {
                    this._Fecha = value;
                    this.Notifica();
                }
            }
        }
        public string _Hora = string.Empty;
        public string Hora
        {
            get => this._Hora;
            set
            {
                if (!this._Hora.Equals(value))
                {
                    this._Hora = value;
                    this.Notifica();
                }
            }
        }

        public void ActualizaFechaHora()
        {
            this.Fecha = DateTime.UtcNow.ToString("dd/MM/yyyy");
            this.Hora = DateTime.UtcNow.ToString("HH:mm:ss");
        }

        public override void Reload()
        {
            this.ActualizaFechaHora();
        }
    }
}
