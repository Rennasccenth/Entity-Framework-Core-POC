using EF_Core_POC.Data;
using EF_Core_POC.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace EF_Core_POC.Controllers
{
    [Route("Transaction")]
    public class TransactionController : BaseController
    {
        #region Constructor

        public TransactionController(ILogger logger, RunAwayFromSerasaContext context,
            RunAwayFromSerasaSettings settings)
            : base(logger, context, settings)
        {
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