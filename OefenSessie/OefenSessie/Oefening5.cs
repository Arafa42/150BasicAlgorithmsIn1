using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.

    class Oefening5
    {
        public string AlgoVijf(string text)
        {
            if(text.Split(" ")[0] == "if")
            {
                return text;
            }
            else
            {
                return "if " + text;
            }
        }
    }
}
