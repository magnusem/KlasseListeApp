using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KlasseListeApp.ViewModel
{
    public class SletElevCommand : ICommand
    {
        private readonly Action executeSlet;

        public event EventHandler CanExecuteChanged;

        public SletElevCommand(Action executeSlet)
        {
            this.executeSlet = executeSlet;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeSlet();
        }
    }
}
