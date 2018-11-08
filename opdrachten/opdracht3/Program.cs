using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new(string, double)[]{
                ("plat water", 1),
                ("cola 25cl", 1.5),
                ("cola 33cl", 2),
                ("witte wijn", 3),
                ("pils", 2),
                ("toast", 4),
                ("kaasplank", 5)
            };

            foreach(var element in menu){
                Console.WriteLine(element);
            }




            string[,] list = new string[7, 3]{
                {"platwater","1", "1"},
                {"cola 25cl","1,5", "2"},
                {"cola 33cl","2", "3"},
                {"witte wijn","3", "4"},
                {"pils","2", "5"},
                {"Toast","5", "6"},
                {"Kaasplank","4", "7"}
            };

            Console.WriteLine("Enter index");
            string indexString = Console.ReadLine();
            int index = int.Parse(indexString)-1;
            Console.WriteLine(list[index, 0] + ", " + list[index, 1]);

        }
    }
}
