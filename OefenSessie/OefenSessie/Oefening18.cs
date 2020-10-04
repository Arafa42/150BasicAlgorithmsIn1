using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    //Write a C# Sharp program to check the largest number among three given integers.
    class Oefening18
    {
        public int AlgoAchtien(int nrEen,int nrTwee,int nrDrie)
        {
          return  Math.Max(nrEen, Math.Max(nrTwee, nrDrie));
        }
    }
}
