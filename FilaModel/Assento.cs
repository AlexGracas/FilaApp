using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModel
{
    public class Assento
    {
        public String Coluna { get; set; }

        public int Fila { get; set; }

        public Pessoa Passageiro {get;set;}

        public bool Especial { get; set; }

        public override string ToString()
        {
            return this.Fila.ToString() + this.Coluna + (this.Especial ? " - Cliente Diamante.": ".");
        }
    }
}
