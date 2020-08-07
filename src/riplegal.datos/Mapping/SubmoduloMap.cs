using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using riplegal.entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace riplegal.datos.Mapping
{
    public class SubmoduloMap : IEntityTypeConfiguration<Submodulo>
    {
        public void Configure(EntityTypeBuilder<Submodulo> builder)
        {
            builder.ToTable("TB_Submodulo").HasKey(s => s.Id);
        }
    }
}
