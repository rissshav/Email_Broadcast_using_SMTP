using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ViewEmails
    {
        List<ManageEmails> viewallemails = new List<ManageEmails>();

        public ViewEmails(List<ManageEmails> viewallemails)
        {
            this.viewallemails = viewallemails;
        }


        public void AllEmails()
        {
            // Linq is used here for view all emails
            var allemails = from view in viewallemails select view;

            foreach (ManageEmails item in allemails)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1} {2}",item.email_id, item.name, item.email);
            }
        }
    }
}
