using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace IdentitySchool.Services
{
    public class EmailSenderService : IEmailSender
    {
        private readonly ILogger<EmailSenderService> _logger;

        public EmailSenderService(ILogger<EmailSenderService> logger)
        {
            _logger = logger;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            _logger.LogWarning("No email sending is configured for the moment, consider configuring some kinde of email provider.");
            return Task.CompletedTask;
        }
    }
}
