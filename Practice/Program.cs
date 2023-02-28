using Practice;

internal class Program
{
    private static void Main(string[] args)
    {
        ManageEmails emails = new ManageEmails(1, "Ishan", "ishanb.aspirefox@gmail.com");
        ManageEmails emails1 = new ManageEmails(2, "Swati", "swatik.aspirefox@gmail.com");

        List<ManageEmails> emailList= new List<ManageEmails>();
        emailList.Add(emails);
        emailList.Add(emails1);

        bool loopflag = true;
        while (loopflag)
        {
            Console.WriteLine("Please select the below options");
            Console.WriteLine();
            Console.WriteLine("1. Add Email");
            Console.WriteLine("2. Edit Email");
            Console.WriteLine("3. Delete Email");
            Console.WriteLine("4. View Email List");
            Console.WriteLine("5. Send Email");
            Console.WriteLine("6. Broadcast Message");
            Console.WriteLine("7. Exit");

            string userinput = Console.ReadLine();

            switch (userinput)
            {
                    case "1":
                    Console.WriteLine("You have selected Add Email");
                    var add = AddEmail.Add();
                    emailList.Add(add);
                    break;
                    case "2":
                    Console.WriteLine("You have selected Edit Email");
                    Edit edit = new Edit(emailList);
                    edit.Editemails();
                    break;
                    case "3":
                    Console.WriteLine("You have selected Delete Email");
                    DeleteEmail delete = new DeleteEmail(emailList);
                    delete.Deleteemail();
                    break;
                    case "4":
                    Console.WriteLine("you have selected View email List");
                    ViewEmails viewemails = new ViewEmails(emailList);
                    viewemails.AllEmails();
                    break;
                    case "5":
                    Console.WriteLine("You have selected Send Email");
                    SendEmails sendmails = new SendEmails(emailList);
                    sendmails.Send();
                    break;
                    case "6":
                    Console.WriteLine("You have selected Broadcast Message");
                    BroadCast broadCast = new BroadCast(emailList);
                    broadCast.BroadcastMessage();
                    break;
                    case "7":
                    loopflag = false;
                    break;
                    default:
                    Console.WriteLine("Please select the valid option");
                    break;
            }
        }
    }
}