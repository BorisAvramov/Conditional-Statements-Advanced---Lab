using System;

namespace _08._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qauntityFruit = double.Parse(Console.ReadLine());
            double priceBanana = 0;
            double priceApple = 0;
            double priceOrange = 0;
            double priceGrapefruit = 0;
            double priceKiwi = 0;
            double pricePineapple = 0;
            double priceGrapes = 0;
            double result = 0;


            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    priceBanana = 2.50;
                    priceApple = 1.20;
                    priceOrange = 0.85;
                    priceGrapefruit = 1.45;
                    priceKiwi = 2.70;
                    pricePineapple = 5.50;
                    priceGrapes = 3.85;
                    break;
                case "Saturday":
                case "Sunday":
                    priceBanana = 2.70;
                    priceApple = 1.25;
                    priceOrange = 0.90;
                    priceGrapefruit = 1.60;
                    priceKiwi = 3.00;
                    pricePineapple = 5.60;
                    priceGrapes = 4.20;
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            switch (fruit)
            {
                case "banana":
                    result = qauntityFruit * priceBanana;
  
                    break;                
                case "apple":
                    result = qauntityFruit * priceApple; break;                
                case "orange":
                    result = qauntityFruit * priceOrange; break;                
                case "grapefruit":
                    result = qauntityFruit * priceGrapefruit; break;                
                case "kiwi":
                    result = qauntityFruit * priceKiwi; break;                
                case "pineapple":
                    result = qauntityFruit * pricePineapple; break;                
                case "grapes":
                    result = qauntityFruit * priceGrapes; break;

               
                default:
                    Console.WriteLine("error");
                    break;
            }
       
            Console.WriteLine($"{result:f2}");
        }
    }
}
