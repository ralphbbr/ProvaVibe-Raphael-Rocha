using System;
using Newtonsoft.Json;

namespace Prova
{
    public class ExibirApolicesVO
    {
        public string Cpf { get; set; }
        public DateTime DataInicio { get; set; }

        public StatusApolices Status { get; set; }

    }
}
