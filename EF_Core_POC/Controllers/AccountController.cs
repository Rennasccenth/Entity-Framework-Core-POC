using System.Linq;
using EF_Core_POC.Data;
using EF_Core_POC.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace EF_Core_POC.Controllers
{
    // TODO: ADD Fluent Validation
    [Route("Account")]
    public class AccountController : BaseController
    {
        #region Constructor

        public AccountController(ILogger logger, RunAwayFromSerasaContext context,
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