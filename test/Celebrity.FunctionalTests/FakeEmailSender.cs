using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.FunctionalTests
{
    public class FakeEmailSender : IEmailSender
    {
        private readonly List<(string to, string subject, string message)> emails;

        public FakeEmailSender()
        {
            emails = new List<(string, string, string)>();
        }

        public bool EmailWasSentTo(string email, string subject, int minimunTimes)
        {
            return emails.Count(x => email.Equals(x.to) && subject.Equals(x.subject)) >= minimunTimes;
        }

        public string SearchForCode(string email)
        {
            if (!emails.Any(x => email.Equals(x.to)))
            {
                return null;
            }
            var (to, subject, message) = emails.First(x => email.Equals(x.to));
            string code = message.Substring(message.IndexOf("href='") + "href='".Length);
            code = code.Substring(0, code.IndexOf("'>"));
            return code;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            emails.Add((email, subject, htmlMessage));
            return Task.FromResult(0);
        }
    }
}
