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
            lblQtdPessoas.Text += "Existem " + _controller._pessoas.Count + " pessoas esperando.";

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            _controller.OrdenarFila();
        }
        
        void IFilaView.MostrarFila(string NomeFila, IEnumerable<Pessoa> pessoas)
        {
           
            DataGridView dgFila = new DataGridView();
            dgFila.DataSource = pessoas;            
            dgFila.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgFila.Width = 600;
            dgFila.Left = 0;
            var tab = new TabPage(NomeFila);
            tab.Controls.Add(dgFila);
            tabFilas.TabPages.Add(tab);
        }

        void IFilaView.LimparFilas()
        {
            tabFilas.TabPages.Clear();
        }

        private void fLMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
