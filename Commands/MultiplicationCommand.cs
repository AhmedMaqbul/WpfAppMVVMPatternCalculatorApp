using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorApp.ViewModel;

namespace WpfAppMVVMPatternCalculatorApp.Commands
{
    public class MultiplicationCommand : RelayCommand
    {
        private CalculatorViewModel _multiply;
        public MultiplicationCommand(CalculatorViewModel multiply)
        {
            _multiply = multiply;
        }

        public override bool CanExecute(object parameter)
        {
            return _multiply.CanMultiply();
        }

        public override void Execute(object parameter)
        {
            _multiply.Multiply();
        }
    }
}
