using System;
using System.Collections.Generic;
using System.Text;

namespace Practice3
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.Write("***Practice 3***");
            Console.Write("\nCalculate sum of all integer values of the min-max range those are divided on 3 and not divided on 5.");
            Console.Write("\n\nPlease choose a decision:");
            Console.Write("\n1. User can add as many values as s(he) wants.");
            Console.Write("\n2. User defines min and max values of the range only.");
            Console.Write("\nOption... ");

            int input = Convert.ToInt16(Console.ReadLine());

            
            switch (input)
            {
                case 1:
                    Decision1 desision1 = new Decision1();
                    desision1.SetRange();
                    desision1.AddValues();
                    Console.WriteLine($"Sum of number divide on 3 and not divide on 5: {desision1.GetResult()}");
                    Console.ReadKey();
                    break;
                case 2:
                    Decision2 desision2 = new Decision2();
                    Console.Write("\n\nPlase set min and max value that can be added into the array.");
                    Console.Write("\nMin value:");
                    desision2.MinRange = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Max value:");
                    desision2.MaxRange = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"\nSum of number divide on 3 and not divide on 5: {desision2.GetValuesDividedThreeNotDividedFive(desision2.SetArrayValues())}");
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}
