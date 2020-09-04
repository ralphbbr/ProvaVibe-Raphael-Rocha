using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prova;

namespace ProvaVibeWeb.Controllers
{
    public class ApolicesController : ApiController
    {
        private readonly ApolicesServices _apolicesServices;
        private readonly ProvaContext contexto = new ProvaContext();
        public ApolicesController(ApolicesServices apolicesServices)
        {
            _apolicesServices = apolicesServices;
        }

        public ApolicesController()
        {
            _apolicesServices = new ApolicesServices(contexto);
        }


        [HttpPost, Route("prova/questao3")]
        public HttpResponseMessage Cancelar(CancelamentoApolicesVO cancelamentoApolicesVO)
        {
            _apolicesServices.AtualizarApolice(cancelamentoApolicesVO);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}