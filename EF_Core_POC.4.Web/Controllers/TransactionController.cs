using Nullnes.EF_Core_POC.Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Nullnes.EF_Core_POC.Application.Controllers
{
    [Route("Transaction")]
    public class TransactionController : Controller
    {
        private RunAwayFromSerasaContext _dbContext;
        private readonly ILogger<TransactionController> _logger;

        #region Constructor

        public TransactionController(ILogger<TransactionController> logger, RunAwayFromSerasaContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        #endregion

        [HttpGet]
        public IActionResult Index()
        {
            _logger.Log(LogLevel.Trace, "Begin: Account/Index");


            _logger.Log(LogLevel.Trace, "End: Account/Index");
            return Ok("");
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create()
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