using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    public class UserRegistration
    {       
        public void Firstnamein()
        {
            Regex FirstNames = new Regex(@"^[A-Z][A-Za-z]{3,}$");
            bool MethodName(string Firstname) => FirstNames.IsMatch(Firstname);
            bool result = MethodName("Mythili");
            if (result == true)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("invalid Name..");
            }
        }
        public void Lastenamein()
        {
            Regex LastNames = new Regex(@"^[A-z][A-Za-z]{3,}$");
            bool MethodName(string Lastname) => LastNames.IsMatch(Lastname);
            bool result = MethodName("Annamalai");
            if (result == true)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("invalid Name.");
            }
        }
        static void Main(string[]args)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Firstnamein();
            userRegistration.Lastenamein();
        }
    }    
}