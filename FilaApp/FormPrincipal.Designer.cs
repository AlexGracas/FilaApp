namespace FilaApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFilas = new System.Windows.Forms.TabControl();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdenar.Location = new System.Drawing.Point(15, 64);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(201, 23);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(FilaModel.Pessoa);
            // 
            // tabFilas
            // 
            this.tabFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFilas.Location = new System.Drawing.Point(222, 16);
            this.tabFilas.Name = "tabFilas";
            this.tabFilas.SelectedIndex = 0;
            this.tabFilas.Size = new System.Drawing.Size(988, 438);
            this.tabFilas.TabIndex = 4;
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.AutoSize = true;
            this.lblQtdPessoas.Location = new System.Drawing.Point(12, 31);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(35, 13);
            this.lblQtdPessoas.TabIndex = 5;
            this.lblQtdPessoas.Text = "label1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 492);
            this.Controls.Add(this.lblQtdPessoas);
            this.Controls.Add(this.tabFilas);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.TabControl tabFilas;
        private System.Windows.Forms.Label lblQtdPessoas;
    }
}

