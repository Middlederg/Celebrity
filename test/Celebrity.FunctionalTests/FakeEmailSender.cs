using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web;

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
            string code = message.Substring(message.IndexOf("code=") + "code=".Length);
            code = code.Substring(0, code.IndexOf("'>confirm"));
            //code = WebUtility.HtmlDecode(code);
            string decoded = HttpUtility.UrlDecode(code);
            return decoded;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            emails.Add((email, subject, htmlMessage));
            return Task.FromResult(0);
        }
    }
}
