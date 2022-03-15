using System;
using System.Text;

namespace NumbReverseNet50
{
    public static class NumbReverse
    {
        public static int Reverse(int n)
        {
            int x = (int)Math.Log10(n) + 1;
            int result = 0;
            for (int i = 0; i < x; i++)
            {
                result = result * 10 + (n % 10);
                n /= 10;
            }

            Console.Write("\n Ваші числа наоборот: {0}", result);
            return result;
        }

        /** 
        * Виведення результату програми
        */
        static void Main()
        {
            
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Write("\n Напишіть свої числа: ");
            string S1 = Console.ReadLine();
            int v = int.Parse(S1);
            Reverse(v);

            Console.Write("\n Нажміть будь-яку літеру щоб вийти: ");
            Console.ReadLine();

        }

   
    }
}
