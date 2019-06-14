using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModel
{
    public class Pessoa
    {
        public String Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public String CPF { get; set; }

        public Assento Assento { get; set; }
    }
}
