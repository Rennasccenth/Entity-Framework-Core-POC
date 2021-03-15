using System;
using System.Linq;
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
    // TODO: ADD Fluent Validation
    [Route("Account")]
    public class AccountController : BaseController
    {
        private ITransactionAppService _appService;

        #region Constructor

        public AccountController(ILogger<AccountController> logger, RunAwayFromSerasaContext context,
            RunAwayFromSerasaSettings settings, ITransactionAppService transactionAppService)
            : base(logger, context, settings)
        {
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

        [HttpGet]
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