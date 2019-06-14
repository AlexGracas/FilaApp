using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModel
{
    class Voo
    {
        public Cidade Origem { get; set; }

        public Cidade Destino { get; set; }

        public ISet<Assento> Assentos { get; set; }

    }
}
