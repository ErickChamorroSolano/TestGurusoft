using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestGurusoftWEB.Extensions;
using TestGurusoftWEB.Models;
using TestGurusoftWEB.Servicios;

namespace TestGurusoftWEB.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IServicio_api _servicioapi;

        public HomeController(IServicio_api servicioapi)
        {
            _servicioapi = servicioapi;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Primos()
        {
            FormPrimo miprimo = new FormPrimo();
            return View(miprimo);
        }

        [HttpPost]
        public async Task<IActionResult> Primos(FormPrimo miprimo)
        {
            try
            {
                string respuesta;
                respuesta = await _servicioapi.ObtenerPrimos(miprimo.numero, miprimo.cantidad);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    Notificacion("Exito", $"Los {miprimo.cantidad} números primos encontrados desde {miprimo.numero} son: " + respuesta.Trim().Replace(" ", ","));
                }
                else { 
                    Notificacion("Exito", $"Los {miprimo.cantidad} números primos encontrados desde {miprimo.numero} son: ninguno.");
                }

                return RedirectToAction("Primos");

            }
            catch (Exception ex)
            {
                Notificacion("Error", ex.Message, NotificationType.Error);
                return RedirectToAction("Primos");
            }
        }

        public IActionResult PrimoObtenido(FormPrimo miprimo)
        {
            return View(miprimo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
