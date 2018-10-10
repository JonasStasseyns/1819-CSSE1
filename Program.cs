using System;

namespace _1819_CSSE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worlds!");
            Console.WriteLine("test");
        
            int a = 5;
            int b = 6;
            int resultaat1 = optellen(a, b);
            int resultaat2 = deling(a, b);
            int resultaat3 = verhogen(a);
        }
        static int optellen(int a, int b){
                return a+b;
        }

        static int deling(int a, int b){
            return a/b;
        }

        static int verhogen(int a){
            return a++;
        }
    }
}
