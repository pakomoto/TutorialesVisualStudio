using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TerminalTactilWPF.Viewmodels
{
    public abstract class ViewModelABS : BindableBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notifica([CallerMemberName] string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }

        private bool _ModoDebug = true;
        public bool ModoDebug
        {
            get => this._ModoDebug;
            set
            {
                if (this._ModoDebug != value)
                {
                    this._ModoDebug = value;
                    this.Notifica();
                }
            }
        }

        public ViewModelABS()
        {
            this.ReloadCommand = new DelegateCommand(this.Reload);

            //if (App.TerminalTactil != null)
            //{
            //    this.ModoDebug = App.TerminalTactil.ModoDebug;
            //}
        }

        public abstract void Reload();

        public ICommand ReloadCommand
        {
            get;
            private set;
        }

    }
}
