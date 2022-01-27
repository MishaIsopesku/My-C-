using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 654;
            int x = (int)Math.Log10(v) + 1;
            int result = 0;
            for (int i = 0; i < x; i++)
            {
                result = result * 10 + (v % 10);
                v /= 10;
            }
            Console.WriteLine("Результат");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
