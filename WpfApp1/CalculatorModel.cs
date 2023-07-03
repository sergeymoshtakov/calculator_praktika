using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class CalculatorModel
    {
        private int left_operand;
        private int right_operand;
        private string operation;

        public int Left_operand { get; set; }
        public int Right_operand { get; set; }
        public string Operation { get; set; }

        public int Sum()
        {
            return Left_operand + Right_operand;
        }

        public int Difference()
        {
            return Left_operand - Right_operand;
        }

        public int Multiplication()
        {
            return Left_operand * Right_operand;
        }

        public int Division()
        {
            return Left_operand / Right_operand;
        }
    }
}
