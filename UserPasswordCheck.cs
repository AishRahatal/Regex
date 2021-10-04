using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserPasswordCheck
    {
        public string RegexPaasword = "((?=.*\\d)(?=.*[A-Z])(?=.*\\W).{8,})";

        public void CheckPassword(string password)
        {
            bool check = Regex.IsMatch(password, RegexPaasword);

            if (check == true)
            {
                Console.WriteLine(password + " Password is Valid !");

            }
            else
            {
                Console.WriteLine(password + " Password is Not Valid \n");
               

            }

        }
    }
}

