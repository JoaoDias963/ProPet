namespace Protótipo
{
    partial class fmCaoDispPPessoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSelecionaCao = new System.Windows.Forms.Button();
            this.dvgCachorros = new System.Windows.Forms.DataGridView();
            this.vacinadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falecidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cachorroTableAdapter = new Protótipo.propetDataSetTableAdapters.cachorroTableAdapter();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCachorros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSelecionaCao);
            this.groupBox1.Controls.Add(this.dvgCachorros);
            this.groupBox1.Controls.Add(this.lbTitulo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 570);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btSelecionaCao
            // 
            this.btSelecionaCao.Location = new System.Drawing.Point(329, 541);
            this.btSelecionaCao.Name = "btSelecionaCao";
            this.btSelecionaCao.Size = new System.Drawing.Size(165, 23);
            this.btSelecionaCao.TabIndex = 2;
            this.btSelecionaCao.Text = "Selecionar Cachorro";
            this.btSelecionaCao.UseVisualStyleBackColor = true;
            this.btSelecionaCao.Click += new System.EventHandler(this.btSelecionaCao_Click);
            // 
            // dvgCachorros
            // 
            this.dvgCachorros.AllowUserToAddRows = false;
            this.dvgCachorros.AllowUserToDeleteRows = false;
            this.dvgCachorros.AutoGenerateColumns = false;
            this.dvgCachorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCachorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCachorros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacinadoDataGridViewCheckBoxColumn,
            this.nomeCaoDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.porteDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.idCaoDataGridViewTextBoxColumn,
            this.dataRegistroDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.falecidoDataGridViewCheckBoxColumn,
            this.idadeDataGridViewTextBoxColumn});
            this.dvgCachorros.DataSource = this.cachorroBindingSource;
            this.dvgCachorros.Location = new System.Drawing.Point(9, 33);
            this.dvgCachorros.MultiSelect = false;
            this.dvgCachorros.Name = "dvgCachorros";
            this.dvgCachorros.ReadOnly = true;
            this.dvgCachorros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgCachorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCachorros.Size = new System.Drawing.Size(627, 502);
            this.dvgCachorros.TabIndex = 1;
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
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // porteDataGridViewTextBoxColumn
            // 
            this.porteDataGridViewTextBoxColumn.DataPropertyName = "porte";
            this.porteDataGridViewTextBoxColumn.HeaderText = "porte";
            this.porteDataGridViewTextBoxColumn.Name = "porteDataGridViewTextBoxColumn";
            this.porteDataGridViewTextBoxColumn.ReadOnly = true;
            this.porteDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCaoDataGridViewTextBoxColumn
            // 
            this.idCaoDataGridViewTextBoxColumn.DataPropertyName = "idCao";
            this.idCaoDataGridViewTextBoxColumn.HeaderText = "idCao";
            this.idCaoDataGridViewTextBoxColumn.Name = "idCaoDataGridViewTextBoxColumn";
            this.idCaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataRegistroDataGridViewTextBoxColumn
            // 
            this.dataRegistroDataGridViewTextBoxColumn.DataPropertyName = "dataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.HeaderText = "dataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.Name = "dataRegistroDataGridViewTextBoxColumn";
            this.dataRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.Visible = false;
            // 
            // falecidoDataGridViewCheckBoxColumn
            // 
            this.falecidoDataGridViewCheckBoxColumn.DataPropertyName = "falecido";
            this.falecidoDataGridViewCheckBoxColumn.HeaderText = "falecido";
            this.falecidoDataGridViewCheckBoxColumn.Name = "falecidoDataGridViewCheckBoxColumn";
            this.falecidoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.falecidoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cachorroBindingSource
            // 
            this.cachorroBindingSource.DataMember = "cachorro";
            this.cachorroBindingSource.DataSource = this.propetDataSet;
            // 
            // propetDataSet
            // 
            this.propetDataSet.DataSetName = "propetDataSet";
            this.propetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(6, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(175, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cachorros diponiveis para a pessoa";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cachorroTableAdapter
            // 
            this.cachorroTableAdapter.ClearBeforeFill = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(158, 541);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(165, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // fmCaoDispPPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCaoDispPPessoa";
            this.Text = "fmCaoDispPPessoa";
            this.Load += new System.EventHandler(this.fmCaoDispPPessoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCachorros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btSelecionaCao;
        private System.Windows.Forms.DataGridView dvgCachorros;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource cachorroBindingSource;
        private propetDataSetTableAdapters.cachorroTableAdapter cachorroTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacinadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn falecidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btCancelar;
    }
}