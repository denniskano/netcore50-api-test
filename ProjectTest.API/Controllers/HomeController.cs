﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjectTest.API.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Initial Home Get");
            return "Net Core 5.0 Running ... 08082021-v1.0.0 Azure DevOps AFORO255 changed by jack - one more time. pipeline 1";
        }
    }
}
