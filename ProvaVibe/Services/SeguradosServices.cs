using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Prova
{
    public    class SeguradosServices
    {
        private readonly ProvaContext _contexto;
        public SeguradosServices(ProvaContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Segurados>> ExibirTodos()
        {
            return await _contexto.Segurados.OrderBy(x => x.NOMESEGURADO).ToListAsync();
        }

        public async Task<List<Segurados>> ExibirPeloCPF(string CPF )
        {
            var busca = from obj in _contexto.Segurados select obj;
            busca = busca.Where(x => x.CPF == CPF);

            return await busca
                .ToListAsync();
        }
    }
}
