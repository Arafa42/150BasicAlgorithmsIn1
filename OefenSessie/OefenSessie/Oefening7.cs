using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
    class Oefening7
    {
        public string AlgoZeven(string text)
        {
            if (text.Length > 1)
            {
                string firstLetter = text[0].ToString();
                string lastLetter = text.Substring(text.Length - 1);
                return lastLetter + text.Remove(0, 1).Remove(text.Length - 2, 1) + firstLetter;
            }
            else { return text; }
        }
    }
}