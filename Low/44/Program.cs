using System;

namespace _44
{
    class Program
    {
        public static long Fib(int f)
        {
           if(f <= 3)
           {
               return 1;
           }
            return Fib(f - 1) + Fib(f - 2);
        }


        public static long Fac(int f)
        {
            
            int x = f;
            for(int i=f; i>2; i--)
            {
                x *= (i-1);
            }
            return x;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(Fac(n));
        }
        static void Main2(string[] args)
        {
            int f = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(Fib(f));
        }
    }
}

// 0 , 1
