namespace Protótipo
{
    partial class fmBoasVindas
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.lbTotalCachorros = new System.Windows.Forms.Label();
            this.lbTotalAdocao = new System.Windows.Forms.Label();
            this.dgvPrevisao = new System.Windows.Forms.DataGridView();
            this.cProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrevisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnSuperior.Controls.Add(this.lbBemVindo);
            this.pnSuperior.Location = new System.Drawing.Point(-1, -1);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 5;
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBemVindo.Location = new System.Drawing.Point(249, 10);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(168, 36);
            this.lbBemVindo.TabIndex = 0;
            this.lbBemVindo.Text = "Bem vindo!";
            this.lbBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalCachorros
            // 
            this.lbTotalCachorros.AutoSize = true;
            this.lbTotalCachorros.Location = new System.Drawing.Point(12, 65);
            this.lbTotalCachorros.Name = "lbTotalCachorros";
            this.lbTotalCachorros.Size = new System.Drawing.Size(82, 13);
            this.lbTotalCachorros.TabIndex = 6;
            this.lbTotalCachorros.Text = "Total Cachorros";
            // 
            // lbTotalAdocao
            // 
            this.lbTotalAdocao.AutoSize = true;
            this.lbTotalAdocao.Location = new System.Drawing.Point(12, 78);
            this.lbTotalAdocao.Name = "lbTotalAdocao";
            this.lbTotalAdocao.Size = new System.Drawing.Size(71, 13);
            this.lbTotalAdocao.TabIndex = 7;
            this.lbTotalAdocao.Text = "Total Adoção";
            // 
            // dgvPrevisao
            // 
            this.dgvPrevisao.AllowUserToAddRows = false;
            this.dgvPrevisao.AllowUserToDeleteRows = false;
            this.dgvPrevisao.AllowUserToResizeColumns = false;
            this.dgvPrevisao.AllowUserToResizeRows = false;
            this.dgvPrevisao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrevisao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevisao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProduto,
            this.clCategoria,
            this.cQuantidade,
            this.cPrevisao});
            this.dgvPrevisao.Location = new System.Drawing.Point(15, 144);
            this.dgvPrevisao.Name = "dgvPrevisao";
            this.dgvPrevisao.ReadOnly = true;
            this.dgvPrevisao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrevisao.Size = new System.Drawing.Size(624, 439);
            this.dgvPrevisao.TabIndex = 8;
            // 
            // cProduto
            // 
            this.cProduto.HeaderText = "Produto";
            this.cProduto.Name = "cProduto";
            this.cProduto.ReadOnly = true;
            // 
            // clCategoria
            // 
            this.clCategoria.HeaderText = "Categoria";
            this.clCategoria.Name = "clCategoria";
            this.clCategoria.ReadOnly = true;
            // 
            // cQuantidade
            // 
            this.cQuantidade.HeaderText = "Quantidade";
            this.cQuantidade.Name = "cQuantidade";
            this.cQuantidade.ReadOnly = true;
            // 
            // cPrevisao
            // 
            this.cPrevisao.HeaderText = "Previsao";
            this.cPrevisao.Name = "cPrevisao";
            this.cPrevisao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Previsão do Estoque";
            // 
            // fmBoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrevisao);
            this.Controls.Add(this.lbTotalAdocao);
            this.Controls.Add(this.lbTotalCachorros);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBoasVindas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmBoasVindas";
            this.Load += new System.EventHandler(this.fmBoasVindas_Load);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbBemVindo;
        private System.Windows.Forms.Label lbTotalCachorros;
        private System.Windows.Forms.Label lbTotalAdocao;
        private System.Windows.Forms.DataGridView dgvPrevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrevisao;
    }
}