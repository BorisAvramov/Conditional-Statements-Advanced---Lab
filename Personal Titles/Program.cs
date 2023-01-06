using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = .Parse(Console.ReadLine());

            string sex = Console.ReadLine();

            if (sex == "f")
            {
                if (age <16)
                {
                    Console.WriteLine("Miss");
                }
                else if (age >=16)
                {
                    Console.WriteLine("Ms.");
                }
            }
            if (sex == "m")
            {
                if (age<16)
                {
                    Console.WriteLine("Master");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
