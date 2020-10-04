using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening8
    {
        //Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. 
        public string AlgoAcht(string text)
        {
            int len = text.Length;

            if(len > 2)
            {
                string t = "";
                for (int i = 0; i < 4; i++)
                {
                   t += text.Substring(0,2);
                }
                return t;
            }
            else
            {
                return text;
            }        
        }
    }
}