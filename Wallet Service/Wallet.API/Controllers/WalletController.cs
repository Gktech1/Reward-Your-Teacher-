using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Wallet.Model;
using Wallet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Utilties;
using Microsoft.Extensions.Configuration;
using Wallet.API.Services;
using Wallet.Dtos;

namespace Wallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {

        private readonly UrlConfiguration _walletOptions;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<WalletController> _logger;
        private readonly IMapper _mapper;
        private readonly IWalletServices _walletServices;

        public WalletController(ILogger<WalletController> logger, IMapper mapper, IWalletServices walletServices)
        {
            _mapper = mapper;
            _logger = logger;
            _walletServices = walletServices;


        }


        [HttpPost]
        public async Task<IActionResult> CreateWallet(UserWalletDto userWalletDto)
        {
            var result = await _walletServices.CreateWalletAsync(userWalletDto);
            return StatusCode(result.StatusCode, result);
        }


        [HttpPatch("{userId}/activate")]
        public async Task<IActionResult> ActivateWallet(string userId)
        {
            var result = await _walletServices.ActivateWallet(userId);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPatch("{userId}/deactivate")]

        public async Task<IActionResult> DeactivateWallet(string userId)
        {
            var result = await _walletServices.DeactivateWallet(userId);
            return StatusCode(result.StatusCode, result);
        }


        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserWallet(string userId)
        {
            var result = await _walletServices.GetUserWalletAsync( userId);
            return StatusCode(result.StatusCode, result);
        }

    }
}