using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class TransacoesMap : EntityTypeConfiguration<Transacaoes>
    {
        public TransacoesMap()
        {
            this.ToTable("Transacoes");
            this.HasKey(d => d.id);
            this.Property(d => d.id).HasColumnName("ID_TRANSACAO");
            this.Property(d => d.depositos).HasColumnName("DEPOSITOS");
            this.Property(d => d.saques).HasColumnName("SAQUES");
        }

    }
}
