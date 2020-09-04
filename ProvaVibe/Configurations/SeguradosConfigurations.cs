using System.Data.Entity.ModelConfiguration;

namespace Prova
{
    public class SeguradosConfigurations : EntityTypeConfiguration<Segurados>
    {
        public SeguradosConfigurations()
        {


            Property(s => s.IDSEGURADO)
                    .IsRequired();
            HasKey(s => s.IDSEGURADO);

            Property(s => s.NOMESEGURADO)
                .IsRequired()
                .HasMaxLength(400);

            Property(s => s.DTNASC)
                .HasColumnType("datetime2")
                    .IsRequired();

            Property(s => s.CPF)
                    .IsRequired()
                    .HasMaxLength(11);


        }

    }
}
