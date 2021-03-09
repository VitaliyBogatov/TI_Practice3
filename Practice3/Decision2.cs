using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Decision2
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public int[] SetArrayValues()
        {
            int[] _arr = new int[MaxRange - MinRange];

            for (int i = 0; i < _arr.Length-1; i++)
            {
                _arr[i] = MinRange;
                MinRange++;
            }
            return _arr;
        }

        public int GetValuesDividedThreeNotDividedFive(int[] arr)
        {
            int _result = 0;
            for (int i = 0; i<arr.Length-1; i++)
            {
                int temp = arr[i];
                if ((temp % 3) == 0 && (temp % 5) != 0)
                {
                    _result += temp;
                }
            }
            return _result;
        }
    }
}
