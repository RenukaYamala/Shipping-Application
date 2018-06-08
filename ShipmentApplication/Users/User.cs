using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentApplication.Users
{
    public class User
    {
        //public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        private static string UserName { get; set; }
        private static string PassWord { get; set; }
        //string email;
        public void Login(string username, string password, Object  details)
        {
            Console.WriteLine("LOGIN");
            Console.WriteLine("Enter Login Credentials To Login:");
            Console.WriteLine("UserName:");
            UserName = Console.ReadLine();
            Console.WriteLine("PassWord:");
            PassWord = Console.ReadLine();
            //  var details = shipper.GetUser();
            if (username == UserName && password == PassWord)
            {
                Console.WriteLine("Ur Logged in");

            }
            else
            {
                Console.WriteLine("Sorry! UserName or Password is Wrong");
            }
            // Console.WriteLine(details.GetType().GetProperty(FirstName).GetValue(details));
            Console.ReadKey();
        }
        //protected void signUp() { }
    }
}
