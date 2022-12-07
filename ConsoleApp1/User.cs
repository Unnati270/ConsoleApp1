using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ConsoleApp1.Constants;

namespace ConsoleApp1
{
    public class User
    {
        private ArrayList dataArray = new ArrayList();
        Validations validate = new Validations();
        public string UniqueId(String username, int age)
        {
            Random random = new Random();
            int num = random.Next(100,1000);
            return ($"{num}{username}{age}");
        }

        public void signup() 
        {

            Console.WriteLine(Messages.Username);
            string username = Console.ReadLine();
            while(!validate.validateUsername(username))
            {
                if(!validate.validateUsername(username))
                {
                    Console.WriteLine("Enter correct username!!");
                    Console.WriteLine(Messages.Username);
                    username = Console.ReadLine();
                }
            }

            Console.WriteLine(Messages.FirstName);
            string firstName = Console.ReadLine();
            while(!validate.validateFirstName(firstName))
            {
                if(!validate.validateFirstName(firstName))
                {
                    Console.WriteLine("Enter Valid First Name");
                    Console.WriteLine(Messages.FirstName);
                    firstName = Console.ReadLine();
                }
            }

            Console.WriteLine(Messages.LastName);
            string lastName = Console.ReadLine();
            while(!validate.validateLastName(lastName))
            {
                if(!validate.validateLastName(lastName))
                {
                    Console.WriteLine("Enter a valid Last Name.");
                    Console.WriteLine(Messages.LastName);
                    lastName = Console.ReadLine();

                }
            }

            Console.WriteLine(Messages.Email);
            string Email = Console.ReadLine();
            while(!validate.validateEmail(Email))
            {
                if (!validate.validateEmail(Email))
                {
                    Console.WriteLine("Kindly enter a valid Email address.");
                    Console.WriteLine(Messages.Email);
                    Email = Console.ReadLine();
                }
            }
         
            Console.WriteLine(Messages.Gender);
            string gender = Console.ReadLine();
            
            Console.WriteLine(Messages.Age);
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine(Messages.Password);
            string password = Console.ReadLine();
            while(!validate.validatePassword(password))
            {
                if (!validate.validatePassword(password))
                {
                    Console.WriteLine("Create a valid password!");
                    Console.WriteLine(Messages.Password);
                    password = Console.ReadLine();
                }
            }

            string id = UniqueId(username, age);
            Console.WriteLine(Messages.UserID + id);

            var userData = new Dictionary<string, Dictionary<string, string>>()
            {
                { id, new Dictionary<string, string>(){
                    {"username", username},
                    {"firstName", firstName},
                    {"lastName", lastName},
                    {"emailId" , Email},
                    {"Gender", gender },
                    {"Age", ageInput },
                    {"Password", password}
                } },
                
            };

            var text = File.ReadAllText(@"C:\Users\unnati.s\source\repos\ConsoleApp1\ConsoleApp1\data.json");

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("No Existing Data");
            }
            else
            {
                ArrayList dataArray = JsonSerializer.Deserialize<ArrayList>(text);

            }

            dataArray.Add(userData);

            var jsonObject = JsonSerializer.Serialize(dataArray);

            //Console.WriteLine(jsonObject);

            File.WriteAllText(@"C:\Users\unnati.s\source\repos\ConsoleApp1\ConsoleApp1\data.json", jsonObject.ToString());

            var data = File.ReadAllText(@"C:\Users\unnati.s\source\repos\ConsoleApp1\ConsoleApp1\data.json").ToString();
            
            object person = JsonSerializer.Deserialize<object>(data);

            /*Console.WriteLine(person);

            Console.WriteLine("Done!!");*/

        }

        public void login()
        {
            string store = File.ReadAllText(@"C:\Users\unnati.s\source\repos\ConsoleApp1\ConsoleApp1\data.json");
            //Console.WriteLine(store);

            var userobject = JsonSerializer.Deserialize<object>(store);
            //Console.WriteLine(userobject);

            Console.WriteLine(Messages.UserID);
            string id = Console.ReadLine();

            if (store.Contains(id))
            {
                Console.WriteLine(Messages.Password);
                string password = Console.ReadLine();

                if(store.Contains(password))
                {
                    Console.WriteLine(Messages.LoginMessage);
                }
                else
                {
                    Console.WriteLine(Messages.LoginError);
                    /*Console.WriteLine(Messages.Password);
                    password= Console.ReadLine();*/
                }
            }
            else
            {
                Console.WriteLine(Messages.InvalidUser);
               /* Console.WriteLine(Messages.UserID);
                id = Console.ReadLine();*/
            }

        }
    }
}

