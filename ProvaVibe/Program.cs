using System;
using System.Linq;


namespace Prova
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contexto = new ProvaContext();


            var tiposSeguros = contexto.TiposSeguros.Select(s => s);
            var segurados = contexto.Segurados.Select(s => s);
            var apolices = contexto.Apolices.Select(s => s);
            var financeiroApolices = contexto.FinanceiroApolices.Select(s => s);




            Console.WriteLine("Banco Inicializado.");
            Console.ReadLine();


       }

    }
}