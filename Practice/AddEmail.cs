using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class AddEmail
    {
        static int id = 2;

        public static ManageEmails Add()
        {
            // This is to add User's Name with validation
            Console.WriteLine("Enter the Name of the User");
            string username = Console.ReadLine();
            username = Validation.checkName(username);

            // This is to add User's Email with validation
            Console.WriteLine("Enter the Email of the user");
            string email = Console.ReadLine();
            email= Validation.checkEmail(email);

            Console.WriteLine("Email Added sucessfully");
            id += 1;

            ManageEmails emails = new ManageEmails(id, username, email);
            return emails;
        }
    }
}
