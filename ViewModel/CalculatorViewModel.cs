using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppMVVMPatternCalculatorApp.Commands;
using WpfAppMVVMPatternCalculatorApp.Model;

namespace WpfAppMVVMPatternCalculatorApp.ViewModel
{
    public class CalculatorViewModel
    {
        public CalculatorViewModel() 
        {
            AddCommand = new AdditionCommand(this);
            SubtractCommand = new SubtractionCommand(this);
            MultiplyCommand = new MultiplicationCommand(this);
            DivideCommand = new DivisionCommand(this);
        }
        public ICommand AddCommand { get; set; }
        public ICommand SubtractCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }
        public ICommand DivideCommand { get; set; }

        public Calculator MyCalculator { get; set; } = new Calculator();

        public void Add()
        {
            MyCalculator.Addition(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }

        public bool CanAdd()
        {
            return true;
        }

        public void Subtract()
        {
            MyCalculator.Subtract(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanSubtract()
        {
            return true;
        }

        public void Multiply()
        {
            MyCalculator.Multiply(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanMultiply()
        {
            return true;
        }

        public void Divide()
        {
            MyCalculator.Divide(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanDivide()
        {
            return true;
        }

    }
}
