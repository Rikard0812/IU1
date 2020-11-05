using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU1
{
    public class InputHandler : Program
    {
        public string firstOperator;
        public string secondOperator;

        public double firstNumber;
        public double secondNumber;
        public double thirdNumber;
        public double Sum;

        double firstSum;
        double secondSum;

        public void GetInput()
        {
            Console.WriteLine("Använd Operatorer + - * eller / ");
            Console.Write("Enter first Operator: ");
            firstOperator = Console.ReadLine();

            Console.Write("Enter second Operator: ");
            secondOperator = Console.ReadLine();

            Console.Write("Enter your first Number: ");
            //string firstNumberString = Console.ReadLine();
            firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter your third Number: ");
            thirdNumber = double.Parse(Console.ReadLine());

        }

        public void DoCalculation()
        {
            if (firstOperator == "*")
            {
                firstSum = firstNumber * secondNumber;
            }

            if (secondOperator == "*" && firstOperator == "*")
            {
                Sum = firstSum * thirdNumber;
            }

            if (secondOperator == "*" && firstOperator != "*")
            {
                secondSum = secondNumber * thirdNumber;
            }

            if (firstOperator == "/" && secondOperator != "*")
            {
                firstSum = firstNumber / secondNumber;
            }

            if (firstOperator == "/" && secondOperator == "*")
            {
                Sum = firstNumber / secondSum;
            }

            if (secondOperator == "/" && firstOperator == "/")
            {
                Sum = firstSum / thirdNumber;
            }

            if (secondOperator == "/" && firstOperator == "*")
            {
                Sum = firstSum / thirdNumber;
            }

            if (secondOperator == "/" && firstOperator != "/")
            {
                secondSum = secondNumber / thirdNumber;
            }

            if (firstOperator == "+")
            {
                firstSum = firstNumber + secondNumber;
            }

            if (firstOperator == "-")
            {
                firstSum = firstNumber - secondNumber;
            }

            if (secondOperator == "+")
            {
                Sum = firstSum + thirdNumber;
            }

            if (secondOperator == "-")
            {
                Sum = firstSum - thirdNumber;
            }

            //Sum = firstSum + secondSum;
            //Console.WriteLine(Sum);
        }

        public void DisplayEquation()
        {
            Console.WriteLine(firstNumber + " " + firstOperator + " " + secondNumber + " " + secondOperator + " " + thirdNumber + " = " + Sum);
        }
    }
}