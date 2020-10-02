using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LightningRodInteractive.ContactService
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;
        private readonly ContactServiceOptions _contactServiceOptions;

        public ContactService(IHttpClientFactory httpClientFactory,
                              ContactServiceOptions contactServiceOptions)
        {
            _httpClient = httpClientFactory.CreateClient(nameof(ContactService));
            _contactServiceOptions = contactServiceOptions;
        }

        public async Task SendEmailAsync(ContactUsDetails contactUsDetails)
        {
            await _httpClient.PostAsJsonAsync(_contactServiceOptions.DestinationUrl, contactUsDetails);
        }
    }
}
