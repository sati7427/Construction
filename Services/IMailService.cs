using System.Threading.Tasks;
using ConstructionCoreApp.Models;

namespace ConstructionCoreApp.Services
{
public interface IMailService
{
    Task SendEmailAsync(MailRequest mailRequest);
    Task SendWelcomeEmailAsync(WelcomeRequest request);

        Task SendWelcomeEmailas(string to,string user);
    }
}
