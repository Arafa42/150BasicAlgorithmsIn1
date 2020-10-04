using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening2
    {
        //Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference
        public int AlgoTwo(int nr)
        {
            if(nr > 51) { return (nr - 51) * 3; }
            else { return 51 - nr; }
        }


    }
}
