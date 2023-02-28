using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SendEmails
    {
        List<ManageEmails> sendemail = new List<ManageEmails>();
        public SendEmails(List<ManageEmails> sendemail)
        {
            this.sendemail = sendemail;
        }

        public void Send()
        {
            ViewEmails print = new ViewEmails(sendemail);
            print.AllEmails();
            bool loopflag = true;
            while (loopflag)
            {
                Console.WriteLine("\nSelect the email ID you want send the email");
                int userinput = int.Parse(Console.ReadLine());
                bool idloopflag = true;
                foreach (ManageEmails item in sendemail)
                {
                    if(item.email_id == userinput)
                    {
                        idloopflag = false;
                        loopflag = false;
                        Console.WriteLine("You have selected {0}",item.email);

                        List<string> EmailAdd = new List<string> { item.email };
                        Console.WriteLine("Enter the subject of the email");
                        string subject = Console.ReadLine();
                        Console.WriteLine("Enter the Body of the Email");
                        string message = Console.ReadLine();
                        

                        List<Thread> threads = new List<Thread>();

                        foreach (string email in EmailAdd)
                        {
                            Thread thrd = new Thread(() => SendEmail(email, subject, message));
                            threads.Add(thrd);
                        }

                        foreach (Thread thread in threads)
                        {
                            thread.Start();
                        }

                        foreach (Thread thread in threads)
                        {
                            thread.Join();
                        }

                        Console.WriteLine("Email sent");
                    }
                }
            }  

        }
        public static void SendEmail(string toAddress, string subject, string message)
        {
            string fromAddress = "rishavv.aspirefox@gmail.com";

            MailMessage mail = new MailMessage(fromAddress, toAddress);
            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;

            //Generate this one with the help of setting of your account.
            NetworkCredential NetworkCred = new NetworkCredential("rishavv.aspirefox@gmail.com", "ckumppnuyvfnbbfd");

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = NetworkCred;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Send(mail);
            Console.WriteLine($"Email sent to {toAddress}");

        }
    }
}
