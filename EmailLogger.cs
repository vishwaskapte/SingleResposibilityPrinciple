using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{// Email logging service
    public class EmailLogger
    {
        public void SaveEmailLog(string to, string subject, string body)
        {
            // Code to save email log to a database...
            Console.WriteLine($"Saving email log to database - To: {to}, Subject: {subject}, Body: {body}");
        }
    }
}
