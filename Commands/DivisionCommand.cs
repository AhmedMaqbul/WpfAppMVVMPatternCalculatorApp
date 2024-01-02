using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorApp.ViewModel;

namespace WpfAppMVVMPatternCalculatorApp.Commands
{
    public class DivisionCommand : RelayCommand
    {
        private CalculatorViewModel _division;
        public DivisionCommand(CalculatorViewModel division)
        {
            _division = division;
        }

        public override bool CanExecute(object parameter)
        {
            return _division.CanDivide();
        }

        public override void Execute(object parameter)
        {
            _division.Divide();
        }
    }
}
