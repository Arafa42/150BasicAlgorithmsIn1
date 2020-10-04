using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    // Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
    class Oefening9
    {
        public string AlgoNegen(string text)
        {
            string lastChar = text.Substring(text.Length-1,1);
            return lastChar + text + lastChar;
        }
    }
}