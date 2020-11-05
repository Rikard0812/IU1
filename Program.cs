using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU1
{
    public class Program
    {
        static void Main()
        {
            InputHandler myInput = new InputHandler();
            ChoiceHandler DoChoice = new ChoiceHandler();

            bool writeMenu = true;

            while (true)
            {
                if (writeMenu)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("   Equation Solver");
                    Console.WriteLine("---------------------");
                    writeMenu = false;
                }

                DoChoice.DisplayCoice();

                if (DoChoice.Choice == "Escape")
                {
                    Environment.Exit(0);
                }

                myInput.GetInput();
                myInput.DoCalculation();
                myInput.DisplayEquation();
            }

        }
    }
}