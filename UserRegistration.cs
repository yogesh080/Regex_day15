

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
    }
}
