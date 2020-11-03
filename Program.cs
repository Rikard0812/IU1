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
    
            bool writeMenu = true;
            if (writeMenu)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("     Calculator");
                Console.WriteLine("---------------------");
                writeMenu = false;
            }

            myInput.GetInput();
            myInput.DoCalculation();
        }
    }
}