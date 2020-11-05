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
            Console.WriteLine("Klicka på valfri knapp för att göra Beräkning.");
            Console.WriteLine("ELLER tryck ESC för att avsluta");

            Choice = Convert.ToString(Console.ReadKey(true).Key);
        }
    }
}