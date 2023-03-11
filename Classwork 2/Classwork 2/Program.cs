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


            if (option == "Show recent currency rates" || option == "1")
            {
                Console.Write("How many currency do you need : ");

                int currencyCount = int.Parse(Console.ReadLine());

                string[] currencies = new string[] { "USD", "TRY", "EUR", "RUB", "CNY", "GEL", "UAH" };
                int idx = 0;

                //string alpha3 = Console.ReadLine();

                //Console.Write("USD, ");
                //Console.Write("TRY, ");
                //Console.Write("EUR, ");
                //Console.Write("RUB, ");
                //Console.Write("CNY, ");
                //Console.Write("GEL, ");
                //Console.Write("UAH.");
                //Console.WriteLine();
                //Console.WriteLine("Which Currency do you need : ");

                Console.WriteLine("Which currency do you need : ");
                string whichCurrency = Console.ReadLine();


                while (idx < currencyCount)
                {


                    if (whichCurrency == "USD")
                    {
                        double aznToUSD = 1.700;
                        Console.WriteLine(aznToUSD);
                    }

                    else if (whichCurrency == "TRY")
                    {
                        double aznToTRY = 0.089;
                        Console.WriteLine(aznToTRY);
                    }

                    else if (whichCurrency == "EUR")
                    {
                        double aznToEUR = 1.80;
                        Console.WriteLine(aznToEUR);
                    }

                    else if (whichCurrency == "RUB")
                    {
                        double aznToRUB = 0.02;
                        Console.WriteLine(aznToRUB);
                    }

                    else if (whichCurrency == "CNY")
                    {
                        double aznToCNY = 0.24;
                        Console.WriteLine(aznToCNY);
                    }

                    else if (whichCurrency == "GEL")
                    {
                        double aznToGEL = 0.65; 
                        Console.WriteLine(aznToGEL);
                    }

                    else if (whichCurrency == "UAH")
                    {
                        double aznToUAH = 0.04;
                        Console.WriteLine(aznToUAH);
                    }

                    idx++;
                }

                Console.WriteLine("Enter your currencies(USD, TRY, EUR, ...) : ");

                while (idx < currencyCount)
                {
                    currencies[idx] = Console.ReadLine();
                    idx++;
                }

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();

                while (idx < currencyCount)
                {
                    Console.WriteLine(currencies[idx]);
                    idx++;
                }

                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Which option do you need : ");
                option = Console.ReadLine();
            }
            else if (option == "Find curreny by code" || option == "2")
            {

            }
            else if (option == "Calculate amount by currency" || option == "3")
            {
                Console.WriteLine("Enter the amount : ");
                decimal amount = decimal.Parse(Console.ReadLine());
            }
            else if (option == "Exit" || option == "4")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error");
            }
            //**********************************************************************************

            //Console.Write("Number Count : ");

            //int numberCount = int.Parse(Console.ReadLine());


            //int[] numbers = new int[numberCount];
            //int fillIDX = 0;


            //Console.WriteLine("Enter you numbers : ");

            //while (fillIDX < numberCount)
            //{
            //    int input = int.Parse(Console.ReadLine());

            //    if (input % 2 == 0)
            //    {
            //        numbers[fillIDX] = 0;
            //    }
            //    else
            //    {
            //        numbers[fillIDX] = -1;
            //    }

            //    fillIDX++;
            //}


            //fillIDX = 0;


            //Console.Write("This is your numbers : ");
            //while (fillIDX < numberCount)
            //{
            //    Console.Write(numbers[fillIDX]);
            //    if (fillIDX < (numberCount - 1))
            //    {
            //        Console.Write(", ");
            //    }
            //    fillIDX++;
            //}
            //Console.WriteLine(".");

        }
    }
}