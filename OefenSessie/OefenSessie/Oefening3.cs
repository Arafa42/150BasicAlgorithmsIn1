using System;
using System.Collections.Generic;
using System.Text;

namespace OefenSessie
{
    class Oefening3
    {

        //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        public bool AlgoDrie(int nrEen, int nrTwee)
        {
            if(nrEen == 30 || nrTwee == 30 || (nrEen + nrTwee) == 30)
            {
                return true;
            }
            else { return false; }
        }
    }
}