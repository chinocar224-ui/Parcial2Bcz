using System.Data.Entity;

namespace CadParcial2Bcz
{
    public class Parcial2BczEntities : DbContext
    {
        public Parcial2BczEntities()
            : base("name=Parcial2BczEntities")
        {
        }

        public virtual DbSet<Canal>             Canal             { get; set; }
        public virtual DbSet<Programa>          Programa          { get; set; }
        public virtual DbSet<CategoriaPrograma> CategoriaPrograma { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Canal>()
                .ToTable("Canal").HasKey(c => c.id);

            modelBuilder.Entity<CategoriaPrograma>()
                .ToTable("CategoriaPrograma").HasKey(c => c.id);
            modelBuilder.Entity<CategoriaPrograma>()
                .Property(c => c.nombre).HasMaxLength(30);

            modelBuilder.Entity<Programa>()
                .ToTable("Programa").HasKey(p => p.id);
            modelBuilder.Entity<Programa>()
                .Property(p => p.titulo).HasMaxLength(100);
            modelBuilder.Entity<Programa>()
                .Property(p => p.descripcion).HasMaxLength(250);
            modelBuilder.Entity<Programa>()
                .Property(p => p.productor).HasMaxLength(100);

            modelBuilder.Entity<Programa>()
                .HasRequired(p => p.Canal)
                .WithMany()
                .HasForeignKey(p => p.idCanal);

            modelBuilder.Entity<Programa>()
                .HasRequired(p => p.CategoriaPrograma)
                .WithMany()
                .HasForeignKey(p => p.idCategoriaPrograma);
        }
    }
}
