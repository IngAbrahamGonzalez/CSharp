using PooDemo.Models;

namespace PooDemo.Models
{
    internal class Descontinuados : Cel
    {
        public string AccionDescontinuado(string accion)
        {
            return $"Este telefono: {Nombre} Se encuentra actualmente {accion}";
        }
    }
}