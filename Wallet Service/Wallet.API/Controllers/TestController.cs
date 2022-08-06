using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;

namespace Wallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ITestServices _testService;

        public TestController(ITestServices testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public async Task<IActionResult> Banks()
        {
            var result = await _testService.GetBanksAsync();
            return Ok(result);
        }
    }
}
