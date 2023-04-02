using System.Xml.Linq;

namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Checking user's name is correct or not
            Console.Write("Name : ");
            string name = Console.ReadLine()!;
            bool check = CheckName(name);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your name correctly! (First letter must be uppercase)");
                Console.Write("Name : ");
                name = Console.ReadLine()!;
                check = CheckName(name);
            }

            Console.WriteLine("------------------------------------------------");

            //Checking user's surname is correct or not
            Console.Write("Surname : ");
            string surname = Console.ReadLine()!;
            check = CheckSurname(surname);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your surname correctly! (First letter must be uppercase)");
                Console.Write("Surname : ");
                surname = Console.ReadLine()!;
                check = CheckSurname(surname);
            }

            Console.WriteLine("------------------------------------------------");

            //Checking user's father's name is correct or not
            Console.Write("Father's name : ");
            string fathersName = Console.ReadLine()!;
            check = CheckFathersName(fathersName);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your Father's name correctly! (First letter must be uppercase)");
                Console.Write("Father's name : ");
                fathersName = Console.ReadLine()!;
                check = CheckFathersName(fathersName);
            }

            Console.WriteLine("------------------------------------------------");

            //Checking user's age is correct or not
            Console.Write("Age : ");
            int age = 0;
            try
            {
                age = int.Parse(Console.ReadLine()!);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            check = CheckAge(age);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your age correctly! (18 < your age < 65)");
                Console.Write("Age : ");
                age = int.Parse(Console.ReadLine()!);
                check = CheckAge(age);
            }
            Console.WriteLine("------------------------------------------------");

            //Checking user's FIN code is correct or not
            Console.Write("FIN code : ");
            string FINcode = Console.ReadLine()!;
            check = CheckFINcode(FINcode);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your FIN code correctly! (Only upper letters - Leng. = 7)");
                Console.Write("FIN code : ");
                FINcode = Console.ReadLine()!;
                check = CheckFINcode(FINcode);
            }
            Console.WriteLine("------------------------------------------------");

            //Checking user's phone number is correct or not
            Console.Write("Phone number : ");
            string phoneNumber = Console.ReadLine()!;
            check = CheckPhoneNumber(phoneNumber);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Please write your phone number correctly! ( Start with '+994' - Leng. = 13 )");
                Console.Write("Phone number : ");
                phoneNumber = Console.ReadLine()!;
                check = CheckPhoneNumber(phoneNumber);
            }
            Console.WriteLine("------------------------------------------------");

            //Checking user's position
            Console.Write("Position : ");
            string position = Console.ReadLine()!;
            check = CheckPosition(position);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, your position is not suitable for our requirements");
                Console.Write("Position : ");
                position = Console.ReadLine()!;
                check = CheckPosition(position);
            }

            Console.WriteLine("------------------------------------------------");

            //Checking user's income
            Console.Write("Income : ");
            int income = int.Parse(Console.ReadLine()!);
            check = CheckIncome(income);

            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, your income must be between 1500 and 5000");
                Console.WriteLine("Income : ");
                income = int.Parse(Console.ReadLine()!);
                check = CheckIncome(income);
            }

            //If all datas are correct user will see that
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sucessfully Completed!");
            Console.WriteLine($"{name} {surname} {fathersName}, Age : {age}, Phone number : {phoneNumber}, Position {position}");
        }
        static bool CheckName(string name)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (name[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            if (2 < name.Length && name.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (name[0] == uppercaseLetters[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static bool CheckSurname(string surname)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < surname.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (surname[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            if (2 < surname.Length && surname.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (surname[0] == uppercaseLetters[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
            return true;
        }
        static bool CheckFathersName(string fathersName)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < fathersName.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (fathersName[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            if (2 < fathersName.Length && fathersName.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (fathersName[0] == uppercaseLetters[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static bool CheckAge(int age)
        {
            if (age < 18 || age >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckFINcode(string FINcode)
        {
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            if (FINcode.Length == 7)
            {
                for (int i = 0; i < FINcode.Length; i++)
                {
                    for (int j = 0; j < lowerLetters.Length; j++)
                    {
                        if (FINcode[i] == lowerLetters[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            return true;
        }
        static bool CheckPhoneNumber(string phoneNumber)
        {
            if (phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
            {
                if (phoneNumber.Length == 13)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        static bool CheckPosition(string position)
        {
            if (position == "HR" || position == "Audit" || position == "Engineer")
            {
                return false;
            }
            return true;
        }
        static bool CheckIncome(int money)
        {
            if (money < 1500 || money > 5000)
            {
                return true;
            }
            return false;
        }
    }
}