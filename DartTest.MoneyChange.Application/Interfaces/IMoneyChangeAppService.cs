using DartTest.MoneyChange.Domain.Models;

namespace DartTest.MoneyChange.Application.Interfaces
{
    public interface IMoneyChangeAppService
    {
        string StartProcess(PaymentTransaction transaction);
    }
}
