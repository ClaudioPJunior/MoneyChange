using DartTest.MoneyChange.Application;
using DartTest.MoneyChange.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DartTest.MoneyChange.Infra.Ioc
{
    public class ApplicationInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IMoneyChangeAppService, MoneyChangeAppService>();
        }
    }
}
