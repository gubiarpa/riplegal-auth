using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using riplegal.entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace riplegal.datos.Mapping
{
    public class SistemaMap : IEntityTypeConfiguration<Sistema>
    {
        public void Configure(EntityTypeBuilder<Sistema> builder)
        {
            builder.ToTable("TB_Sistema").HasKey(m => m.Id);
        }
    }
}
