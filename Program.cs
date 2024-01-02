// See https://aka.ms/new-console-template for more information
// Create instances of the email service and logger
using SingleResposibilityPrinciple;

EmailService emailService = new EmailService();
EmailLogger emailLogger = new EmailLogger();

// Send an email
emailService.SendEmail("recipient@example.com", "Hello", "This is the email body.");

// Save the email log
emailLogger.SaveEmailLog("recipient@example.com", "Hello", "This is the email body.");
