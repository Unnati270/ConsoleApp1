using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Validations
    {
        Regex match = new Regex(@"[A-Z][a-z]") ;
        Regex checker = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
        public bool validateUsername(string username)
        {
            var check = match.IsMatch(username);
            return check; 
        }
       
        public bool validateFirstName(string firstName) 
        {
            var check = match.IsMatch(firstName);
            return check;
        }

        public bool validateLastName(string lastName)
        {
            var check = match.IsMatch(lastName);
            return check;
        }
        public bool validateEmail(string email)
        {
            var check = checker.IsMatch(email);
            return check;
        }

        public bool validatePassword(string password) 
        {
            var check = pass.IsMatch(password);
            return check;
        }
    }
}
