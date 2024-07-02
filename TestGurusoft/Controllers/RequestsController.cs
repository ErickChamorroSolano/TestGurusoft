using Microsoft.AspNetCore.Mvc;
using TestGurusoft.Data;
using TestGurusoft.Models;

namespace TestGurusoft.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RequestsController : ControllerBase
    {
        private readonly ILogger<RequestsController> _logger;

        public RequestsController(ILogger<RequestsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Requests")]
        public IEnumerable<Requests> Get()
        {
            Registro reg = new Registro();
            List<Requests> oRequests = reg.RecuperarRequests();
            return oRequests.ToArray<Requests>();
        }
    }
}
