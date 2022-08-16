﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Dtos;
using Wallet.Utilties;

namespace Wallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {

        private readonly UrlConfiguration _walletOptions;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<WalletController> _logger;
        private readonly IMapper _mapper;
        private readonly IBankServices _bankServices;

        public BankController(ILogger<WalletController> logger, IMapper mapper, IBankServices bankServices)
        {
            _mapper = mapper;
            _logger = logger;
            _bankServices = bankServices;

        }
        [HttpPost]
        public async Task<IActionResult> CreateBank([FromBody]AccountDetailDto accountDetailDto)
        {
            var account = await _bankServices.CreateBankAsync(accountDetailDto);
            return StatusCode(account.StatusCode, account);
           // return Ok(accountDetailDto);
        }

        [HttpGet("{accountId}/{userId}")]
        public async Task<IActionResult> GetUserBank(int accountId, int userId)
        {
            var bank = await _bankServices.GetBankAsync(accountId, userId);
            return StatusCode(bank.StatusCode, bank);
        }

        [HttpDelete("{accountId}/{userId}")]
        public async Task<IActionResult> DeleteUserBank(int accountId, int userId)
        {
            var bank = await _bankServices.DeleteBankAsync(accountId, userId);
            return StatusCode(bank.StatusCode, bank);
        }
    }
}
