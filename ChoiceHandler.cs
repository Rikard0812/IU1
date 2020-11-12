using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU1
{
    public class ChoiceHandler: Program
    {
        public string Choice;

        public void DisplayCoice()
        {
            Console.WriteLine("Click a Random button to start a Calculation.");
            Console.WriteLine("OR Click on ESC to Exit");

            Choice = Convert.ToString(Console.ReadKey(true).Key);
        }
    }
}