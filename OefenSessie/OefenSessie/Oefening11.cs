using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    //write a c# sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. if the given string length is less than 3, use whatever characters are there.
    class Oefening11
    {
        public string AlgoElf(string text)
        {
            if(text.Length >= 3)
            {
                string first3Chars = text.Substring(0,3);
                return first3Chars + text + first3Chars; 
            }
            else { return text + text + text; }
        }
    }
}