using DartTest.MoneyChange.Domain;
using DartTest.MoneyChange.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DartTest.MoneyChange.Infra.Ioc
{
    public class DomainInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IMoneyChangeService, MoneyChangeService>();
        }
    }
}
