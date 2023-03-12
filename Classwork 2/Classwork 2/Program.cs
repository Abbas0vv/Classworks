namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = new string[] { "USD", "TRY", "EUR", "RUB", "CNY", "GEL", "UAH" };
            double[] currenciesPrices = new double[] { 1.7000, 0.0898, 1.8011, 0.0224, 0.2441, 0.6561, 0.0460 };
            int currencyCount = currencies.Length;
            int whileNumber = currencies.Length;
            string alpha3;
            int number = 0;
            int idx = 0;
            int newInt = currencies.Length;



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

            while (true)
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

                    Console.Write("Which option do you need : ");
                    option = Console.ReadLine();
                }
                else if (option == "2" || option == "Find curreny by code")
                {
                    idx = 0;
                    number = 0;
                    alpha3 = currencies[idx];
                    whileNumber = currencies.Length;

                    Console.Write("Please write you alpha3 code : ");
                    alpha3 = Console.ReadLine();


                    if (alpha3 != currencies[idx])
                    {
                        Console.WriteLine("This currency is not available");
                    }

                    while (currencies.Length > idx)
                    {
                        if (alpha3 == currencies[idx])
                        {
                            idx = number;

                            Console.WriteLine("AZN to " + currencies[idx] + " = " + currenciesPrices[idx]);
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            idx++;
                            number++;
                        }
                    }

                    Console.Write("Which option do you need : ");
                    option = Console.ReadLine();

                }
                else if (option == "3" || option == "Calculate amount by currency")
                {

                    idx = 0;
                    number = 0;
                    whileNumber = currencies.Length;

                    Console.Write("Please, first, write your amount : ");

                    double amountOfAZN = double.Parse(Console.ReadLine());


                    Console.Write("Now, write which currency do yo need : ");

                    alpha3 = Console.ReadLine();



                    while (currencies.Length > idx)
                    {
                        if (alpha3 == currencies[idx])
                        {
                            idx = number;

                            Console.WriteLine("AZN to " + currencies[idx] + " = " + amountOfAZN / currenciesPrices[idx]);
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            idx++;
                            number++;
                        }
                    }
                    Console.Write("Which option do you need : ");
                    option = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Program stopped working.");
                    Console.WriteLine();
                }
            }
        }
    }
}