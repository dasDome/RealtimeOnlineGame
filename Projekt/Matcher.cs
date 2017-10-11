using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Projekt
{
    class Matcher<T>
    {
        public Matcher() { }

        public Boolean matches(Object element)
        {
            return false;/// prüft, ob das obj der methode dem des Konstruktors entspricht
        }

        public void ismatch(Object input){

            
            /*Regex regName = new Regex(@"^[a-zA-Z]+$");
            Regex regNummer = new Regex(@"^[0-9]+$");
            //Regex myRegex = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (regName.IsMatch(input))
            {
                Console.WriteLine("name");
            }
            if (regNummer.IsMatch(input))
            {
                Console.WriteLine("Nummer");
            }*/
        }

    }
}
