using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Oriented.Programming
{
    internal class Calculator
    {
        internal int GetRandomNumber(int min,int max)
        {

            return new Random().Next(min, max);
        }
    }
}
