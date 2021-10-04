using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserPhoneCheck
    {
        public string Regexphone = "^(91)?\\s{0,2}[0-9]{10}$";
        // Restricted to first digit to be non zero AND space between countrycode and number
        public void CheckPhone(string phone)
        {
            bool check = Regex.IsMatch(phone, Regexphone);

            if (check == true)
            {
                Console.WriteLine(phone + " phone is Valid !");

            }
            else 
            {
                Console.WriteLine(phone + " phone is Not Valid \n");
                

            }

        }
    }
}
