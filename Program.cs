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
        public UserRegistration()
        {

        }
        public void Firstnamein(string Firstname)
        {
            Regex FirstNames = new Regex(@"^[A-Z][A-Za-z]{3,}$");
            bool MethodName(string Firstname) => FirstNames.IsMatch(Firstname);
            bool result = MethodName(Firstname);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("Valid Name");                    
                }
            }catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "invalid name...");
                
            }
        }
        public void Lastenamein(string Lastname)
        {
            Regex LastNames = new Regex(@"^[A-z][A-Za-z]{3,}$");
            bool MethodName(string Lastname) => LastNames.IsMatch(Lastname);
            bool result = MethodName(Lastname);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("Valid Name");
                }
            }
            
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "invalid name...");
            }
        }
        public void Emails(string Email)
        {
            Regex EmailReg = new Regex(@"^[a-z](.[a-z])+@[a-z]+.[a-z]{3}(.[a-z]{2})$");
            bool MethodName(string Email) => EmailReg.IsMatch(Email);
            bool result = MethodName(Email);
            try 
            {
                if (result == true)
                {
                    Console.WriteLine("Valid Email");
                }
            }catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "invalid Email...");
            }
        }
        public void PhoneNumbers(string PhoneNumber)
        {
            Regex PhoneNumberReg = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
            bool MethodName(string PhoneNumber) => PhoneNumberReg.IsMatch(PhoneNumber);
            bool result = MethodName(PhoneNumber);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("Valid PhoneNumber");
                }
            }catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "invalid PhoneNumber...");
            }
        }
        public void PassWords(string PassWord)
        {
            Regex PassWordReg = new Regex(@"^[A-Z]@[0-9][A-Za-z]{8,}$");
            bool MethodName(string PassWord) => PassWordReg.IsMatch(PassWord);
            bool result = MethodName(PassWord);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("Valid PassWord");
                }
            }catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "invalid PassWord...");
            }
        }
        public void AllEmails(string AllEmail)
        {
            Regex AllEmailReg = new Regex(@"^[a-z]((.-+){1})([0-9]{3})+@([0-9]{1})([a-z]{,5})+.[a-z]{3}(.[a-z]{2,})$");
            bool MethodName(string AllEmail) => AllEmailReg.IsMatch(AllEmail);            
            bool result = MethodName(AllEmail);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("Valid AllEmail");
                }
            }catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Invalid, "AllEmail...");
            }
        }
        static void Main(string[]args)
        {
            
            
        }
    }    
}