namespace Protótipo
{
    partial class fmCachorrosDisponiveis
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
            this.gbCachorroAdoacao = new System.Windows.Forms.GroupBox();
            this.lbSelecione = new System.Windows.Forms.Label();
            this.dgvCachorros = new System.Windows.Forms.DataGridView();
            this.nomeCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacinadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cachorroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cachorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachorroTableAdapter = new Protótipo.propetDataSetTableAdapters.cachorroTableAdapter();
            this.gbCachorroAdoacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCachorroAdoacao
            // 
            this.gbCachorroAdoacao.BackColor = System.Drawing.Color.SpringGreen;
            this.gbCachorroAdoacao.Controls.Add(this.lbSelecione);
            this.gbCachorroAdoacao.Controls.Add(this.dgvCachorros);
            this.gbCachorroAdoacao.Controls.Add(this.btConfirmar);
            this.gbCachorroAdoacao.Controls.Add(this.btCancelar);
            this.gbCachorroAdoacao.Location = new System.Drawing.Point(12, 17);
            this.gbCachorroAdoacao.Name = "gbCachorroAdoacao";
            this.gbCachorroAdoacao.Size = new System.Drawing.Size(642, 561);
            this.gbCachorroAdoacao.TabIndex = 1;
            this.gbCachorroAdoacao.TabStop = false;
            this.gbCachorroAdoacao.Text = "Cachorros para Adoção";
            // 
            // lbSelecione
            // 
            this.lbSelecione.AutoSize = true;
            this.lbSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelecione.Location = new System.Drawing.Point(212, 36);
            this.lbSelecione.Name = "lbSelecione";
            this.lbSelecione.Size = new System.Drawing.Size(210, 24);
            this.lbSelecione.TabIndex = 4;
            this.lbSelecione.Text = "Selecione um Cachorro";
            // 
            // dgvCachorros
            // 
            this.dgvCachorros.AllowUserToAddRows = false;
            this.dgvCachorros.AllowUserToDeleteRows = false;
            this.dgvCachorros.AutoGenerateColumns = false;
            this.dgvCachorros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCachorros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCachorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachorros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCaoDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.vacinadoDataGridViewCheckBoxColumn});
            this.dgvCachorros.DataSource = this.cachorroBindingSource1;
            this.dgvCachorros.Location = new System.Drawing.Point(5, 97);
            this.dgvCachorros.Name = "dgvCachorros";
            this.dgvCachorros.ReadOnly = true;
            this.dgvCachorros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCachorros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCachorros.Size = new System.Drawing.Size(633, 389);
            this.dgvCachorros.TabIndex = 3;
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
            // vacinadoDataGridViewCheckBoxColumn
            // 
            this.vacinadoDataGridViewCheckBoxColumn.DataPropertyName = "vacinado";
            this.vacinadoDataGridViewCheckBoxColumn.HeaderText = "Vacinado";
            this.vacinadoDataGridViewCheckBoxColumn.Name = "vacinadoDataGridViewCheckBoxColumn";
            this.vacinadoDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(349, 517);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(93, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(201, 517);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(93, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
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
            // fmCachorrosDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.gbCachorroAdoacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCachorrosDisponiveis";
            this.Text = "fmCachorrosDisponiveis";
            this.Load += new System.EventHandler(this.fmCachorrosDisponiveis_Load);
            this.gbCachorroAdoacao.ResumeLayout(false);
            this.gbCachorroAdoacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCachorroAdoacao;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource cachorroBindingSource;
        private propetDataSetTableAdapters.cachorroTableAdapter cachorroTableAdapter;
        public System.Windows.Forms.DataGridView dgvCachorros;
        private System.Windows.Forms.Label lbSelecione;
        private System.Windows.Forms.BindingSource cachorroBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacinadoDataGridViewCheckBoxColumn;
    }
}