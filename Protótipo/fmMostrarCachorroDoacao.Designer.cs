namespace Protótipo
{
    partial class fmMostrarCachorroDoacao
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
            this.gbCachorroDoacao = new System.Windows.Forms.GroupBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btDetalhes = new System.Windows.Forms.Button();
            this.dgvCachorroDoacao = new System.Windows.Forms.DataGridView();
            this.cachorrodoacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propetDataSet = new Protótipo.propetDataSet();
            this.cachorrodoacaoTableAdapter = new Protótipo.propetDataSetTableAdapters.cachorrodoacaoTableAdapter();
            this.gbCachorroDoacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorroDoacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorrodoacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCachorroDoacao
            // 
            this.gbCachorroDoacao.BackColor = System.Drawing.Color.SpringGreen;
            this.gbCachorroDoacao.Controls.Add(this.btFechar);
            this.gbCachorroDoacao.Controls.Add(this.btDetalhes);
            this.gbCachorroDoacao.Controls.Add(this.dgvCachorroDoacao);
            this.gbCachorroDoacao.Location = new System.Drawing.Point(13, 13);
            this.gbCachorroDoacao.Name = "gbCachorroDoacao";
            this.gbCachorroDoacao.Size = new System.Drawing.Size(642, 561);
            this.gbCachorroDoacao.TabIndex = 0;
            this.gbCachorroDoacao.TabStop = false;
            this.gbCachorroDoacao.Text = "Cachorros Doação";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(349, 517);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(93, 23);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btDetalhes
            // 
            this.btDetalhes.Location = new System.Drawing.Point(201, 517);
            this.btDetalhes.Name = "btDetalhes";
            this.btDetalhes.Size = new System.Drawing.Size(93, 23);
            this.btDetalhes.TabIndex = 1;
            this.btDetalhes.Text = "Ver Detalhes";
            this.btDetalhes.UseVisualStyleBackColor = true;
            this.btDetalhes.Click += new System.EventHandler(this.btDetalhes_Click);
            // 
            // dgvCachorroDoacao
            // 
            this.dgvCachorroDoacao.AllowUserToAddRows = false;
            this.dgvCachorroDoacao.AllowUserToDeleteRows = false;
            this.dgvCachorroDoacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCachorroDoacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachorroDoacao.Location = new System.Drawing.Point(18, 39);
            this.dgvCachorroDoacao.Name = "dgvCachorroDoacao";
            this.dgvCachorroDoacao.ReadOnly = true;
            this.dgvCachorroDoacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCachorroDoacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCachorroDoacao.Size = new System.Drawing.Size(607, 458);
            this.dgvCachorroDoacao.TabIndex = 0;
            // 
            // cachorrodoacaoBindingSource
            // 
            this.cachorrodoacaoBindingSource.DataMember = "cachorrodoacao";
            this.cachorrodoacaoBindingSource.DataSource = this.propetDataSet;
            // 
            // propetDataSet
            // 
            this.propetDataSet.DataSetName = "propetDataSet";
            this.propetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cachorrodoacaoTableAdapter
            // 
            this.cachorrodoacaoTableAdapter.ClearBeforeFill = true;
            // 
            // fmMostrarCachorroDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.gbCachorroDoacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMostrarCachorroDoacao";
            this.Text = "fmMostrarCachorroDoacao";
            this.Load += new System.EventHandler(this.fmMostrarCachorroDoacao_Load);
            this.gbCachorroDoacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorroDoacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachorrodoacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCachorroDoacao;
        private System.Windows.Forms.DataGridView dgvCachorroDoacao;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btDetalhes;
        private propetDataSet propetDataSet;
        private System.Windows.Forms.BindingSource cachorrodoacaoBindingSource;
        private propetDataSetTableAdapters.cachorrodoacaoTableAdapter cachorrodoacaoTableAdapter;
    }
}