using System.Dynamic;
using System.Net;

namespace Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp {get; set;}
        public T? DadosRetornados {get; set;}
        public ExpandoObject? ErroRetornado {get; set;}
    }
}