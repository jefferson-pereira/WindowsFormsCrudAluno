namespace WindowsFormsCrudAluno
{
    partial class FrmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            this.CadastroAluno = new System.Windows.Forms.GroupBox();
            this.boxSexo1 = new WindowsFormsCrudAluno.Controles.BoxSexoAluno();
            this.Limpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.txtNumCpf = new WindowsFormsCrudAluno.Controles.txtNumCpf();
            this.txtData = new WindowsFormsCrudAluno.Controles.txtData();
            this.txtMatricula = new WindowsFormsCrudAluno.Controles.txtMatricula();
            this.txtNome = new WindowsFormsCrudAluno.Controles.txt();
            this.PesquisaAluno = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.txtPesquisar = new WindowsFormsCrudAluno.Controles.txt();
            this.CadastroAluno.SuspendLayout();
            this.PesquisaAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastroAluno
            // 
            this.CadastroAluno.Controls.Add(this.boxSexo1);
            this.CadastroAluno.Controls.Add(this.Limpar);
            this.CadastroAluno.Controls.Add(this.label5);
            this.CadastroAluno.Controls.Add(this.label4);
            this.CadastroAluno.Controls.Add(this.label3);
            this.CadastroAluno.Controls.Add(this.label2);
            this.CadastroAluno.Controls.Add(this.label1);
            this.CadastroAluno.Controls.Add(this.Adicionar);
            this.CadastroAluno.Controls.Add(this.txtNumCpf);
            this.CadastroAluno.Controls.Add(this.txtData);
            this.CadastroAluno.Controls.Add(this.txtMatricula);
            this.CadastroAluno.Controls.Add(this.txtNome);
            this.CadastroAluno.Location = new System.Drawing.Point(12, 2);
            this.CadastroAluno.Name = "CadastroAluno";
            this.CadastroAluno.Size = new System.Drawing.Size(1037, 164);
            this.CadastroAluno.TabIndex = 0;
            this.CadastroAluno.TabStop = false;
            this.CadastroAluno.Text = "Novo Aluno";
            // 
            // boxSexo1
            // 
            this.boxSexo1.FormattingEnabled = true;
            this.boxSexo1.Location = new System.Drawing.Point(6, 113);
            this.boxSexo1.Name = "boxSexo1";
            this.boxSexo1.Size = new System.Drawing.Size(170, 28);
            this.boxSexo1.TabIndex = 2;
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(826, 114);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 27);
            this.Limpar.TabIndex = 5;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Matrícula";
            // 
            // Adicionar
            // 
            this.Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.Location = new System.Drawing.Point(926, 113);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(94, 28);
            this.Adicionar.TabIndex = 6;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // txtNumCpf
            // 
            this.txtNumCpf.Location = new System.Drawing.Point(449, 114);
            this.txtNumCpf.MaxLength = 11;
            this.txtNumCpf.Name = "txtNumCpf";
            this.txtNumCpf.Size = new System.Drawing.Size(371, 26);
            this.txtNumCpf.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(191, 114);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(252, 26);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(6, 50);
            this.txtMatricula.MaxLength = 9;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(170, 26);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(829, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // PesquisaAluno
            // 
            this.PesquisaAluno.Controls.Add(this.dataGridView1);
            this.PesquisaAluno.Controls.Add(this.Pesquisar);
            this.PesquisaAluno.Controls.Add(this.Editar);
            this.PesquisaAluno.Controls.Add(this.Excluir);
            this.PesquisaAluno.Controls.Add(this.txtPesquisar);
            this.PesquisaAluno.Location = new System.Drawing.Point(12, 172);
            this.PesquisaAluno.Name = "PesquisaAluno";
            this.PesquisaAluno.Size = new System.Drawing.Size(1037, 258);
            this.PesquisaAluno.TabIndex = 1;
            this.PesquisaAluno.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 162);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.Location = new System.Drawing.Point(926, 26);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(94, 26);
            this.Pesquisar.TabIndex = 1;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Editar
            // 
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Location = new System.Drawing.Point(813, 226);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(94, 26);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Location = new System.Drawing.Point(926, 226);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(94, 26);
            this.Excluir.TabIndex = 4;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(914, 26);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1061, 440);
            this.Controls.Add(this.PesquisaAluno);
            this.Controls.Add(this.CadastroAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolar Manager - Cadastro de Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAluno_FormClosing);
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.CadastroAluno.ResumeLayout(false);
            this.CadastroAluno.PerformLayout();
            this.PesquisaAluno.ResumeLayout(false);
            this.PesquisaAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CadastroAluno;
        private System.Windows.Forms.GroupBox PesquisaAluno;
        private Controles.txtNumCpf txtNumCpf;
        private Controles.txtData txtData;
        private Controles.txtMatricula txtMatricula;
        private Controles.txt txtNome;
        private Controles.txt txtPesquisar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Limpar;
        private Controles.BoxSexoAluno boxSexo1;
    }
}

