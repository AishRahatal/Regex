using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex for User Registration :");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Checking Username \n");
            Console.WriteLine(" 'For First and Last name please enter first letter capital and minimum three letter' \n");
            Console.WriteLine("Enter First name  :");
            string FirstName = Console.ReadLine();
            UserNameCheck obj1 = new UserNameCheck();
            Console.WriteLine("-------------------------------");
            obj1.CheckName(FirstName);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter Last name  :");
            string LastName = Console.ReadLine();
            Console.WriteLine("-------------------------------");
            obj1.CheckName(LastName);
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("Checking Email \n");
            Console.WriteLine(" 'abc.xyz @bl.co.in - Please enter Email in given format ' \n");
            Console.WriteLine("Enter Email :");
            string Email = Console.ReadLine();
            UserEmailCheck obj2 = new UserEmailCheck();
            Console.WriteLine("-------------------------------");
            obj2.CheckEmail(Email);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Checking Cell Phone Number \n");
            Console.WriteLine(" 'Should start with 91  - Please enter Cell Phone Number in given format ' \n");
            Console.WriteLine("Enter Phone Number :");
            var Phone = Console.ReadLine();
            UserPhoneCheck obj3 = new UserPhoneCheck();
            Console.WriteLine("-------------------------------");
            obj3.CheckPhone(Phone);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Checking password \n");
            Console.WriteLine(" ' Should be have minimum 8 chaacter Should have at least 1 capital letter,1 special character,1 number' \n");
            Console.WriteLine("Enter Password :");
            var password = Console.ReadLine();
            UserPasswordCheck obj4 = new UserPasswordCheck();
            Console.WriteLine("-------------------------------");
            obj4.CheckPassword(password);


        }
    }
}
