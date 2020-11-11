using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager.CreatePersonList(3);
            TestCalculator();
            Console.ReadKey();
        }

        private static void TestCalculator()
        {
            Console.Write("Value A: ");

            if (!float.TryParse(Console.ReadLine(), out float valueA))
            { 
                Console.WriteLine("incorrect value A!");
                Console.ReadLine();
                return;
            }

            Console.Write("Value B: ");

            if (!float.TryParse(Console.ReadLine(), out float valueB))
            {
                Console.WriteLine("incorrect value B!");
                Console.ReadLine();
                return;
            }

            Console.Write("Operation ('+', '/'):");

            string operation = Console.ReadLine();

            Calculator.Calculator calculator = new Calculator.Calculator
            {
                ValueA = valueA,
                ValueB = valueB,
                Operation = operation
            };

            try
            {
                string calcResult = calculator.Calculate();
                Console.WriteLine(calcResult);
            }
            catch (Exception ex)
            {
                Console.Write("Calculator.Calculate thrown an error : " + ex.Message);
            }

        }
    }
}
