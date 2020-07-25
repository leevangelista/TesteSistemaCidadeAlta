using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        void Depositar(Usuario obj);

        [OperationContract]
        void Sacar(Entidades.Usuario obj);

        [OperationContract]
        List<Usuario>Extrato();

        [OperationContract]
        void Transferir(int id);
    }
}
