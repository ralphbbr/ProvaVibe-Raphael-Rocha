using System.Data.Entity.ModelConfiguration;


namespace Prova
{
    public class ApolicesConfigurations : EntityTypeConfiguration<Apolices>
    {
        public ApolicesConfigurations()
        {

            Property(s => s.IDAPOLICE)
                    .IsRequired();
            HasKey(s => s.IDAPOLICE);


            Property(s => s.DTINIVIG)
                .HasColumnType("datetime2")
                .IsRequired();


            Property(s => s.DTFIMVIG)
                .HasColumnType("datetime2")
                    .IsRequired();

            Property(s => s.DTCANCELAMENTO)
                .HasColumnType("datetime2")
                    .IsOptional();

            Property(s => s.MOTIVOCANCELAMENTO)
                    .IsOptional()
                    .HasMaxLength(400);


            Property(s => s.Status)
                   .IsRequired();
        }
    }
}
