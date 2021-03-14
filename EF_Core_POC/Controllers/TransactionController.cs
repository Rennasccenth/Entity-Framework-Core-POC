using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace EF_Core_POC.Controllers
{
    [Route("Transaction")]
    public class TransactionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
        
        [HttpPost]
        [Route("Create")]
        public IActionResult Create()
        {
            return Ok();
        }
        
        [HttpPost]
        [Route("Update")]
        public IActionResult Update()
        {
            return Ok();
        }
        
        [HttpDelete]
        [Route("Remove")]
        public IActionResult Remove()
        {
            return Ok();
        }
    }
}