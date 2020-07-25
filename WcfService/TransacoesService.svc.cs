using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TransacoesService : ITransacoes
    {
        private TransacoesRep rep = new TransacoesRep();

        public void Update(Transacaoes tr)
        {
            rep.Upadate(tr);
        }
        public List<Transacaoes> Extrato()
        {
            return rep.Extrato();
        }
    }
}
