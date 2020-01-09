using DartTest.MoneyChange.Application.Interfaces;
using DartTest.MoneyChange.Domain.Interfaces;
using DartTest.MoneyChange.Domain.Models;

namespace DartTest.MoneyChange.Application
{
    public class MoneyChangeAppService : IMoneyChangeAppService
    {
        private readonly IMoneyChangeService _moneyChangeService;

        public MoneyChangeAppService(IMoneyChangeService moneyChangeService)
        {
            _moneyChangeService = moneyChangeService;
        }

        public string StartProcess(PaymentTransaction transaction)
        {
            var result = _moneyChangeService.MoneyChangeCalculate(transaction);

            return result.PaymentResult;
        }
    }
}
