using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency Converter");
            Console.WriteLine("------------------- \n");
            //Declaring currencies and initializing their current values
            var euro = 0.88;
            var yen = 109.78;
            var yuan = 6.78;
            var nrs = 113.65;

            //var newamount = 0; //var is strongly-typed and not dynamically-typed

            var usd = 0.0;

            var canConvert = false;
            //var exit = 'q';


            while (!canConvert)
            {
                //Asking the user for a usd value
                Console.Write("Enter an amount in USD to convert and press Enter: ");
                usd = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                //Asking the user the currency they want top convert to
                Console.WriteLine("Choose the currency you want to convert to or press q to quit: ");
                
                Console.WriteLine("\t eu - Euro"); //(€)");
                Console.WriteLine("‎\t ye - Yen"); //(¥)‎");
                Console.WriteLine("‎\t yu - Yuan"); //(元)‎");
                Console.WriteLine("‎\t nr - Nepalese Rupees"); //(Rs.)");
                Console.WriteLine("‎");
        
                var str = Console.ReadLine();
                if (str == "q")
                {
                    Console.WriteLine("Safe travels!");
                    break;
                }

                else
                {
                    //Switch
                    switch (str)
                    {
                        case "eu":
                            Console.WriteLine($"${usd} in Euros is: " + (usd * euro) + " euros");
                            break;

                        case "ye":
                            Console.WriteLine($"${usd} in Yen is: " + (usd * yen) + " yen");
                            break;

                        case "yu":
                            Console.WriteLine($"${usd} in Yuan is: " + (usd * yuan) + " yuan");
                            break;

                        case "nr":
                            Console.WriteLine($"${usd} in Nrs is: " + (usd * nrs) + " rupees");
                            break;

                        default:
                            break;
                    }
                }

            }
            return;
        }
    }
}
