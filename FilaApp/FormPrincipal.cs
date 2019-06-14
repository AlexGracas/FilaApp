using FilaController;
using FilaModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaApp
{
    public partial class FormPrincipal : Form, IFilaView
    {
        public FilaController.FilaController _controller { get; set; } 
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarLabel();

        }

        private void CarregarLabel()
        {
            lblQtdPessoas.Text += "Existem " + _controller._pessoas.Count + 
                " pessoas esperando.";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ((IFilaView)this).LimparFilas();
            _controller.OrdenarFila();
        }
        
        void IFilaView.MostrarFila(string NomeFila, IEnumerable<Pessoa> pessoas)
        {           
            DataGridView dgFila = new DataGridView();
            dgFila.DataSource = pessoas;            
            dgFila.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgFila.Width = 600;
            dgFila.Left = 0;
            dgFila.CellDoubleClick += DgFila_CellDoubleClick;
            var tab = new TabPage(NomeFila);
            tab.Controls.Add(dgFila);
            tabFilas.TabPages.Add(tab);
        }

        private void DgFila_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            Pessoa p = (Pessoa)((IList<Pessoa>)dataGridView.DataSource)[e.RowIndex];
        }

        /// <summary>
        /// Limpa todas as Tabs criadas com as filas.
        /// </summary>
        void IFilaView.LimparFilas()
        {
            tabFilas.TabPages.Clear();
        }

        /// <summary>
        /// Abrirá um formulário com a pessoa a ser selecionada.
        /// Neste método a pessoa deverá selecionar o controle correto a ser
        /// mostrado.
        /// </summary>
        /// <param name="p">A pessoa a ser mostrada.</param>
        public void MostrarPessoa(Pessoa p)
        {
            Form form = new FormPessoa();
            form.ShowDialog();
        }
    }
}
