using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening6
    {
        // Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
        public string AlgoZes(string text, int nr)
        {
            return text.Remove(nr,1);
        }
    }
}
