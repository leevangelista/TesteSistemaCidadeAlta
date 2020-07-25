using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
   public class UsuarioRep
   {


        public void Deposito(Entidades.Usuario UNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Usuario UAntigo = ctx.Usuarios.Find(UNovo.Id);
                UAntigo.Nome = UNovo.Nome;
                UAntigo.Saldo = UNovo.Saldo;
                ctx.SaveChanges();
            }

        }

        public void Sacar(Entidades.Usuario UNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Usuario UAntigo = ctx.Usuarios.Find(UNovo.Id);
                if(UAntigo.Saldo > UNovo.Saldo)
                {
                    UAntigo.Nome = UNovo.Nome;
                    UAntigo.Saldo = UNovo.Saldo;
                    ctx.SaveChanges();
                }
                
            }

        }


        public Usuario Buscar(int id)
        {
            Usuario obj = new Usuario();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Usuarios.Find(id);
            }
            return obj;
        }




        // #### CODIGO ABAIXO FEITO APENAS PARA TER DOIS USUARIOS DO BANCO, DESCULPE FOI O MELHOR QUE CONSEGUI PENSAR
        public void conta1()
        {
            Usuario obj = new Usuario();
            obj.Id = 01;
            obj.Nome = "Leonardo";
            obj.Saldo = 100.00;


            using (var ctx = new SistemaContext())
            {
                ctx.Usuarios.Add(obj);
                ctx.SaveChanges();
            }

        }

        public void conta2()
        {
            Usuario obj = new Usuario();
            obj.Id = 02;
            obj.Nome = "Maria";
            obj.Saldo = 200.00;


            using (var ctx = new SistemaContext())
            {
                ctx.Usuarios.Add(obj);
                ctx.SaveChanges();
            }

        }



    }
}
