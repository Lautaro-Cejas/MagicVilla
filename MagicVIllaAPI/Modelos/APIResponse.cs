using System.Net;

namespace MagicVillaAPI.Modelos
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsExitoso { get; set; } = true;

        public List<string> ErrorMessages { get; set; }

        public Object Resultado { get; set; }
    }
}
