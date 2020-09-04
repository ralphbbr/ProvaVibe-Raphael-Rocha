using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;

namespace Prova
{
    public class ProvaDBInitializer : DropCreateDatabaseIfModelChanges<ProvaContext>
    {
        protected override void Seed(ProvaContext context)
        {
            IList<TiposSeguros> tiposSeguros = new List<TiposSeguros>();
            IList<Segurados> segurados = new List<Segurados>();
            IList<Apolices> apolices = new List<Apolices>();
            IList<FinanceiroApolices> financeiroApolices = new List<FinanceiroApolices>();

            segurados.Add(new Segurados() { NOMESEGURADO = "FERNANDO FLORES", DTNASC = DateTime.Parse("20/03/1995"), CPF = "4561237892" });
            segurados.Add(new Segurados() { NOMESEGURADO = "RAPHAEL ROCHA", DTNASC = DateTime.Parse("18/06/1996"), CPF = "1234567890" });
            segurados.Add(new Segurados() { NOMESEGURADO = "MANOLLO JACOB", DTNASC = DateTime.Parse("05/03/1990"), CPF = "9876543210" });
            segurados.Add(new Segurados() { NOMESEGURADO = "KARLA KAWAGUCHI", DTNASC = DateTime.Parse("03/12/1992"), CPF = "4567893210" });
            segurados.Add(new Segurados() { NOMESEGURADO = "DOMINGOS NETO", DTNASC = DateTime.Parse("05/10/1997"), CPF = "1239874560" });
            segurados.Add(new Segurados() { NOMESEGURADO = "IAGO SOARES", DTNASC = DateTime.Parse("15/08/1985"), CPF = "1597538246" });

            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "CONSIGNADO", CARENCIA = 30 });
            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "ACIDENTES PESSOAIS", CARENCIA = 0 });
            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "VIDA SIMPLES", CARENCIA = 30 });
            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "VIDA COMPLICADA", CARENCIA = 30 });

            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
            ,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_FIM_DE_VIGENCIA,
                TiposSeguros = tiposSeguros[3],
                Segurados = segurados[0]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.ATIVO,
                TiposSeguros = tiposSeguros[3],
                Segurados = segurados[0]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_CANCELAMENTO,
                TiposSeguros = tiposSeguros[2],
                Segurados = segurados[0]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_CANCELAMENTO,
                TiposSeguros = tiposSeguros[1],
                Segurados = segurados[2]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.ATIVO,
                TiposSeguros = tiposSeguros[2],
                Segurados = segurados[5]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.ATIVO,
                TiposSeguros = tiposSeguros[1],
                Segurados = segurados[4]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_CANCELAMENTO,
                TiposSeguros = tiposSeguros[1],
                Segurados = segurados[3]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_FIM_DE_VIGENCIA,
                TiposSeguros = tiposSeguros[2],
                Segurados = segurados[2]
            });
            apolices.Add(new Apolices()
            {
                DTFIMVIG = DateTime.Parse("20/03/2000"),
                DTINIVIG = DateTime.Parse("20/03/1998"),
                DTCANCELAMENTO = DateTime.Parse("20/03/1998")
,
                MOTIVOCANCELAMENTO = "TESTE",
                Status = StatusApolices.DESATIVADO_POR_CANCELAMENTO,
                TiposSeguros = tiposSeguros[0],
                Segurados = segurados[1]
            });

            financeiroApolices.Add(new FinanceiroApolices()
            {
                DTPAGTO = DateTime.Parse("20/03/2000"),
                DTVENCIMENTO = DateTime.Parse("20/03/2000"),
                VALORCOMISSAO = decimal.Parse("10.50", CultureInfo.InvariantCulture)
            ,
                NUMPARCELA = 10,
                Status = StatusFicanceiroApolices.VENCIDA,
                VALORPAGTO = decimal.Parse("1050", CultureInfo.InvariantCulture),
                VALORPARCELA = decimal.Parse("105", CultureInfo.InvariantCulture)
            ,
                Apolices = apolices[0]
            });
            financeiroApolices.Add(new FinanceiroApolices()
            {
                DTPAGTO = DateTime.Parse("20/03/2000"),
                DTVENCIMENTO = DateTime.Parse("20/03/2000"),
                VALORCOMISSAO = decimal.Parse("10.50", CultureInfo.InvariantCulture)
,
                NUMPARCELA = 10,
                Status = StatusFicanceiroApolices.PAGO,
                VALORPAGTO = decimal.Parse("1050", CultureInfo.InvariantCulture),
                VALORPARCELA = decimal.Parse("105", CultureInfo.InvariantCulture)
,
                Apolices = apolices[3]
            });
            financeiroApolices.Add(new FinanceiroApolices()
            {
                DTPAGTO = DateTime.Parse("20/03/2000"),
                DTVENCIMENTO = DateTime.Parse("20/03/2000"),
                VALORCOMISSAO = decimal.Parse("10.50", CultureInfo.InvariantCulture)
,
                NUMPARCELA = 10,
                Status = StatusFicanceiroApolices.NAO_PAGO,
                VALORPAGTO = decimal.Parse("1150", CultureInfo.InvariantCulture),
                VALORPARCELA = decimal.Parse("125", CultureInfo.InvariantCulture)
,
                Apolices = apolices[2]
            });
            financeiroApolices.Add(new FinanceiroApolices()
            {
                DTPAGTO = DateTime.Parse("20/03/2000"),
                DTVENCIMENTO = DateTime.Parse("20/03/2000"),
                VALORCOMISSAO = decimal.Parse("0.50", CultureInfo.InvariantCulture)
,
                NUMPARCELA = 10,
                Status = StatusFicanceiroApolices.PAGO,
                VALORPAGTO = decimal.Parse("1450", CultureInfo.InvariantCulture),
                VALORPARCELA = decimal.Parse("195", CultureInfo.InvariantCulture)
,
                Apolices = apolices[1]
            });


            context.TiposSeguros.AddRange(tiposSeguros);
            context.Segurados.AddRange(segurados);
            context.Apolices.AddRange(apolices);
            context.FinanceiroApolices.AddRange(financeiroApolices);

            base.Seed(context);
        }
    }
}