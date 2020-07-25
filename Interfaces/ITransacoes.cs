using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITransacoes
    {
        [OperationContract]
        void Update(Transacaoes tr);
    }
}
