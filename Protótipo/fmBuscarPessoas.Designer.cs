namespace Protótipo
{
    partial class fmBuscarPessoas
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
            this.cbSim = new System.Windows.Forms.CheckBox();
            this.lbMostrar = new System.Windows.Forms.Label();
            this.chbDoar = new System.Windows.Forms.CheckBox();
            this.chbAdotar = new System.Windows.Forms.CheckBox();
            this.btDetalhes = new System.Windows.Forms.Button();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.chbPorte = new System.Windows.Forms.CheckBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInteresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Protótipo.propetDataSetTableAdapters.pessoaTableAdapter();
            this.adocaoibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adocaoTableAdapter = new Protótipo.propetDataSetTableAdapters.adocaoTableAdapter();
            this.propetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.gbCadastroCachorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adocaoibfk1BindingSource)).BeginInit();
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
            this.pnSuperior.Location = new System.Drawing.Point(0, 2);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 10;
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
            this.lbBuscar.Location = new System.Drawing.Point(200, 20);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(54, 17);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar";
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
            this.pbCadastrar.InitialImage = global::Protótipo.Properties.Resources.botao;
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
            this.gbCadastroCachorro.Controls.Add(this.cbSim);
            this.gbCadastroCachorro.Controls.Add(this.lbMostrar);
            this.gbCadastroCachorro.Controls.Add(this.chbDoar);
            this.gbCadastroCachorro.Controls.Add(this.chbAdotar);
            this.gbCadastroCachorro.Controls.Add(this.btDetalhes);
            this.gbCadastroCachorro.Controls.Add(this.cbPorte);
            this.gbCadastroCachorro.Controls.Add(this.chbPorte);
            this.gbCadastroCachorro.Controls.Add(this.lbFiltrar);
            this.gbCadastroCachorro.Controls.Add(this.tbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.lbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.dgvPessoas);
            this.gbCadastroCachorro.Location = new System.Drawing.Point(11, 83);
            this.gbCadastroCachorro.Name = "gbCadastroCachorro";
            this.gbCadastroCachorro.Size = new System.Drawing.Size(645, 500);
            this.gbCadastroCachorro.TabIndex = 11;
            this.gbCadastroCachorro.TabStop = false;
            // 
            // cbSim
            // 
            this.cbSim.AutoSize = true;
            this.cbSim.Location = new System.Drawing.Point(576, 80);
            this.cbSim.Name = "cbSim";
            this.cbSim.Size = new System.Drawing.Size(43, 17);
            this.cbSim.TabIndex = 28;
            this.cbSim.Text = "Sim";
            this.cbSim.UseVisualStyleBackColor = true;
            this.cbSim.CheckedChanged += new System.EventHandler(this.cbSim_CheckedChanged);
            // 
            // lbMostrar
            // 
            this.lbMostrar.AutoSize = true;
            this.lbMostrar.Location = new System.Drawing.Point(293, 81);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(278, 13);
            this.lbMostrar.TabIndex = 27;
            this.lbMostrar.Text = "Mostrar clientes que não desejam mais adotar cachorros?";
            // 
            // chbDoar
            // 
            this.chbDoar.AutoSize = true;
            this.chbDoar.Location = new System.Drawing.Point(385, 44);
            this.chbDoar.Name = "chbDoar";
            this.chbDoar.Size = new System.Drawing.Size(49, 17);
            this.chbDoar.TabIndex = 22;
            this.chbDoar.Text = "Doar";
            this.chbDoar.UseVisualStyleBackColor = true;
            this.chbDoar.CheckedChanged += new System.EventHandler(this.chbDoar_CheckedChanged);
            // 
            // chbAdotar
            // 
            this.chbAdotar.AutoSize = true;
            this.chbAdotar.Location = new System.Drawing.Point(309, 44);
            this.chbAdotar.Name = "chbAdotar";
            this.chbAdotar.Size = new System.Drawing.Size(57, 17);
            this.chbAdotar.TabIndex = 21;
            this.chbAdotar.Text = "Adotar";
            this.chbAdotar.UseVisualStyleBackColor = true;
            this.chbAdotar.CheckedChanged += new System.EventHandler(this.chbAdotar_CheckedChanged);
            // 
            // btDetalhes
            // 
            this.btDetalhes.Location = new System.Drawing.Point(271, 469);
            this.btDetalhes.Name = "btDetalhes";
            this.btDetalhes.Size = new System.Drawing.Size(97, 23);
            this.btDetalhes.TabIndex = 20;
            this.btDetalhes.Text = "Ver Detalhes";
            this.btDetalhes.UseVisualStyleBackColor = true;
            this.btDetalhes.Click += new System.EventHandler(this.btDetalhes_Click);
            // 
            // cbPorte
            // 
            this.cbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorte.Enabled = false;
            this.cbPorte.FormattingEnabled = true;
            this.cbPorte.Items.AddRange(new object[] {
            "Mini",
            "Pequeno",
            "Pequeno/Médio",
            "Médio",
            "Grande",
            "Gigante",
            "Qualquer Porte"});
            this.cbPorte.Location = new System.Drawing.Point(509, 39);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(130, 21);
            this.cbPorte.TabIndex = 17;
            this.cbPorte.SelectedIndexChanged += new System.EventHandler(this.cbPorte_SelectedIndexChanged);
            this.cbPorte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPorte_KeyDown);
            // 
            // chbPorte
            // 
            this.chbPorte.AutoSize = true;
            this.chbPorte.Location = new System.Drawing.Point(452, 43);
            this.chbPorte.Name = "chbPorte";
            this.chbPorte.Size = new System.Drawing.Size(51, 17);
            this.chbPorte.TabIndex = 15;
            this.chbPorte.Text = "Porte";
            this.chbPorte.UseVisualStyleBackColor = true;
            this.chbPorte.CheckedChanged += new System.EventHandler(this.chbPorte_CheckedChanged);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(292, 14);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lbFiltrar.TabIndex = 12;
            this.lbFiltrar.Text = "Filtrar por:";
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(27, 44);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(257, 20);
            this.tbPesquisar.TabIndex = 10;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.PesquisarEscrevendo);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesquisar_KeyPress);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(24, 14);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lbPesquisar.TabIndex = 9;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.AllowUserToResizeColumns = false;
            this.dgvPessoas.AllowUserToResizeRows = false;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.clInteresse,
            this.clBairro,
            this.dataRegistro});
            this.dgvPessoas.DataSource = this.pessoaBindingSource1;
            this.dgvPessoas.Location = new System.Drawing.Point(6, 100);
            this.dgvPessoas.MultiSelect = false;
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(633, 365);
            this.dgvPessoas.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clInteresse
            // 
            this.clInteresse.DataPropertyName = "interesse";
            this.clInteresse.HeaderText = "Interesse";
            this.clInteresse.Name = "clInteresse";
            this.clInteresse.ReadOnly = true;
            // 
            // clBairro
            // 
            this.clBairro.DataPropertyName = "bairro";
            this.clBairro.HeaderText = "Bairro";
            this.clBairro.Name = "clBairro";
            this.clBairro.ReadOnly = true;
            // 
            // dataRegistro
            // 
            this.dataRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataRegistro.DataPropertyName = "dataRegistro";
            this.dataRegistro.HeaderText = "Registrado em";
            this.dataRegistro.Name = "dataRegistro";
            this.dataRegistro.ReadOnly = true;
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataMember = "pessoa";
            this.pessoaBindingSource1.DataSource = this.propetDataSet;
            // 
            // propetDataSet
            // 
            this.propetDataSet.DataSetName = "propetDataSet";
            this.propetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.propetDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // adocaoibfk1BindingSource
            // 
            this.adocaoibfk1BindingSource.DataMember = "adocao_ibfk_1";
            this.adocaoibfk1BindingSource.DataSource = this.pessoaBindingSource;
            // 
            // adocaoTableAdapter
            // 
            this.adocaoTableAdapter.ClearBeforeFill = true;
            // 
            // propetDataSetBindingSource
            // 
            this.propetDataSetBindingSource.DataSource = this.propetDataSet;
            this.propetDataSetBindingSource.Position = 0;
            // 
            // fmBuscarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.gbCadastroCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBuscarPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmBuscarPessoas";
            this.Load += new System.EventHandler(this.fmBuscarPessoas_Load);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.gbCadastroCachorro.ResumeLayout(false);
            this.gbCadastroCachorro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adocaoibfk1BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.CheckBox chbPorte;
        private System.Windows.Forms.Button btDetalhes;
        private System.Windows.Forms.CheckBox chbAdotar;
        private System.Windows.Forms.CheckBox chbDoar;
        private System.Windows.Forms.Label lbMostrar;
        private System.Windows.Forms.CheckBox cbSim;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private propetDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.BindingSource adocaoibfk1BindingSource;
        private propetDataSetTableAdapters.adocaoTableAdapter adocaoTableAdapter;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private System.Windows.Forms.BindingSource propetDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInteresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistro;
    }
}