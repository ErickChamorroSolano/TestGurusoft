using Microsoft.AspNetCore.Mvc;

namespace TestGurusoftWEB.Extensions
{
    public enum NotificationType
    {
        Success,
        Error,
        Info
    }

    public class BaseController: Controller
    {

        public void Notificacion(string titulo = "", string mensaje = "", NotificationType type = NotificationType.Success)
        {
            TempData["Notification"] = $"Swal.fire('{titulo}','{mensaje}','{type.ToString().ToLower()}')";
        }
    }
}
