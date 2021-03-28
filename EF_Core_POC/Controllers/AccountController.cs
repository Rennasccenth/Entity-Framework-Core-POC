using System;
using System.Linq;
using System.Reflection;
using EF_Core_POC.AppService.Interfaces;
using EF_Core_POC.Data;
using EF_Core_POC.Models.Entity;
using EF_Core_POC.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EF_Core_POC.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        private ITransactionAppService _appService;
        private RunAwayFromSerasaContext _dbContext;
        private readonly ILogger<AccountController> _logger;

        #region Constructor

        public AccountController(ILogger<AccountController> logger, RunAwayFromSerasaContext dbContext,
            ITransactionAppService transactionAppService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _appService = transactionAppService;
        }

        #endregion

        [HttpGet]
        public IActionResult Index()
        {
            _logger.Log(LogLevel.Trace, "Begin: Account/Index");

            
            
            _logger.Log(LogLevel.Trace, "End: Account/Index");
            return Ok();
        }

        [HttpPut]
        [Route("Create")]
        public IActionResult Create(string name)
        {
            _logger.Log(LogLevel.Trace, "Begin: Account/Create");
            
            

            _logger.Log(LogLevel.Trace, "End: Account/Create");
            return Ok();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update()
        {
            _logger.Log(LogLevel.Trace, "Begin: Account/Update");

            
            
            _logger.Log(LogLevel.Trace, "End: Account/Update");
            return Ok();
        }

        [HttpDelete]
        [Route("Remove")]
        public IActionResult Remove()
        {
            _logger.Log(LogLevel.Trace, "Begin: Account/Remove");


            
            _logger.Log(LogLevel.Trace, "End: Account/Remove");
            return Ok();
        }
    }
}