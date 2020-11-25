using System;

namespace Work_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Работа с цифрами числа
            int x = 0, max = 0;
            int idx = 0;

            Print();
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] A = new int[10];

            while(n>0)
            {
                x = n % 10;// выделяем в остаток 
                Console.WriteLine($"Цифра {x}");
                A[x]++;// счет числа совпадений
                idx++;// счет числа цифр

                n = n / 10;
            }

            ArrayPrint(A,10);

            /*
            for (int i=0; i<3; i++)
            {
                x = n % 10;
                Console.WriteLine($"Цифра {x}");
                A[i]++;

                n = n / 10;
            }
            */

            Console.WriteLine();

            for (int i = 0; i < idx; i++)
            {
                // Console.WriteLine(A[i]);

                if (max < x)
                {
                    max = x;
                    
                }

                
            }

            for (int i = 0; i < idx; i++)
                if (A[i]==max)
            
                Console.WriteLine($"Часто поворяемая цифра: {i}={max}");

            Console.ReadKey();
        }

        static void Print() //печать подсказки
        {
            Console.WriteLine("Введите обрабатываемое число:");
        }

        static void ArrayPrint(int[] D, int l) //печать массива
        {
            for (int i = 0; i < l; i++)
                APrint(D[i]);
        }

        static void APrint(int D) //печать 1 эллемента массива
        {
            Console.Write($"{D} ");
        }
    }
}
