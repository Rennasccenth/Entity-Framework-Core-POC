using EF_Core_POC.Data;
using EF_Core_POC.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Core_POC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> _logger;
        protected ISession Session => HttpContext.Session;
        protected readonly RunAwayFromSerasaContext _context;
        protected readonly RunAwayFromSerasaSettings _settings ;
        
        
        public BaseController(ILogger<BaseController> logger,
            RunAwayFromSerasaContext context,
            RunAwayFromSerasaSettings settings
        )
        {
            _logger = logger;
            _context = context;
            _settings = settings;
        }
    }
}