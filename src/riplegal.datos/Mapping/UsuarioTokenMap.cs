using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using riplegal.entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace riplegal.datos.Mapping
{
    public class UsuarioTokenMap : IEntityTypeConfiguration<UsuarioToken>
    {
        public void Configure(EntityTypeBuilder<UsuarioToken> builder)
        {
            builder.ToTable("TB_UsuarioToken").HasKey(x => x.Id);
        }
    }
}
