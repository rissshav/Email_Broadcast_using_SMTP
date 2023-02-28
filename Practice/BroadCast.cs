using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class BroadCast
    {
        List<ManageEmails> broadcast = new List<ManageEmails>();

        public BroadCast(List<ManageEmails> broadcast)
        {
            this.broadcast = broadcast; 
        }

        public void BroadcastMessage()
        {
            Console.WriteLine("Enter the subject of the Email");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter the Body of the Email");
            string message = Console.ReadLine();
            foreach (ManageEmails item in broadcast)
            {
                List<string> EmailAdd = new List<string> { item.email };

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
