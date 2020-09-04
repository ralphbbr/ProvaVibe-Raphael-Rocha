using System.Data.Entity.ModelConfiguration;

namespace Prova
{
    class FinanceiroApolicesConfigurations : EntityTypeConfiguration<FinanceiroApolices>
    {
        public FinanceiroApolicesConfigurations()
        {
            Property(s => s.IDFINANAPOLICE)
                 .IsRequired();
            HasKey(s => s.IDFINANAPOLICE);

            Property(s => s.NUMPARCELA)
                .IsRequired();


            Property(s => s.DTVENCIMENTO)
                .HasColumnType("datetime2")
                    .IsRequired();

            Property(s => s.VALORPARCELA)
                    .IsRequired();

            Property(s => s.DTPAGTO)
                .HasColumnType("datetime2")
                    .IsOptional();

            Property(s => s.VALORPAGTO)
                .IsOptional();

            Property(s => s.VALORCOMISSAO)
                   .IsOptional();

            Property(s => s.Status)
                   .IsRequired();

        }
    }
}
