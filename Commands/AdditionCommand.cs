using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorApp.ViewModel;

namespace WpfAppMVVMPatternCalculatorApp.Commands
{
    public class AdditionCommand : RelayCommand
    {
        private CalculatorViewModel _additon;
        public AdditionCommand(CalculatorViewModel additon)
        {
            _additon = additon;
        }

        public override bool CanExecute(object parameter)
        {
            return _additon.CanAdd();
        }

        public override void Execute(object parameter)
        {
            _additon.Add();
        }

    }
}
