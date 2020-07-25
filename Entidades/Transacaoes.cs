using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Transacaoes
    {
        public int id { get; set; }
        public string depositos { get; set; }
        public string saques { get; set; }
        public string transferencia { get; set; }

        public Transacaoes()
        {
            id = 0;
            depositos = "DP"+id;
            saques = "SQ"+id;
            transferencia = "TF"+id;
        }

    }
}
