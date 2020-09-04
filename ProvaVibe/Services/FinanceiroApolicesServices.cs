using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prova
{
    public class FinanceiroApolicesServices
    {
        private readonly ProvaContext _contexto;


        public FinanceiroApolicesServices(ProvaContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<FinanceiroApolices>> ExibirPorCpfDataInicioStatus(string cpf, DateTime dataInicio, StatusApolices status)
        {
            var financeiro = from obj in _contexto.FinanceiroApolices select obj;

            var resultado = from obj in _contexto.FinanceiroApolices select obj;
            resultado = resultado.Where(x => x.Apolices.Segurados.CPF == cpf).Where(x => x.Apolices.DTINIVIG == dataInicio).Where(x => x.Apolices.Status == status).
                Include(x => x.Apolices.Segurados).Include(x => x.Apolices.TiposSeguros);

            return await resultado.ToListAsync();

        }
        public void Inserir(AdicionarApolicesVO obj)
        {

            var apolice = _contexto.Apolices.First(x => x.IDAPOLICE == obj.Apolice);


            var parcela = new FinanceiroApolices()
            {
                Apolices = apolice,
                NUMPARCELA = obj.NumParcela,
                VALORPARCELA = obj.ValorParcela,
                DTVENCIMENTO = obj.DataVencimento
            };

            _contexto.Entry(parcela).State = EntityState.Added;
            _contexto.SaveChanges();
        }

        public decimal CalculoComissao(ParcelaVO parcela)
        {
            return (parcela.Valor * 0.06m) * 0.35m;
        }
    }
}
