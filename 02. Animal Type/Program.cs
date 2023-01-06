using System;

namespace _02._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                case "dog":
                    Console.WriteLine("mammal");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
