using System;
using System.Collections.Generic;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is .net class!");
            Console.WriteLine("------------------- \n");

            //Getting user's info
            var name = "";
            var age = 0;

            Console.Write("Please enter your first name: ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"{name}, please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Declaring currencies and initializing their current values
            var euro = 0.88;
            var yen = 109.61;
            var yuan = 6.79;
            var nrs = 113.43;
            var peso = 19.02;
            var usd = 0.0;

            //var is strongly-typed and not dynamically-typed

            var canConvert = false;
            //var exit = 'q';


            while (!canConvert)
            {

                Console.Write("Enter an amount in USD to convert and press Enter: ");
                usd = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                //Asking the user the currency they want top convert to
                Console.WriteLine("Choose the currency you want to convert to or press q to quit: ");
                Console.WriteLine("\t ------------------");
                Console.WriteLine("\t eu - Euro"); 
                Console.WriteLine("‎\t ye - Japanese Yen"); 
                Console.WriteLine("‎\t yu - Chinese Yuan"); 
                Console.WriteLine("‎\t nr - Nepalese Rupee"); 
                Console.WriteLine("\t ps - Mexican Peso");
                Console.WriteLine("\t ------------------");
                var str = Console.ReadLine();
                Console.WriteLine();
                
                if (str == "q")
                {
                    Console.WriteLine($"Thank you for using our services {name} and safe travels!\n");
                    break;
                }

                else
                {
                    //Switch
                    switch (str)
                    {
                        case "eu":
                            Console.WriteLine($"${usd} in Euros is " + (usd * euro) + " euros\n");
                            break;

                        case "ye":
                            Console.WriteLine($"${usd} in Japanese Yen is " + (usd * yen) + " yen\n");
                            break;

                        case "yu":
                            Console.WriteLine($"${usd} in Chinese Yuan is " + (usd * yuan) + " yuan\n");
                            break;

                        case "nr":
                            Console.WriteLine($"${usd} in Nepalese Rupee is " + (usd * nrs) + " rupees\n");
                            break;

                        case "ps":
                            Console.WriteLine($"${usd} in Mexican Peso is: " + (usd * peso) + " pesos\n");
                            break;

                        default:
                            Console.WriteLine();
                            break;
                    }
                }

            }
            return;
        }
    }
}
