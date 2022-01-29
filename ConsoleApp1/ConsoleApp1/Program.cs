using System;

namespace Program1
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Введіть число » ");
                int n = int.Parse(Console.ReadLine());
                n -= 99 * (n / 100 - n % 10);
                
                Console.WriteLine("\r");
                Console.WriteLine("Результат");
                Console.WriteLine(n);
                
            }
        }
    }
}
