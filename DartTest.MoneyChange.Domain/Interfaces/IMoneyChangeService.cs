using DartTest.MoneyChange.Domain.Models;

namespace DartTest.MoneyChange.Domain.Interfaces
{
    public interface IMoneyChangeService
    {
        PaymentTransactionResult MoneyChangeCalculate(PaymentTransaction transaction);
    }
}
