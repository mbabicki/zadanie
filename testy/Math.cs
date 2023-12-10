using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testy
{
    public class MyFunctions
    {
        public int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }

}
