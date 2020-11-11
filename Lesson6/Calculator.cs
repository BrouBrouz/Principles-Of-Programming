using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Calculator
{
    public class Calculator
    {
        public float valueA;
        public float valueB;
        public string operation;

        public float ValueA { get => valueA; set => valueA = value; }
        public float ValueB { get => valueB; set => valueB = value; }
        public string Operation { get => operation; set => operation = value; }
        
        public string Calculate()
        {
            double calcResult = 0;
            
            switch(Operation)
            {
                case "+":
                    calcResult = ValueA + ValueB;
                    break;
                case "/":
                    if(ValueB == 0)
                    {
                        throw new DivideByZeroException("Value B cannot be 0");
                    }
                    calcResult = ValueA / ValueB;
                    break;
                default:
                    return "Unknown operation";
            }

            return $"{valueA} {Operation} {ValueB} = {calcResult}"; ;
        }
    }
}
