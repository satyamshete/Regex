using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseOfRegex
{
    internal class RegexProblem
    {
        public Regex FirstName = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");
        public Regex LastName = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");   


        public void CheckFirstName(string fName)   
        {
            Console.WriteLine("first name is : " + fName);
            if (FirstName.IsMatch(fName))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
            Console.WriteLine();
        }
        public void CheckLastName(string lName)    ///UC2
        {
            Console.WriteLine("last name is : " + lName);
            if (LastName.IsMatch(lName))
            {
                Console.WriteLine("Valid Last name");
            }
            else
            {
                Console.WriteLine("Invalid Last name");
            }
            Console.WriteLine();
        }
    }
}
