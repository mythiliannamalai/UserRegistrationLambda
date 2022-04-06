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
                Console.WriteLine("Valid Naem");
            }
            else
            {
                Console.WriteLine("invalid Naem..");
            }
        }  
        static void Main(string[]args)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Firstnamein();
        }
    }    
}