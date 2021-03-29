using Infra.Data;
using WebApplication.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    [Route("Transaction")]
    public class TransactionController : Controller
    {
        private ILogger<TransactionController> _logger;
        private RunAwayFromSerasaContext _dbContext;

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