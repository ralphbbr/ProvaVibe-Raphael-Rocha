using System;
using System.Data.Entity;
using System.Linq;

namespace Prova
{
    public class ApolicesServices
    {
        private readonly ProvaContext _contexto;

        public ApolicesServices(ProvaContext contexto)
        {
            _contexto = contexto;
        }

        public void Inserir(AdicionarApolicesVO obj)
        {   
            _contexto.Entry(obj).State = EntityState.Added;
            _contexto.SaveChanges();
        }

        public void AtualizarApolice(CancelamentoApolicesVO obj)
        {
            bool hasAny = _contexto.Apolices.Any(x => x.IDAPOLICE == obj.Apolice);
            if (!hasAny)
            {
                throw new Exception();
            }
            try
            {
                var apolice = _contexto.Apolices.First(x => x.IDAPOLICE == obj.Apolice);
                apolice.MOTIVOCANCELAMENTO = obj.MotivoCancelamento;
                apolice.DTCANCELAMENTO = obj.DataCancelamento;
                apolice.Status = StatusApolices.DESATIVADO_POR_CANCELAMENTO;

                _contexto.Entry(apolice).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
