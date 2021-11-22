using System;

namespace dz7_2
{ 
    interface iThemeEmail
    {
        String Theme { get; set; }
    }
    interface iFromEmail
    {
        String From { get; set; }
    }
    interface iToEmail
    {
        String To { get; set; }
    }
    class EmailFromTo : iFromEmail, iToEmail
    {
        
        public String From { get; set; }
        public String To { get; set; }
    }

    class Email : iThemeEmail, iFromEmail ,iToEmail
    {

       
        public String From { get; set; }
        public String To { get; set; }
        public String Theme { get; set; }
    }

    class EmailSender
    {
        public void Send(Email email)
        {
            // ... sending...
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
        }
        public void Send2(EmailFromTo email)
        {
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
        }

    }
    
class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email()  {From = "Me", To = "Vasya", Theme = "Who are you?" };
            Email e2 = new Email() { From = "Vasya",To = "Me",Theme = "vacuum cleaners!" };
            Email e3 = new Email(){ From = "Kolya",To = "Vasya", Theme = "No! Thanks!" };
            Email e4 = new Email(){From = "Vasya", To = "Me",Theme = "washing machines!" };
            Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            Email e6 = new Email(){From = "Vasya",To =  "Petya", Theme = "+2" };
            EmailFromTo e7 = new EmailFromTo() { From = "Vasya", To = "Petya"};
            EmailSender es = new EmailSender();
            es.Send(e1);
            es.Send(e2);
            es.Send(e3);
            es.Send(e4);
            es.Send(e5);
            es.Send(e6);
            es.Send2(e7);
            Console.ReadKey();
        }
    }
}
