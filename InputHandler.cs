using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU1
{
    public class InputHandler: Program
    {
        public string firstOperator;
        public string secondOperator;

        public int firstNumber;
        public int secondNumber;
        public int thirdNumber;

        public void GetInput ()
        {
            Console.Write("Enter first Operator: ");
            firstOperator = Console.ReadLine();

            Console.Write("Enter second Operator: ");
            secondOperator = Console.ReadLine();

            Console.Write("Enter your first Number: ");
            //string firstNumberString = Console.ReadLine();
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your third Number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstOperator + secondOperator + firstNumber + secondNumber + thirdNumber);
        }

        public void DoCalculation()
        {
            Console.WriteLine("hej" + firstNumber);
        }
    }
}