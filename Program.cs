using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaring currencies and initializing their current values
            var euro = 0.88;
            var yen = 109.78;
            var yuan = 6.78;
            var nrs = 113.65;

            var newamount = 0; //var is strongly-typed and not dynamically-typed

            var usd = 0.0;

            var canConvert = false;
            var exit = 'q';


            while (!canConvert)
            {
                //Asking the user for a usd value
                Console.WriteLine("Enter an amount in USD to convert and press Enter: ");
                usd = Convert.ToDouble(Console.ReadLine());

                //Asking the user the currency they want top convert to
                Console.WriteLine("Choose the currency you want to convert to or press q to quit: ");
                Console.WriteLine("\teu - Euro (€)");
                Console.WriteLine("‎\tye - Yen (¥)‎");
                Console.WriteLine("‎\tyu - Yuan (元)‎");
                Console.WriteLine("‎\tnr - Nepalese Rupees (Rs.)");
                Console.WriteLine("‎");

                //Switch
                switch (Console.ReadLine())
                {
                    case "eu":
                        Console.WriteLine($"${usd} in Euros is: €" + (usd * euro));
                        break;

                    case "ye":
                        Console.WriteLine($"${usd} in Yen is: ¥" + (usd * yen));
                        break;

                    case "yu":
                        Console.WriteLine($"${usd} in Yuan is: 元" + (usd * yuan));
                        break;

                    case "nr":
                        Console.WriteLine($"${usd} in Nrs is: 元" + (usd * nrs));
                        break;

                    case "q":
                        break;
                }

            }
            return;
        }
    }
}
