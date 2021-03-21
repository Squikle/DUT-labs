using Lab_12.Interfaces;

namespace Lab_12.Entities
{
    public class ResultOperation : IOperation
    {
        public double Operate(double firstOperand, double secondOperand)
            => firstOperand / secondOperand;
    }
}