using System;
using System.Text.RegularExpressions;

namespace Lab_7_BlakeOdy
{
    class Program
    {
        public static void Main(string[] args)
        {
            //first question - call on first method
            string name = FirstName(GetUserInput("what is your first name? "));
            Console.WriteLine($" Hello {name}");

            //Second question - call on second method
            string email = EmailAdd(GetUserInput("what is your email address?"));
            Console.WriteLine($"Your email address is:{email}");

            //third question - call on third method
            string phone = PhoneNum(GetUserInput("What is your Phone Number"));
            Console.WriteLine($"Your Phone number is: {phone}");
        }

        public static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();

        }

        public static string FirstName(string name)
        {
            if ((!Regex.IsMatch(name, @"^[a-zA-z]$")) && name.Length <= 30 && char.IsUpper(name[0]))
            {
                return name;
            }
            else
            {
                return FirstName(GetUserInput("Please enter a name that contains only letters " +
                    "and is less than 30 characters & please capitalize your name"));

            }
        }
            // second method to validate email address
          public static string EmailAdd(string email)
            {
                if (Regex.IsMatch(email, @"^[A-z0-9]{1,30}@[A-z]{5,10}.[A-z]{2,3}"))
                {
                    return email;
                }
                else
                {
                    return EmailAdd(GetUserInput("Please enter a valid email address"));
                }
            }
        public static string PhoneNum(string phone)
        {
            if (Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                return phone;
            }
            else
            {
                return PhoneNum(GetUserInput("Please enter a valid phone number."));
            }
                
        }


        }



       


    }

