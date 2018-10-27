using System;

namespace _1_vermenigvuldiging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to multiply");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<11;i++){
                Console.WriteLine("-");
                Console.WriteLine(i*number);
            }
        }
    }
}
