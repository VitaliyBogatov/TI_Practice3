using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Decision1
    {
        List<int> _list = new List<int>();

        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public void SetRange()
        {
            Console.WriteLine("Plase set min and max value that can be added into the array.");
            Console.WriteLine("Min value:");
            MinRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max value:");
            MaxRange = Convert.ToInt32(Console.ReadLine());
        }

        public void AddValues()
        {
            while (true)
            {
                Console.WriteLine($"Type a number between {MinRange} and {MaxRange} or click enter to see results");
                String input = Console.ReadLine();

                if (int.TryParse(input, out int val) == true && (val >= MinRange && val <= MaxRange))
                {
                    _list.Add(val);
                }
                else if (int.TryParse(input, out int j) && j < MinRange || j > MaxRange)
                {
                    Console.WriteLine($"Value {j} is out of range {MinRange} and {MaxRange}");
                }
                else
                {
                    break;
                }
            }
        }

        public int GetResult()
        {
            int _result = 0;

            foreach (int element in _list)
            {
                if ((element % 3) == 0 && (element % 5) != 0)
                {
                    _result += element;
                }
            }
            return _result;
        }
    }   
}
