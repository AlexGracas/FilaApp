using FilaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaController
{
    public class FilaController
    {

        IFilaView _view;

        public FilaController(IFilaView view, ISet<Pessoa> Pessoas)
        {
            _view = view;
            this._pessoas = Pessoas;
        }

        /// <summary>
        /// Lista completa de Pessoas.
        /// </summary>
        public ISet<Pessoa> _pessoas;


        /// <summary>
        /// Lista de Pessoas Prioritárias. Maiores que 60 Anos.
        /// </summary>
        public IList<Pessoa> FilaPrioridade { get; set; }

        /// <summary>
        /// Lista de Pessoas que são clientes diamante da empresa.
        /// </summary>
        public IList<Pessoa> FilaDiamante { get; set; }

        /// <summary>
        /// Lista de pessoas assentadas nas fileiras da janela.
        /// No caso A e F
        /// </summary>
        public IList<Pessoa> Fila1 { get; set; }


        /// <summary>
        /// Lista de pessoas assentadas nas fileiras do meio.
        /// No caso B e E
        /// </summary>
        public IList<Pessoa> Fila2 { get; set; }

        /// <summary>
        /// Lista de pessoas assentadas na fileira do Corredor.
        /// No caso C e D
        /// </summary>
        public IList<Pessoa> Fila3 { get; set; }

        /// <summary>
        /// Método que popula cada uma das filas de acordo 
        /// com os critérios preestabelecidos.
        /// </summary>
        public void OrdenarFila()
        {            
        }

        /// <summary>
        /// Método que irá executar uma ação quando uma pessoa for selecionada.
        /// Atualmente será mostrar outro controle com a pessoa Selecionada.
        /// </summary>
        /// <param name="p">Pessoa a ser mostrada.</param>
        public void SelecionarPessoa(Pessoa p)
        {
            _view.MostrarPessoa(p);
        }
    }
}
