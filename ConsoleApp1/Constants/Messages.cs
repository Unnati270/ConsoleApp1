using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constants
{
    public static class Messages
    {
        public static string GreetingMessage { get; set; } = "Welcome to DesktopTutorial app, We are excited to serve you!\n";

        public static string Options { get; set; } = "Choose an option to continue: \n\n1. Create an Account \n2. Login to an Existing Account \nKindly enter your choice:";

        public static string Username { get; set; } = "Please Enter a display name:";
        public static string FirstName { get; set; } = "Please Enter your First Name:";

        public static string LastName { get; set; } = "Please Enter your Last Name:";

        public static string Email { get; set; } = "Please Enter an Email ID:";

        public static string Gender { get; set; } = "Please Enter your Gender:";

        public static string Age { get; set; } = "Please Enter your current Age:";

        public static string Password { get; set; } = "Please Enter Password:";

        public static string UserID { get; set; } = "You are assigned this UserID:";

        public static string LoginMessage { get; set; } = "Hurray!! Login Successfull!";

        public static string LoginError { get; set; } = "oops! Incorrect Password. \nPlease enter the correct Password!";

        public static string InvalidUser { get; set; } = "Sorry! User does not exits. \nPlease enter a valid UserID!";
    }
}
