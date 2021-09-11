using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace Celebrity.Data
{
    public class SendgridEmailSender : IEmailSender
    {
        private readonly string sendgridKey;
        private const string FromDefaultAddress = "middlederg@gmail.com";
        private const string FromDefaultName = "Celebrity";

        public SendgridEmailSender(IConfiguration configuration)
        {
            sendgridKey = configuration.GetConnectionString("Sendgrid");
        }

        public async Task SendEmailAsync(string to, string subject, string htmlMessage)
        {
            var message = new SendGridMessage()
            {
                From = new EmailAddress(FromDefaultAddress, FromDefaultName),
                Subject = subject,
                HtmlContent = htmlMessage,
            };

            var client = new SendGridClient(sendgridKey);
            message.AddTo(new EmailAddress(to));
            var response = await client.SendEmailAsync(message);
            if (response.StatusCode != System.Net.HttpStatusCode.Accepted)
            {
                var responseText = await response.Body.ReadAsStringAsync();
                throw new Exception($"Email could not be delivered. {response.StatusCode} - {responseText}");
            }
        }

    }
}
