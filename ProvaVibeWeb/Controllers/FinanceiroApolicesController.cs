using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prova
{
    public class FinanceiroApolicesController : ApiController
    {
        private readonly FinanceiroApolicesServices _financeiroApolicesServices;
        private readonly ProvaContext contexto = new ProvaContext();
        public FinanceiroApolicesController(FinanceiroApolicesServices financeiroApolicesServices)
        {
            _financeiroApolicesServices = financeiroApolicesServices;
        }
        public FinanceiroApolicesController()
        {
            _financeiroApolicesServices = new FinanceiroApolicesServices(contexto);
        }

        [HttpPost, Route("prova/questao1")]
        public async Task<List<FinanceiroApolices>> Exibir(string cpf, DateTime dataInicio, StatusApolices status)
        {
            var finApolices = await _financeiroApolicesServices.ExibirPorCpfDataInicioStatus(cpf, dataInicio, status);
            return finApolices;
        }



        [HttpPost, Route("prova/questao2")]
        public HttpResponseMessage Adicionar(AdicionarApolicesVO parcela)
        {
            _financeiroApolicesServices.Inserir(parcela);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost, Route("prova/questao4")]
        public decimal CalculoComissao(ParcelaVO parcela)
        {

            return _financeiroApolicesServices.CalculoComissao(parcela);

        }
    }
}