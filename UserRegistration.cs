

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class UserRegistration
    {
        

        public string regex_for_fname = "^[A-Z]{1}[a-z]{2,10}$";
        public string regex_for_lname = "^[A-Z]{1}[a-z]{2,10}$";
        public string regex_for_email = "^[a-zA-Z0-9._*]+@[A-Za-z0-9]+.[A-Za-z]{2,4}";
        public string regex_for_phoneNumber = "[8-9]{1}[0-9]{9}";



        public void validatefirstname(string fName)
        {

            if (Regex.IsMatch(fName, regex_for_fname))
                Console.WriteLine("First name is correct");
            else
                Console.WriteLine("First name is not correct");
        }
        public void validateLastName(string lName)
        {
            if (Regex.IsMatch(lName, regex_for_lname))
                Console.WriteLine("Last name is correct");
            else
                Console.WriteLine("Last name is not correct");
        }
        public void validateEmail(string email)
        {
            if(Regex.IsMatch(email, regex_for_email))
                Console.WriteLine("email is valid");
            else
                Console.WriteLine("email is not valid");
        }
        public void validatePhonenumber(string PhoneNumber)
        {
            if(Regex.IsMatch(PhoneNumber, regex_for_phoneNumber))
                Console.WriteLine("Phone number is valid");
            else
                Console.WriteLine("Phone number is not valid");
        }
    }
}
