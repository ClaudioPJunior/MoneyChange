using DartTest.MoneyChange.Domain.Interfaces;
using DartTest.MoneyChange.Domain.Models;
using System;

namespace DartTest.MoneyChange.Domain
{
    public class MoneyChangeService : IMoneyChangeService
    {
        public PaymentTransactionResult MoneyChangeCalculate(PaymentTransaction transaction)
        {
            var paymenTransactionResult = new PaymentTransactionResult();

            if (transaction.PaidAmmount < transaction.PurchaseAmmount)
            {
                paymenTransactionResult.PaymentResult = "Pagamento insuficiente";
                return paymenTransactionResult;
            }

            int[] bankNotes = { 100, 50, 20, 10, 5, 2, 1 };
            int[] coins = { 50, 10, 25, 5, 1 };

            var moneyChange = transaction.PaidAmmount - transaction.PurchaseAmmount;

            var result = $"\nTroco = R${moneyChange}\n\n";

            int iterator, value, qtde;
            decimal notes =

            value = (int)moneyChange;

            iterator = 0;

            while (value != 0)
            {
                qtde = value / bankNotes[iterator];
                if (qtde != 0)
                {
                    result += $"{qtde} nota(s) de R${bankNotes[iterator]}\n";
                    value %= bankNotes[iterator];
                }
                iterator += 1;
            }

            result = $"{result}\n";

            value = (int)Math.Round((moneyChange - (int)moneyChange) * 100);

            iterator = 0;

            while (value != 0)
            {
                qtde = value / coins[iterator];
                if (qtde != 0)
                {
                    result += $"{qtde} moeda(s) de {coins[iterator]} centavo(s)\n";
                    value %= coins[iterator];
                }
                iterator += 1;
            }

            paymenTransactionResult.PaymentResult = result;

            return paymenTransactionResult;
        }
    }
}
