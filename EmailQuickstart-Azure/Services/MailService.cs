using Azure;
using Azure.Communication.Email;
using EmailQuickstart_Azure.Models;
using Microsoft.Extensions.Options;
using System.Net.Mail;

namespace EmailQuickstart_Azure.Services
{
    public class MailService : IMailService
    {
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            // Copy the connection String Endpoint here
            var client = new EmailClient("#####");

            // Fill the EmailMessage

            // Add the Mailfrom Address 
            var sender = "#####";
            var subject = mailRequest.Subject;

            var emailContent = new EmailContent(subject)
            {
                PlainText = mailRequest.Body
            };

            var toRecipients = new List<EmailAddress>()
            {
                new EmailAddress(mailRequest.ToEmail)
            };

            var emailRecipients = new EmailRecipients(toRecipients);

            var emailMessage = new EmailMessage(sender, emailRecipients, emailContent);

            //await client.SendAsync(emailMessage);

            await client.SendAsync(WaitUntil.Completed, emailMessage);
            Console.WriteLine($"Email Sent. Status = {emailMessage}");
        }
    }
}
