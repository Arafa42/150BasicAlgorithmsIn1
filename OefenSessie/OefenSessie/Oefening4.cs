using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening4
    {
        //Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200
        public bool AlgoVier(int nr)
        {
           if((nr >= 90 && nr <= 110) || (nr >= 190 && nr <= 210))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
