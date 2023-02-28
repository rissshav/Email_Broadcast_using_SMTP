using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Edit
    {
        List<ManageEmails> edit = new List<ManageEmails>();
        public Edit(List<ManageEmails> edit)
        {
            this.edit = edit;
        }

        public List<ManageEmails> Editemails()
        {
            ViewEmails print = new ViewEmails(edit);
            print.AllEmails();
            bool loopflag = true;
            while (loopflag)
            {
                Console.WriteLine("Enter the Id which you want to edit\n");
                int ID = int.Parse(Console.ReadLine());
                bool idloopflag = true;
                foreach (ManageEmails item in edit)
                {
                    if(item.email_id == ID)
                    {
                        idloopflag= false;
                        loopflag = false;
                        Console.WriteLine("Updating the details\n");

                        Console.WriteLine("Update the Name");
                        string name = Console.ReadLine();
                        item.name = Validation.checkName(name);

                        Console.WriteLine("update the Email");
                        string email = Console.ReadLine();
                        item.email = Validation.checkEmail(email);
                    }
                }
                if (idloopflag == true)
                {
                    Console.WriteLine("\nEmail Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");
                }
            }
            Console.WriteLine("Updated Successfully");
            return edit;

        }
    }
}
