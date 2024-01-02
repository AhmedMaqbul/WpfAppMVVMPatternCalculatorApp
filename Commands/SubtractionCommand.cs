using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorApp.ViewModel;

namespace WpfAppMVVMPatternCalculatorApp.Commands
{
    public class SubtractionCommand : RelayCommand
    {
        private CalculatorViewModel _subtract;
        public SubtractionCommand(CalculatorViewModel subtract)
        {
            _subtract = subtract;
        }

        public override bool CanExecute(object parameter)
        {
            return _subtract.CanSubtract();
        }

        public override void Execute(object parameter)
        {
            _subtract.Subtract();
        }
    }
}
