using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVMPatternCalculatorApp.Model
{
    public class Calculator : INotifyPropertyChanged
    {
        private float _firstNumber;
        private float _secondNumber;
        private float _result;

        public float FirstNumber 
        { 
            get => _firstNumber; 
            set 
            { 
                _firstNumber = value; 
                OnPropertyChanged(nameof(FirstNumber));
            } 
        }
        
        public float SecondNumber 
        { 
            get => _secondNumber; 
             
            set 
            { 
                _secondNumber = value; 
                OnPropertyChanged(nameof(SecondNumber));
            } 
        }

        public float Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public float Addition(float firstValue, float secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber + SecondNumber;
            return Result;
        }

        public float Subtract(float firstValue, float secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber - SecondNumber;
            return Result;
        }

        public float Multiply(float firstValue, float secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber * SecondNumber;
            return Result;
        }

        public float Divide(float firstValue, float secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber / SecondNumber;
            return Result;
        }
    }
}
