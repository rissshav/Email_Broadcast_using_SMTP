using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    public class Validation
    {
        public static string checkName(string name)
        {
            string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            Regex re = new Regex(regex);
            if (re.IsMatch(name))
            {
                return name;
            }
            string fname = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Name: ");
                string tempName = Console.ReadLine();
                if (re.IsMatch(tempName))
                {
                    fname = tempName;
                    flag = false;
                }
            }
            return fname;
        }
        public static string checkEmail(string email)
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex re = new Regex(regex);
            if (re.IsMatch(email))
            {
                return email;
            }
            string _email = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Email: ");
                string tempEmail = Console.ReadLine();
                if (re.IsMatch(tempEmail))
                {
                    _email = tempEmail;
                    flag = false;
                }
            }
            return _email;
        }
    }
}
