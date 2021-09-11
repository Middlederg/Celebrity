using System.Threading.Tasks;

namespace Celebrity
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
