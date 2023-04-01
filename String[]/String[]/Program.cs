namespace String__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            //Console.Write("Please write your name : ");
            //string name = Console.ReadLine()!;
            //Console.WriteLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letters = name[i];
            //    Console.WriteLine(name[i]);
            //}

            //task 2

            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


            //Console.Write("Please write your name : ");
            //string name = Console.ReadLine()!;

            //Console.WriteLine();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letters = name[i];
            //}

            //bool check = false;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int a = 0; a < name.Length; a++)
            //    {
            //        if (name[i] == numbers[a])
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        break;
            //    }
            //}

            //if (check)
            //{
            //    Console.WriteLine("Error");
            //}
            //else if (!check)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        Console.WriteLine(name[i]);
            //    }
            //}

            //task 3

            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
            //                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            //                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Console.Write("Please write your name : ");
            //string name = Console.ReadLine()!;

            //Console.WriteLine();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letters = name[i];
            //}

            //bool check = false;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int a = 0; a < name.Length; a++)
            //    {
            //        if (name[i] == uppercaseLetters[a] || name[i] == lowerLetters[a])
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        break;
            //    }
            //}

            //if (check)
            //{
            //    Console.WriteLine("Error");
            //}
            //else if (!check)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        Console.WriteLine(name[i]);
            //    }
            //}

            //task 4

            //Console.Write("Pls write something : ");
            //string name = Console.ReadLine();
            //int Length = name.Length;

            //for (int i = 0; i < Length; i++)
            //{
            //    char letters = name[i];
            //}

            //for (int i = 0; i < Length; Length--)
            //{
            //    Console.WriteLine(name[Length - 1]);
            //}

            //task 5

            //Console.Write("Pls write sentences : ");
            //string name = Console.ReadLine()!;
            //string x = "";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    x += name[i];
            //    if (name[i] == ' ' || i == name.Length - 1)
            //    {
            //        Console.WriteLine(x);
            //        x = null;
            //    }
            //}

            //task 6

            //Console.WriteLine("Pls write your number : ");
            //string number = Console.ReadLine()!;

            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(number[i]);
            //}

            //task 7

            Console.WriteLine("Pls write your number : ");
            string number = Console.ReadLine()!;
            string word = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                word += number[i];
                Console.Write(word);
                if (false)//davami yazilmalidi!!!
                {

                }
            }
        }
    }
}