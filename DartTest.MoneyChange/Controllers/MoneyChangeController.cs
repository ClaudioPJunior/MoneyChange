using System;
using System.Collections.Generic;
using System.Linq;
using DartTest.MoneyChange.Application.Interfaces;
using DartTest.MoneyChange.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DartTest.MoneyChange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyChangeController : ControllerBase
    {
        private readonly IMoneyChangeAppService _moneyChangeAppService;

        public MoneyChangeController(IMoneyChangeAppService moneyChangeAppService)
        {
            _moneyChangeAppService = moneyChangeAppService;
        }

        [HttpPost,
        Route("CalcularTroco")]
        public string Post([FromBody] PaymentTransaction transaction)
        {
            try
            {
                return _moneyChangeAppService.StartProcess(transaction);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
