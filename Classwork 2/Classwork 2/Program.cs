namespace Classwork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. ");
            Console.WriteLine("Show recent currency rates");

            Console.Write("2. ");
            Console.WriteLine("Find curreny by code");

            Console.Write("3. ");
            Console.WriteLine("Calculate amount by currency");

            Console.Write("4. ");
            Console.WriteLine("Exit");

            Console.WriteLine("--------------------------------------------------------");

            Console.Write("Which option do you need : ");
            string option = Console.ReadLine();



            double[] currenciesPrices = new double[] { 1.7000, 0.0898, 1.8011, 0.0224, 0.2441, 0.6561, 0.0460 };
            string[] currencies = new string[] { "USD", "TRY", "EUR", "RUB", "CNY", "GEL", "UAH" };
            int currencyCount = currencies.Length;
            int idx = 0;



            while (option == "1" || option == "Show recent currency rates")
            {
                if (option == "Show recent currency rates" || option == "1")
                {

                    while (idx < currencyCount)
                    {
                        Console.WriteLine("AZN to " + currencies[idx] + " = " + currenciesPrices[idx]);
                        idx++;
                    }

                    idx = 0;

                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine();

                }
                Console.Write("Which option do you need : ");
                option = Console.ReadLine();
                if (option == "2" || option == "Find curreny by code" ||
                    option == "3" || option == "Calculate amount by currency" ||
                    option == "4" || option == "Exit")
                {
                    break;
                }
            }

            idx = 0;
            int whileNumber = currencies.Length;
            string alpha3 = currencies[idx];

            while (option == "2" || option == "Find currency by code")
            {
                Console.Write("Please write you alpha3 code : ");
                alpha3 = Console.ReadLine();

                if (alpha3 == "USD")
                {
                    idx = 0;
                }
                else if (alpha3 == "TRY")
                {
                    idx = 1;
                }
                else if (alpha3 == "EUR")
                {
                    idx = 2;
                }
                else if (alpha3 == "RUB")
                {
                    idx = 3;
                }
                else if (alpha3 == "CNY")
                {
                    idx = 4;
                }
                else if (alpha3 == "GEL")
                {
                    idx = 5;
                }
                else if (alpha3 == "UAH")
                {
                    idx = 6;
                }

                Console.WriteLine("AZN to " + currencies[idx] + " = " + currenciesPrices[idx]);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Which option do you need : ");
                option = Console.ReadLine();
                if (option == "2" || option == "Find curreny by code" ||
                    option == "3" || option == "Calculate amount by currency" ||
                    option == "4" || option == "Exit")
                {
                    break;
                }
            }

            idx = 0;
            while (option == "3" || option == "Calculate amount by currency")
            {
                Console.Write("Please, first, write your amount : ");

                double amountOfAZN = double.Parse(Console.ReadLine());


                Console.Write("Now, write which currency do yo need : ");

                alpha3 = Console.ReadLine();


                if (alpha3 == "USD")
                {
                    idx = 0;
                }
                else if (alpha3 == "TRY")
                {
                    idx = 1;
                }
                else if (alpha3 == "EUR")
                {
                    idx = 2;
                }
                else if (alpha3 == "RUB")
                {
                    idx = 3;
                }
                else if (alpha3 == "CNY")
                {
                    idx = 4;
                }
                else if (alpha3 == "GEL")
                {
                    idx = 5;
                }
                else if (alpha3 == "UAH")
                {
                    idx = 6;
                }


                Console.WriteLine("AZN to " + currencies[idx] + " = " + amountOfAZN / currenciesPrices[idx] );
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Which option do you need : ");
                option = Console.ReadLine();
                if (option == "2" || option == "Find curreny by code" ||
                    option == "3" || option == "Calculate amount by currency" ||
                    option == "4" || option == "Exit")
                {
                    break;
                }
            }
        }
    }
}
