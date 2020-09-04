using System;
using System.ComponentModel.DataAnnotations;

namespace Prova
{
    public class FinanceiroApolices
    {
        public int IDFINANAPOLICE { get; set; }
        public int NUMPARCELA { get; set; }

        public DateTime DTVENCIMENTO { get; set; }

        [DisplayFormat(DataFormatString = "{F2}")]
        public decimal VALORPARCELA { get; set; }
        public DateTime DTPAGTO { get; set; }

        [DisplayFormat(DataFormatString = "{F2}")]
        public decimal VALORPAGTO { get; set; }

        [DisplayFormat(DataFormatString = "{F2}")]
        public decimal VALORCOMISSAO { get; set; }
        public StatusFicanceiroApolices Status { get; set; }

        public Apolices Apolices { get; set; }
    }
}
