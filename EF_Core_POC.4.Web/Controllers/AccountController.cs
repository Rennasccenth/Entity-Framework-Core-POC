using Nullnes.EF_Core_POC.Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nullnes.EF_Core_POC.Application.Service.Interfaces;

namespace Nullnes.EF_Core_POC.Application.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private ITransactionAppService _appService;
        private RunAwayFromSerasaContext _dbContext;

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