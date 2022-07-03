using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public static class Power
    {
        public static int CalculatePower(this int num1, int num2)
        {
            int counting = 1;
           
            for (int i = 1; i <= num2; i++)
                counting = counting * num1;

            return counting;

        }
    }
}
