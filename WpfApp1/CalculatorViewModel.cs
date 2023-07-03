using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        private CalculatorModel model;
        private int result;
        public List<string> Operators { get; } = new List<string> { "+", "-", "*", "/" };

        public CalculatorViewModel()
        {
            model = new CalculatorModel { Left_operand = 1, Operation = "+", Right_operand = 1 };
        }

        public int Left_operand
        {
            get { return model.Left_operand; }
            set
            {
                model.Left_operand = value;
                OnPropertyChanged("Left_operand");
            }
        }

        public int Right_operand
        {
            get { return model.Right_operand; }
            set
            {
                model.Right_operand = value;
                OnPropertyChanged("Right_operand");
            }
        }

        public string Operation
        {
            get { return model.Operation; }
            set
            {
                model.Operation = value;
                OnPropertyChanged("Operation");
            }
        }

        public int Result
        {
            get { return Calculate(model.Operation); }

            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        public int Calculate(string selectedOperator)
        {
            switch (selectedOperator)
            {
                case "+":
                    return model.Sum();
                case "-":
                    return model.Difference();
                case "*":
                    return model.Multiplication();
                case "/":
                    return model.Division();
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
