using System;

namespace Program1{ 
    
    class Program{
        
    public static void Main(){
        
    while (true) { Console.Write("n » ");
    int n = int.Parse(Console.ReadLine());
    n -= 99 * (n / 100 - n % 10);
    Console.WriteLine(n); 
   } 
  } 
 } 
}
