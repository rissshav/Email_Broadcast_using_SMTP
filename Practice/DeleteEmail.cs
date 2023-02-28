using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DeleteEmail
    {
        List<ManageEmails> delete =new List<ManageEmails>();

        public DeleteEmail(List<ManageEmails> delete)
        {
            this.delete = delete;
        }

        public List<ManageEmails> Deleteemail()
        {
            bool loopflag = true;
            while (loopflag)
            {
                ViewEmails print = new ViewEmails(delete);
                print.AllEmails();
                Console.WriteLine("Enter the ID of email which you want to delete");
                int userinput = int.Parse(Console.ReadLine());

                bool idloopflag = true;
                foreach (ManageEmails item in delete)
                {
                    if (userinput == item.email_id)
                    {
                        idloopflag = false;
                        loopflag = false;
                        // Used Linq Lamda expression to delete email
                        delete.RemoveAll(e => e.email_id == userinput);
                        Console.WriteLine("Email Deleted\n");
                        break;
                    }  
                }
                if (idloopflag == true)
                {
                    Console.WriteLine("\nEmail Not Found!");
                    Console.WriteLine("\nTry Again!!\n");
                }
                
            }
            return delete;
        }
    }
}
