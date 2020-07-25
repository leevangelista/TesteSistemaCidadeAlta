using Controllers.Map;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace Controllers.Context
{
    class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-THHNDIF\\SQLEXPRESS; Database=odonto;Integrated Security=True;")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Transacaoes> Transacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new TransacoesMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
