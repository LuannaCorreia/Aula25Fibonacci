using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Fibonacci rec = new Fibonacci();
            rec.GerarSequeunciaDeFibonacci(0,3,37);
            System.Console.WriteLine(rec.GerarFatorial(23));
        }
    }
}