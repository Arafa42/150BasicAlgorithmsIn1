using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
    class Oefening10
    {
        public bool AlgoTien(int nr)
        {
            if (nr % 3 == 0 || nr % 7 == 0)
            {
                return true;
            }
            else {return false;}
        }
    }
}