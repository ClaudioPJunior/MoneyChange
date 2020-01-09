using Microsoft.Extensions.DependencyInjection;

namespace DartTest.MoneyChange.Infra.Ioc
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            ApplicationInjector.RegisterServices(services);
            DomainInjector.RegisterServices(services);
        }
    }
}
