using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            this.ToTable("Usuario");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_USUARIO");
            this.Property(d => d.Nome).HasColumnName("NOME_USUARIO");
            this.Property(d => d.Saldo).HasColumnName("TELEFONE_USUARIO");
        }
    }
}
