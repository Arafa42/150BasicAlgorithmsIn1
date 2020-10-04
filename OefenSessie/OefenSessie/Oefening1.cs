using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening1
    {
        //Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum
        public int AlgoOne(int nrEen, int nrTwee)
        {
            if (nrEen == nrTwee)
            {
                return (nrEen + nrTwee) * 3;
            }
            else
            {
                return nrEen + nrTwee;
            }
        }
    }
}
