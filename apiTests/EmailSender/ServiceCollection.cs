using apiTests.Interfaces.EmailSenderInterface;
using Microsoft.Extensions.DependencyInjection;

namespace apiTests.EmailSender;

public static class ServiceCollection
{
    public static IServiceCollection services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();

    public static IServiceCollection CreateServiceCollection()
    {
        services.AddScoped<IEmailSender>(p => new EmailSender());
        return services;
    }
}