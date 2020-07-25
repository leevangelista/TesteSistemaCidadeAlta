using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    
    public class UsuarioService : IUsuario
    {
        private Controllers.Repositorios.UsuarioRep rep = new Controllers.Repositorios.UsuarioRep();

        public void Depositar(Entidades.Usuario obj)
        {
            rep.Deposito(obj);
        }

        public List<Entidades.Usuario> Extrato()
        {
            throw new NotImplementedException();
        }

        public void Sacar(Entidades.Usuario obj)
        {
            rep.Sacar(obj);
        }

        public void Transferir(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Buscar(int id)
        {
            return rep.Buscar(id);
        }
    }

    
}
