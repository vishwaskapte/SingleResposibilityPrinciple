using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    // Email sending service
    public class EmailService
    {
       public void SendEmail(string to, string subject, string body)
        {
            // Code to send an email...
            Console.WriteLine($"Sending email to: {to}, Subject: {subject}, Body: {body}");
        }
    }
}
