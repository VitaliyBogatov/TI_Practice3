using System;

namespace Practice3
{
    public class Task
    {
        static void Main(string[] args)
        {
            Console.Write("***Practice 3***");
            Console.Write("\nCalculate sum of all integer values of the min-max range those are divided on 3 and not divided on 5.");
            Console.Write("\n\nPlease choose an option:");
            Console.Write("\n1. User can add as many values as s(he) wants.");
            Console.Write("\n2. User defines min and max values of the range only.");
            Console.Write("\nOption... ");

            int option = 0;
            bool success = false;

            while (!success)
            {
                if (Int32.TryParse((Console.ReadLine()), out option) && (option == 1 || option == 2))
                {
                        success = true;
                }
                else
                {
                    Console.Write("\n\nPlease choose a valid option... ");
                }
            }


            switch (option)
            {
                case 1:
                    Decision1 desision1 = new Decision1();
                    desision1.SetRange();
                    desision1.AddValues();
                    Console.WriteLine($"Sum of number divide on 3 and not divide on 5: {desision1.GetResult()}");

                    break;
                case 2:
                    Decision2 desision2 = new Decision2();
                    desision2.SetRange();

                    Console.WriteLine($"\nSum of number divide on 3 and not divide on 5: {desision2.GetValuesDividedThreeNotDividedFive(desision2.SetArrayValues())}");

                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("Please enter a value to finish...");
            Console.Read();
        }
    }
}
