using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace LightningRodInteractive.ContactService
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddContactService(this IServiceCollection services, Action<ContactServiceOptions> configureOptions)
        {
            services.Configure(configureOptions);
            services.AddHttpClient(nameof(ContactService));
            services.AddSingleton(sp => sp.GetRequiredService<IOptions<ContactServiceOptions>>().Value);
            services.AddTransient<IContactService, ContactService>();
            return services;
        }
    }
}
