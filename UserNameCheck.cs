using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserNameCheck
    {
        public string RegexName= "^[A-Z]{1}[a-z]{3,}$";

        public void CheckName(string name)       
        {
           bool check= Regex.IsMatch(name, RegexName);

            if(check==true)
            {
                Console.WriteLine(name + " Name is Valid !");

            }
            else
            {
                Console.WriteLine(name +  " Name is Not Valid \n");
                

            }

        }

       


    }
}

