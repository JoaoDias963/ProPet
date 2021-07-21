namespace Protótipo
{
    partial class fmBuscarAdocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbProPeT = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbCadastrar = new System.Windows.Forms.Label();
            this.pbCadastrar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCadastroCachorro = new System.Windows.Forms.GroupBox();
            this.dgvAdocoes = new System.Windows.Forms.DataGridView();
            this.clNomePessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCachorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.adocaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.adocaoTableAdapter = new Protótipo.propetDataSetTableAdapters.adocaoTableAdapter();
            this.cachorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachorroTableAdapter = new Protótipo.propetDataSetTableAdapters.cachorroTableAdapter();
            this.propetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.gbCadastroCachorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdocoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adocaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnSuperior.Controls.Add(this.lbProPeT);
            this.pnSuperior.Controls.Add(this.lbHora);
            this.pnSuperior.Controls.Add(this.pictureBox2);
            this.pnSuperior.Controls.Add(this.lbBuscar);
            this.pnSuperior.Controls.Add(this.lbCadastrar);
            this.pnSuperior.Controls.Add(this.pbCadastrar);
            this.pnSuperior.Controls.Add(this.pbBuscar);
            this.pnSuperior.Location = new System.Drawing.Point(0, 3);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 12;
            // 
            // lbProPeT
            // 
            this.lbProPeT.AutoSize = true;
            this.lbProPeT.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProPeT.Location = new System.Drawing.Point(598, 8);
            this.lbProPeT.Name = "lbProPeT";
            this.lbProPeT.Size = new System.Drawing.Size(58, 17);
            this.lbProPeT.TabIndex = 7;
            this.lbProPeT.Text = "ProPeT";
            this.lbProPeT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(598, 34);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(0, 17);
            this.lbHora.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Protótipo.Properties.Resources.SepMenu;
            this.pictureBox2.InitialImage = global::Protótipo.Properties.Resources.SepMenu;
            this.pictureBox2.Location = new System.Drawing.Point(144, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 59);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.lbBuscar.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(167, 19);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(114, 17);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Listar Adoções";
            this.lbBuscar.MouseLeave += new System.EventHandler(this.pbBuscar_MouseLeave);
            this.lbBuscar.MouseHover += new System.EventHandler(this.pbBuscar_MouseHover);
            // 
            // lbCadastrar
            // 
            this.lbCadastrar.AutoSize = true;
            this.lbCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.lbCadastrar.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCadastrar.Location = new System.Drawing.Point(35, 19);
            this.lbCadastrar.Name = "lbCadastrar";
            this.lbCadastrar.Size = new System.Drawing.Size(77, 17);
            this.lbCadastrar.TabIndex = 1;
            this.lbCadastrar.Text = "Cadastrar";
            this.lbCadastrar.Click += new System.EventHandler(this.pbCadastrar_Click);
            this.lbCadastrar.MouseLeave += new System.EventHandler(this.pbCadastrar_MouseLeave);
            this.lbCadastrar.MouseHover += new System.EventHandler(this.pbCadastrar_MouseHover);
            // 
            // pbCadastrar
            // 
            this.pbCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbCadastrar.Image = global::Protótipo.Properties.Resources.botaoNormal;
            this.pbCadastrar.InitialImage = null;
            this.pbCadastrar.Location = new System.Drawing.Point(2, 3);
            this.pbCadastrar.Name = "pbCadastrar";
            this.pbCadastrar.Size = new System.Drawing.Size(140, 60);
            this.pbCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCadastrar.TabIndex = 0;
            this.pbCadastrar.TabStop = false;
            this.pbCadastrar.Click += new System.EventHandler(this.pbCadastrar_Click);
            this.pbCadastrar.MouseLeave += new System.EventHandler(this.pbCadastrar_MouseLeave);
            this.pbCadastrar.MouseHover += new System.EventHandler(this.pbCadastrar_MouseHover);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Protótipo.Properties.Resources.botao;
            this.pbBuscar.Location = new System.Drawing.Point(155, 3);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(140, 60);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 3;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.MouseLeave += new System.EventHandler(this.pbBuscar_MouseLeave);
            this.pbBuscar.MouseHover += new System.EventHandler(this.pbBuscar_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCadastroCachorro
            // 
            this.gbCadastroCachorro.BackColor = System.Drawing.Color.PaleGreen;
            this.gbCadastroCachorro.Controls.Add(this.dgvAdocoes);
            this.gbCadastroCachorro.Controls.Add(this.tbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.lbPesquisar);
            this.gbCadastroCachorro.Location = new System.Drawing.Point(11, 83);
            this.gbCadastroCachorro.Name = "gbCadastroCachorro";
            this.gbCadastroCachorro.Size = new System.Drawing.Size(645, 500);
            this.gbCadastroCachorro.TabIndex = 13;
            this.gbCadastroCachorro.TabStop = false;
            // 
            // dgvAdocoes
            // 
            this.dgvAdocoes.AllowUserToAddRows = false;
            this.dgvAdocoes.AllowUserToDeleteRows = false;
            this.dgvAdocoes.AllowUserToResizeColumns = false;
            this.dgvAdocoes.AllowUserToResizeRows = false;
            this.dgvAdocoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdocoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdocoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNomePessoa,
            this.clCpf,
            this.clCachorro,
            this.clRaca,
            this.clSexo,
            this.clData});
            this.dgvAdocoes.Location = new System.Drawing.Point(6, 100);
            this.dgvAdocoes.MultiSelect = false;
            this.dgvAdocoes.Name = "dgvAdocoes";
            this.dgvAdocoes.ReadOnly = true;
            this.dgvAdocoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdocoes.Size = new System.Drawing.Size(633, 394);
            this.dgvAdocoes.TabIndex = 31;
            // 
            // clNomePessoa
            // 
            this.clNomePessoa.HeaderText = "Nome";
            this.clNomePessoa.Name = "clNomePessoa";
            this.clNomePessoa.ReadOnly = true;
            // 
            // clCpf
            // 
            this.clCpf.HeaderText = "CPF";
            this.clCpf.Name = "clCpf";
            this.clCpf.ReadOnly = true;
            // 
            // clCachorro
            // 
            this.clCachorro.HeaderText = "Cachorro";
            this.clCachorro.Name = "clCachorro";
            this.clCachorro.ReadOnly = true;
            // 
            // clRaca
            // 
            this.clRaca.HeaderText = "Raça";
            this.clRaca.Name = "clRaca";
            this.clRaca.ReadOnly = true;
            // 
            // clSexo
            // 
            this.clSexo.HeaderText = "Sexo do Cachorro";
            this.clSexo.Name = "clSexo";
            this.clSexo.ReadOnly = true;
            // 
            // clData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clData.DefaultCellStyle = dataGridViewCellStyle1;
            this.clData.HeaderText = "Data da Adoção";
            this.clData.Name = "clData";
            this.clData.ReadOnly = true;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(27, 52);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(269, 20);
            this.tbPesquisar.TabIndex = 29;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesquisar_KeyPress);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(25, 30);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(253, 13);
            this.lbPesquisar.TabIndex = 28;
            this.lbPesquisar.Text = "Pesquisar (Nome da Pessoa ou Nome do Cachorro):";
            // 
            // adocaoBindingSource
            // 
            this.adocaoBindingSource.DataMember = "adocao";
            this.adocaoBindingSource.DataSource = this.propetDataSet;
            // 
            // propetDataSet
            // 
            this.propetDataSet.DataSetName = "propetDataSet";
            this.propetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adocaoTableAdapter
            // 
            this.adocaoTableAdapter.ClearBeforeFill = true;
            // 
            // cachorroBindingSource
            // 
            this.cachorroBindingSource.DataMember = "cachorro";
            this.cachorroBindingSource.DataSource = this.propetDataSet;
            // 
            // cachorroTableAdapter
            // 
            this.cachorroTableAdapter.ClearBeforeFill = true;
            // 
            // propetDataSetBindingSource
            // 
            this.propetDataSetBindingSource.DataSource = this.propetDataSet;
            this.propetDataSetBindingSource.Position = 0;
            // 
            // fmBuscarAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.gbCadastroCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBuscarAdocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmBuscarAdocao";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.gbCadastroCachorro.ResumeLayout(false);
            this.gbCadastroCachorro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdocoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adocaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbProPeT;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbCadastrar;
        private System.Windows.Forms.PictureBox pbCadastrar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbCadastroCachorro;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.DataGridView dgvAdocoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfPessoaDataGridViewTextBoxColumn;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource adocaoBindingSource;
        private propetDataSetTableAdapters.adocaoTableAdapter adocaoTableAdapter;
        private System.Windows.Forms.BindingSource cachorroBindingSource;
        private propetDataSetTableAdapters.cachorroTableAdapter cachorroTableAdapter;
        private System.Windows.Forms.BindingSource propetDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomePessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCachorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
    }
}