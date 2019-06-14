using FilaController;
using FilaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaControllerTest
{
    class FakeFilaView : IFilaView
    {
        public void LimparFilas()
        {
            return;
        }

        public void MostrarFila(string NomeFila, IEnumerable<Pessoa> pessoas)
        {
            System.Console.WriteLine("Fila: " + NomeFila);
            foreach(var p in pessoas)
            {
                System.Console.Write(p.Nome + " Nascimento:" +p.Nascimento.Date.ToShortDateString() );
                if (p.Assento != null)
                {
                    System.Console.Write(" Assento:" + p.Assento.ToString());
                }
                System.Console.WriteLine();
            }
        }

        public void MostrarPessoa(Pessoa p)
        {
            throw new NotImplementedException();
        }
    }
}
