using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using riplegal.entidades.Models;

namespace riplegal.datos.Mapping
{
    public class ModuloMap : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("TB_Modulo").HasKey(m => m.Id);
        }
    }
}
