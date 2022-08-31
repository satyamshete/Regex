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
        public Regex Email = new Regex(@"^[a-z A-Z 0-9 .+_-]+@[a-z A-Z 0-9 -.]+[.][a-z A-Z 0-9 -]{2,}$");
        public Regex MobileNumber = new Regex(@"[0-9]{1,2}\s[0-9]{10}");
        public Regex PasswordMin8Char = new Regex(@"[A-Z a-z 0-9]{8,}");
        public Regex PasswordMin8Char2 = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");
        public Regex PasswordMin8Char3 = new Regex(@"(?=.*[0-9])[A-Za-z0-9]{8,}");


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

        public void CheckEmail(string email)    //UC3
        {
            Console.WriteLine("Email Id is : " + email);
            if (Email.IsMatch(email))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id");
            }
            Console.WriteLine();
        }
        public void CheckMobilNumber(string mobileNumber)
        {
            Console.WriteLine("Mobile number is : " + mobileNumber);
            if (MobileNumber.IsMatch(mobileNumber))
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();
        }
        public void CheckPassmin8Char(string pass)
        {
            Console.WriteLine("Password  is : " + pass);
            if (PasswordMin8Char.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
            Console.WriteLine();
        }
        public void CheckPass8CharWithUpperCase(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (PasswordMin8Char2.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }
        public void CheckPass8CharWithNumber(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (PasswordMin8Char3.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }
    }
}
