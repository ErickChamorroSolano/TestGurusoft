using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using TestGurusoft.Data;
using TestGurusoft.Models;
using Utilidades;

namespace TestGurusoft.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PrimosController : ControllerBase
    {
        private readonly ILogger<PrimosController> _logger;

        public PrimosController(ILogger<PrimosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Primos")]
        public Requests Get(int numero, int cantidad)
        {
            Requests oRequest = new Requests();
            utilidades util = new utilidades();
            Registro reg = new Registro();
            List<int> Primos = util.CalcularPrimos(numero, cantidad);

            oRequest.request = $"http://localhost:5033/Primos?numero={numero}&cantidad={cantidad}";
            foreach (int i in Primos) { 
                oRequest.response += i.ToString() + " ";
            }
            oRequest.usuario = util.ObtenerIP();

            int id = reg.InsertarRequest(oRequest);

            Requests respuesta = reg.RecuperarRequestPorID(id);
            return respuesta;
        }
    }
}
