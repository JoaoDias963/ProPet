namespace Protótipo
{
    partial class fmBuscarCachorro
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbProPeT = new System.Windows.Forms.Label();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbCadastrar = new System.Windows.Forms.Label();
            this.pbCadastrar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.gbCadastroCachorro = new System.Windows.Forms.GroupBox();
            this.chbSimFalecidos = new System.Windows.Forms.CheckBox();
            this.lbFalecidos = new System.Windows.Forms.Label();
            this.btDetalhes = new System.Windows.Forms.Button();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.chbMacho = new System.Windows.Forms.CheckBox();
            this.chbFemea = new System.Windows.Forms.CheckBox();
            this.chbPorte = new System.Windows.Forms.CheckBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.dgvCachorros = new System.Windows.Forms.DataGridView();
            this.falecidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vacinadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachorroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.cachorroTableAdapter = new Protótipo.propetDataSetTableAdapters.cachorroTableAdapter();
            this.cachorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.gbCadastroCachorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnSuperior.TabIndex = 8;
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
            // gbCadastroCachorro
            // 
            this.gbCadastroCachorro.BackColor = System.Drawing.Color.PaleGreen;
            this.gbCadastroCachorro.Controls.Add(this.chbSimFalecidos);
            this.gbCadastroCachorro.Controls.Add(this.lbFalecidos);
            this.gbCadastroCachorro.Controls.Add(this.btDetalhes);
            this.gbCadastroCachorro.Controls.Add(this.cbPorte);
            this.gbCadastroCachorro.Controls.Add(this.chbMacho);
            this.gbCadastroCachorro.Controls.Add(this.chbFemea);
            this.gbCadastroCachorro.Controls.Add(this.chbPorte);
            this.gbCadastroCachorro.Controls.Add(this.lbFiltrar);
            this.gbCadastroCachorro.Controls.Add(this.tbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.lbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.dgvCachorros);
            this.gbCadastroCachorro.Location = new System.Drawing.Point(11, 83);
            this.gbCadastroCachorro.Name = "gbCadastroCachorro";
            this.gbCadastroCachorro.Size = new System.Drawing.Size(645, 500);
            this.gbCadastroCachorro.TabIndex = 9;
            this.gbCadastroCachorro.TabStop = false;
            // 
            // chbSimFalecidos
            // 
            this.chbSimFalecidos.AutoSize = true;
            this.chbSimFalecidos.Location = new System.Drawing.Point(578, 77);
            this.chbSimFalecidos.Name = "chbSimFalecidos";
            this.chbSimFalecidos.Size = new System.Drawing.Size(43, 17);
            this.chbSimFalecidos.TabIndex = 14;
            this.chbSimFalecidos.Text = "Sim";
            this.chbSimFalecidos.UseVisualStyleBackColor = true;
            this.chbSimFalecidos.CheckedChanged += new System.EventHandler(this.chbSimFalecidos_CheckedChanged);
            // 
            // lbFalecidos
            // 
            this.lbFalecidos.AutoSize = true;
            this.lbFalecidos.Location = new System.Drawing.Point(427, 80);
            this.lbFalecidos.Name = "lbFalecidos";
            this.lbFalecidos.Size = new System.Drawing.Size(144, 13);
            this.lbFalecidos.TabIndex = 10;
            this.lbFalecidos.Text = "Mostrar Cachorros falecidos?";
            // 
            // btDetalhes
            // 
            this.btDetalhes.Location = new System.Drawing.Point(271, 470);
            this.btDetalhes.Name = "btDetalhes";
            this.btDetalhes.Size = new System.Drawing.Size(97, 23);
            this.btDetalhes.TabIndex = 13;
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
            "Gigante"});
            this.cbPorte.Location = new System.Drawing.Point(522, 49);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(117, 21);
            this.cbPorte.TabIndex = 12;
            this.cbPorte.SelectedIndexChanged += new System.EventHandler(this.cbPorteSelecionado);
            this.cbPorte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPorte_KeyDown);
            // 
            // chbMacho
            // 
            this.chbMacho.AutoSize = true;
            this.chbMacho.Location = new System.Drawing.Point(385, 51);
            this.chbMacho.Name = "chbMacho";
            this.chbMacho.Size = new System.Drawing.Size(59, 17);
            this.chbMacho.TabIndex = 10;
            this.chbMacho.Text = "Macho";
            this.chbMacho.UseVisualStyleBackColor = true;
            this.chbMacho.CheckedChanged += new System.EventHandler(this.chbMacho_CheckedChanged);
            // 
            // chbFemea
            // 
            this.chbFemea.AutoSize = true;
            this.chbFemea.Location = new System.Drawing.Point(310, 51);
            this.chbFemea.Name = "chbFemea";
            this.chbFemea.Size = new System.Drawing.Size(58, 17);
            this.chbFemea.TabIndex = 9;
            this.chbFemea.Text = "Fêmea";
            this.chbFemea.UseVisualStyleBackColor = true;
            this.chbFemea.CheckedChanged += new System.EventHandler(this.chbFemea_CheckedChanged);
            // 
            // chbPorte
            // 
            this.chbPorte.AutoSize = true;
            this.chbPorte.Location = new System.Drawing.Point(466, 51);
            this.chbPorte.Name = "chbPorte";
            this.chbPorte.Size = new System.Drawing.Size(51, 17);
            this.chbPorte.TabIndex = 7;
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
            this.lbFiltrar.TabIndex = 3;
            this.lbFiltrar.Text = "Filtrar por:";
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(27, 52);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(257, 20);
            this.tbPesquisar.TabIndex = 2;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisarEscrevendo);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesquisar_KeyPress);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(25, 30);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(264, 13);
            this.lbPesquisar.TabIndex = 1;
            this.lbPesquisar.Text = "Pesquisar ( Digite Nome, Raça ou Bairro do Cachorro):";
            // 
            // dgvCachorros
            // 
            this.dgvCachorros.AllowUserToAddRows = false;
            this.dgvCachorros.AllowUserToDeleteRows = false;
            this.dgvCachorros.AllowUserToResizeColumns = false;
            this.dgvCachorros.AllowUserToResizeRows = false;
            this.dgvCachorros.AutoGenerateColumns = false;
            this.dgvCachorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCachorros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCachorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachorros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.falecidoDataGridViewCheckBoxColumn,
            this.vacinadoDataGridViewCheckBoxColumn,
            this.nomeCaoDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.porteDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dataRegistroDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn});
            this.dgvCachorros.DataSource = this.cachorroBindingSource1;
            this.dgvCachorros.Location = new System.Drawing.Point(6, 100);
            this.dgvCachorros.MultiSelect = false;
            this.dgvCachorros.Name = "dgvCachorros";
            this.dgvCachorros.ReadOnly = true;
            this.dgvCachorros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCachorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCachorros.Size = new System.Drawing.Size(633, 366);
            this.dgvCachorros.TabIndex = 0;
            // 
            // falecidoDataGridViewCheckBoxColumn
            // 
            this.falecidoDataGridViewCheckBoxColumn.DataPropertyName = "falecido";
            this.falecidoDataGridViewCheckBoxColumn.HeaderText = "Falecido";
            this.falecidoDataGridViewCheckBoxColumn.Name = "falecidoDataGridViewCheckBoxColumn";
            this.falecidoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.falecidoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // vacinadoDataGridViewCheckBoxColumn
            // 
            this.vacinadoDataGridViewCheckBoxColumn.DataPropertyName = "vacinado";
            this.vacinadoDataGridViewCheckBoxColumn.HeaderText = "Vacinado";
            this.vacinadoDataGridViewCheckBoxColumn.Name = "vacinadoDataGridViewCheckBoxColumn";
            this.vacinadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nomeCaoDataGridViewTextBoxColumn
            // 
            this.nomeCaoDataGridViewTextBoxColumn.DataPropertyName = "nomeCao";
            this.nomeCaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCaoDataGridViewTextBoxColumn.Name = "nomeCaoDataGridViewTextBoxColumn";
            this.nomeCaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racaDataGridViewTextBoxColumn
            // 
            this.racaDataGridViewTextBoxColumn.DataPropertyName = "raca";
            this.racaDataGridViewTextBoxColumn.HeaderText = "Raça";
            this.racaDataGridViewTextBoxColumn.Name = "racaDataGridViewTextBoxColumn";
            this.racaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 56;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // porteDataGridViewTextBoxColumn
            // 
            this.porteDataGridViewTextBoxColumn.DataPropertyName = "porte";
            this.porteDataGridViewTextBoxColumn.HeaderText = "Porte";
            this.porteDataGridViewTextBoxColumn.Name = "porteDataGridViewTextBoxColumn";
            this.porteDataGridViewTextBoxColumn.ReadOnly = true;
            this.porteDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataRegistroDataGridViewTextBoxColumn
            // 
            this.dataRegistroDataGridViewTextBoxColumn.DataPropertyName = "dataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.HeaderText = "Data do Registro";
            this.dataRegistroDataGridViewTextBoxColumn.Name = "dataRegistroDataGridViewTextBoxColumn";
            this.dataRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cachorroBindingSource1
            // 
            this.cachorroBindingSource1.DataMember = "cachorro";
            this.cachorroBindingSource1.DataSource = this.propetDataSet;
            // 
            // propetDataSet
            // 
            this.propetDataSet.DataSetName = "propetDataSet";
            this.propetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cachorroTableAdapter
            // 
            this.cachorroTableAdapter.ClearBeforeFill = true;
            // 
            // cachorroBindingSource
            // 
            this.cachorroBindingSource.DataSource = typeof(Protótipo.Cachorro);
            // 
            // fmBuscarCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.gbCadastroCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBuscarCachorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmBuscarCachorro";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.gbCadastroCachorro.ResumeLayout(false);
            this.gbCadastroCachorro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbProPeT;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbCadastrar;
        private System.Windows.Forms.PictureBox pbCadastrar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.GroupBox gbCadastroCachorro;
        private System.Windows.Forms.CheckBox chbPorte;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.CheckBox chbMacho;
        private System.Windows.Forms.CheckBox chbFemea;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.Button btDetalhes;
        private System.Windows.Forms.BindingSource cachorroBindingSource;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource cachorroBindingSource1;
        private propetDataSetTableAdapters.cachorroTableAdapter cachorroTableAdapter;
        public System.Windows.Forms.DataGridView dgvCachorros;
        private System.Windows.Forms.CheckBox chbSimFalecidos;
        private System.Windows.Forms.Label lbFalecidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn falecidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacinadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
    }
}