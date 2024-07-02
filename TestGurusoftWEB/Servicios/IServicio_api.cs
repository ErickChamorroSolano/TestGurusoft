using TestGurusoftAPI.Models;
using TestGurusoftWEB.Models;

namespace TestGurusoftWEB.Servicios
{
    public interface IServicio_api
    {
        Task<string> ObtenerPrimos(int numero, int cantidad);
    }
}
