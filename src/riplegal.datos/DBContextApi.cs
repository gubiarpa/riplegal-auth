using Microsoft.EntityFrameworkCore;
using riplegal.datos.Mapping;
using riplegal.entidades.Models;

namespace riplegal.datos
{
    public class DBContextApi : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Modulo> Modulos { get; set; }

        public DBContextApi(DbContextOptions<DBContextApi> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new ModuloMap());
        }
    }
}
