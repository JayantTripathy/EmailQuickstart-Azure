using EmailQuickstart_Azure.Models;

namespace EmailQuickstart_Azure.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}

