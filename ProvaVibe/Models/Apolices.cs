using System;

namespace Prova
{
    public class Apolices
    {
        public int IDAPOLICE { get; set; }

        public DateTime DTINIVIG { get; set; }

        public DateTime DTFIMVIG { get; set; }

        public DateTime DTCANCELAMENTO { get; set; }
        public string MOTIVOCANCELAMENTO { get; set; }

        public Segurados Segurados { get; set; }

        public TiposSeguros TiposSeguros { get; set; }

        public StatusApolices Status { get; set; }
    }
}
