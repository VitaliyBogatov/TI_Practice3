using System;

namespace Practice3
{
    public class Decision2
    {
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

        public int[] SetArrayValues()
        {
            int[] arr = new int[MaxRange - MinRange];

            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = MinRange;
                MinRange++;
            }
            return arr;
        }

        public int GetValuesDividedThreeNotDividedFive(int[] arr)
        {
            int result = 0;
            for (int i = 0; i<arr.Length-1; i++)
            {
                int temp = arr[i];
                if ((temp % 3) == 0 && (temp % 5) != 0)
                {
                    result += temp;
                }
            }
            return result;
        }
    }
}
