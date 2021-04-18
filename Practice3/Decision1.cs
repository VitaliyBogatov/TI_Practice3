using System;
using System.Collections.Generic;

namespace Practice3
{
    public class Decision1
    {
        List<int> _list = new List<int>();

        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public void SetRange()
        {
            Console.WriteLine("Plase set min and max value that can be added into the array.");
            Console.Write("Min Value: ");

            bool success = false;
            MinRange = Int32.MinValue;
            while (!success)
            {
                if (Int32.TryParse(Console.ReadLine(), out int value))
                {
                    MinRange = value;
                    success = true;
                }
                else
                {
                    Console.Write("Input value is not an integer. Plese enter a valid Min Value: ");
                }

            }

            Console.Write("Max Value: ");
            success = false;
            MaxRange = Int32.MinValue;
            while (!success)
            {
                if (Int32.TryParse(Console.ReadLine(), out int value))
                {
                    MaxRange = value;
                    if (MaxRange >= MinRange+10)
                    {
                        success = true;
                    }
                    else
                    {
                        Console.Write($"Max Value must be at least {MinRange + 10}. Plese enter a valid Max Value: ");
                    }
                }
                else
                {
                    Console.Write("Input value is not an integer. Plese enter a valid Max Value: ");
                }
            }

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
                else if (int.TryParse(input, out int j) && (j < MinRange || j > MaxRange))
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
            int result = 0;

            foreach (int element in _list)
            {
                if ((element % 3) == 0 && (element % 5) != 0)
                {
                    result += element;
                }
            }
            return result;
        }
    }   
}
