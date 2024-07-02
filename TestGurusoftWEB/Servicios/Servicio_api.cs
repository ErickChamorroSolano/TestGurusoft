using TestGurusoft.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace TestGurusoftWEB.Servicios
{
    public class Servicio_api: IServicio_api
    {
        private static string _baseurl;

        public Servicio_api()
        {
            _baseurl = "http://localhost:5033/";
        }

        public async Task<string> ObtenerPrimos(int numero, int cantidad)
        {
            string? respuesta = null;
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseurl);
            var content = new StringContent(_baseurl, Encoding.UTF8, "application/json");
            var response = await cliente.GetAsync($"Primos?numero={numero}&cantidad={cantidad}");
            if (response.IsSuccessStatusCode)
            {
                var mi_json = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<Requests>(mi_json);
                respuesta = resultado.response;
            }

            return respuesta;
        }
    }
}
