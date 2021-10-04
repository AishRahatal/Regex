using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserEmailCheck
    {
        public string Regexemail = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public void CheckEmail(string email)
        {
            bool check = Regex.IsMatch(email, Regexemail);

            if (check == true)
            {
                Console.WriteLine(email + " Email is Valid !");

            }
            else
            {
                Console.WriteLine(email + "Email is Not Valid \n");
                

            }

        }
    }
}
