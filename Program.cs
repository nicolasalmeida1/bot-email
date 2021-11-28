using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;



namespace Bot_email
{
    class Program
    {
        static void Main(string[] args)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Nicolas", "ng.almeidaa@gmail.com"));
            messagem.To.Add(MailboxAddress.Parse("ng.almeidaa@gmail.com"));

            message.Subject = "Vaga para Desenvolvedor | GeekHunter";

            message.Body = new TextPart("plain");

            Text = @"Yes
            
            Hello!!
            
            bla bla bla";

            Console.Write("Email: ");
            string emailAddress = Console.ReadLine();

            Console.Write("Password: ");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;

            string password = Console.ReadLine();

            Console.BackgroundColor = originalBGColor;
            Console.ForegroundColor = originalFGColor;



            
            
        }
    }
}
