using FilaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaController
{
    public interface IFilaView
    {
        void MostrarFila(String NomeFila, IEnumerable<Pessoa> pessoas);
        void LimparFilas();
        void MostrarPessoa(Pessoa p);
    }
}
