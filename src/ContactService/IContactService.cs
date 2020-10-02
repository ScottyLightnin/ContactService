using System.Threading.Tasks;

namespace LightningRodInteractive.ContactService
{
    public interface IContactService
    {
        Task SendEmailAsync(ContactUsDetails contactUsDetails);
    }
}
