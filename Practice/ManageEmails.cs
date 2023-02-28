using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ManageEmails
    {
       public int email_id;
       public string name;
       public string email;

        public ManageEmails(int email_id, string name, string email)
        {
            this.email_id = email_id;
            this.name = name;
            this.email = email;
        }
    }
}
