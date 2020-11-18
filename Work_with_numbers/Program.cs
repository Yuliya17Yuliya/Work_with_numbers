using System;

namespace Work_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, max = 0;
            // int idx = 0;

            Console.WriteLine("Введите обрабатываемое число:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] A = new int[17];

            for (int i=0; i<3; i++)
            {
                x = n % 10;
                Console.WriteLine($"Цифра {x}");
                A[i]++;

                n = n / 10;
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                // Console.WriteLine(A[i]);

                if (max < x)
                {
                    max = x;
                    
                }

            }

            Console.WriteLine();

            Console.WriteLine($"Часто поворяемая цифра: {max}");

            Console.ReadKey();

        }
    }
}
