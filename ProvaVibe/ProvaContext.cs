using System.Data.Entity;

namespace Prova
{
    public class ProvaContext : DbContext
    {
        public ProvaContext() : base("BancoProva")
        {
            Database.SetInitializer(new ProvaDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TiposSegurosConfigurations());
            modelBuilder.Configurations.Add(new SeguradosConfigurations());
            modelBuilder.Configurations.Add(new ApolicesConfigurations());
            modelBuilder.Configurations.Add(new FinanceiroApolicesConfigurations());

        }

        public DbSet<TiposSeguros> TiposSeguros { get; set; }
        public DbSet<Segurados> Segurados { get; set; }
        public DbSet<Apolices> Apolices { get; set; }
        public DbSet<FinanceiroApolices> FinanceiroApolices { get; set; }


    }
}