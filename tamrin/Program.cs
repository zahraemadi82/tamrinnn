using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            int[] numbers = new int[50];
            Console.WriteLine("Enter 50 numbers:");

            for (int i = 0; i < 50; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < 50; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            int sum = max + min;
            int name  = max - min;

            Console.WriteLine("The maximum number is: " + max);
            Console.WriteLine("The minimum number is: " + min);
            Console.WriteLine("The sum of the maximum and minimum numbers is: " + sum);
            Console.WriteLine("The name between the maximum and minimum numbers is: " + name);
        }
    }
}
