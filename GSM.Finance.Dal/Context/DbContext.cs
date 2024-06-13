using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cartao> Cartao { get; set; }
        public DbSet<Faturas> Faturas { get; set; }
        public DbSet<Movimento> Movimento { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<RelCartaoPerfil> RelCartaoPerfil { get; set; }
        public DbSet<RelFaturaCartao> RelFaturaCartao { get; set; }
        public DbSet<RelMovimentoCartao> RelMovimentoCartao { get; set; }
        public DbSet<RelPerfilTipoMovimento> RelPerfilTipoMovimento { get; set; }
        public DbSet<TipoMovimento> TipoMovimento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
