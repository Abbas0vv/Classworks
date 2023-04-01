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
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your name correctly!");
                    Console.Write("Name : ");
                    name = Console.ReadLine()!;
                    check = CheckName(name);
                }
            } while (check);

            Console.WriteLine();

            //Checking user's surname is correct or not
            Console.Write("Surname :");
            string surname = Console.ReadLine()!;
            check = CheckSurname(surname);
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your surname correctly!");
                    Console.Write("Surname : ");
                    surname = Console.ReadLine()!;
                    check = CheckSurname(surname);
                }
            } while (check);

            Console.WriteLine();

            //Checking user's father's name is correct or not
            Console.Write("Father's name : ");
            string fathersName = Console.ReadLine()!;
            check = CheckFathersName(fathersName);
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your Father's name correctly!");
                    Console.Write("Father's name : ");
                    surname = Console.ReadLine()!;
                    check = CheckFathersName(fathersName);
                }
            } while (check);

            Console.WriteLine();

            //Checking user's age is correct or not
            Console.Write("Age : ");
            int age = 0;
            try
            {
                age = int.Parse(Console.ReadLine()!);
            }
            catch (Exception e)
            {
                Console.WriteLine("Write your age correctly!");
                throw;
            }

            check = CheckAge(age);
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your age correctly!");
                    Console.Write("Age :");
                    age = int.Parse(Console.ReadLine()!);
                    check = CheckAge(age);
                }

            } while (check);
            Console.WriteLine();

            //Checking user's FIN code is correct or not
            Console.Write("FIN code :");
            string FINcode = Console.ReadLine()!;
            check = CheckFINcode(FINcode);
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your FIN code correctly!");
                    Console.Write("FIN code : ");
                    FINcode = Console.ReadLine()!;
                    check = CheckFINcode(FINcode);
                }
            } while (check);
            Console.WriteLine();

            //Checking user's phone number is correct or not
            Console.Write("Phone number : ");
            string phoneNumber = Console.ReadLine()!;
            check = CheckPhoneNumber(phoneNumber);
            do
            {
                if (check)
                {
                    Console.WriteLine("Please write your phone number correctly! ( Start with '+994' )");
                    Console.Write("Phone number : ");
                    phoneNumber = Console.ReadLine()!;
                    check = CheckPhoneNumber(phoneNumber);
                }
            } while (check);
            Console.WriteLine();

            //Checking user's position
            Console.Write("Position : ");
            string position = Console.ReadLine()!;
            check = CheckPosition(position);
            do
            {
                if (check)
                {
                    Console.WriteLine("Sorry, your position is not suitable for our requirements");
                    Console.Write("Position : ");
                    position = Console.ReadLine()!;
                    check = CheckPosition(position);
                }

            } while (check);
            Console.WriteLine();

            //Checking user's income
            Console.Write("Income : ");
            int income = int.Parse(Console.ReadLine()!);
            check = CheckIncome(income);
            do
            {
                if (check)
                {
                    Console.WriteLine("Sorry, your income must be between 1500 and 5000");
                    Console.WriteLine("Income : ");
                    position = Console.ReadLine()!;
                    check = CheckIncome(income);
                }
            } while (check);


            //If all datas are correct user will see that
            Console.WriteLine($"{name} {surname} {fathersName}, Age : {age}, Phone number : {phoneNumber}, Position {position}");
        }
        static bool CheckName(string name)
        {
            bool check = false;

            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[i] == numbers[j])
                    {
                        check = true; break;
                    }
                }
                if (check)
                {
                    break;
                }
            }

            if (2 < name.Length && name.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (name[0] == uppercaseLetters[i])
                    {
                        return check;
                    }
                    else
                    {
                        return !check;
                    }
                }
            }
            else
            {
                return !check;
            }
            return check;
        }
        static bool CheckSurname(string surname)
        {
            bool check = false;

            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < surname.Length; i++)
            {
                for (int j = 0; j < surname.Length; j++)
                {
                    if (surname[i] == numbers[j])
                    {
                        check = true; break;
                    }
                }
                if (check)
                {
                    break;
                }
            }

            if (2 < surname.Length && surname.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (surname[0] == uppercaseLetters[i])
                    {
                        return check;
                    }
                    else
                    {
                        return !check;
                    }
                }
            }
            else
            {
                return !check;
            }
            return check;
        }
        static bool CheckFathersName(string fathersName)
        {
            bool check = false;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < fathersName.Length; i++)
            {
                for (int j = 0; j < fathersName.Length; j++)
                {
                    if (fathersName[i] == numbers[j])
                    {
                        check = true; break;
                    }
                }
                if (check)
                {
                    break;
                }
            }

            for (int i = 0; i < fathersName.Length; i++)
            {
                for (int j = 0; j < fathersName.Length; j++)
                {
                    if (fathersName[i] == numbers[j])
                    {
                        check = true; break;
                    }
                }
                if (check)
                {
                    break;
                }
            }

            if (2 < fathersName.Length && fathersName.Length < 20)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (fathersName[0] == uppercaseLetters[i])
                    {
                        return check;
                    }
                    else
                    {
                        return !check;
                    }
                }
            }
            else
            {
                return !check;
            }
            return check;
        }
        static bool CheckAge(int age)
        {
            if (age <= 18 || age >= 65)
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
            bool check = true;
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            if (FINcode.Length == 7)
            {
                for (int i = 0; i < uppercaseLetters.Length; i++)
                {
                    if (FINcode[0] == uppercaseLetters[i])
                    {
                        check = false;
                        return check;
                    }
                }
            }
            return check;
        }
        static bool CheckPhoneNumber(string phoneNumber)
        {
            if (phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
            {
                if (phoneNumber.Length == 13)
                {
                    return false;
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