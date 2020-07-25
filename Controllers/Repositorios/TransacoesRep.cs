using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class TransacoesRep
    {
        public void Upadate (Entidades.Transacaoes Tr)
        {
            using( var ctx = new SistemaContext())
            {
                ctx.Transacoes.Add(Tr);
                ctx.SaveChanges();
            }
        }

        public List<Transacaoes> Extrato()
        {
            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Transacoes select obj).OrderBy(x => x.id).ToList();
                return Dentistas;
            }
        }

    }
}
