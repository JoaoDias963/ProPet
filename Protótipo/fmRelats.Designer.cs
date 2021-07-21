namespace Protótipo
{
    partial class fmRelats
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
            this.gbRelatorios = new System.Windows.Forms.GroupBox();
            this.btRtEstoque = new System.Windows.Forms.Button();
            this.btRtAdocao = new System.Windows.Forms.Button();
            this.btRtPessoa = new System.Windows.Forms.Button();
            this.btRtCachorro = new System.Windows.Forms.Button();
            this.gbRelatorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRelatorios
            // 
            this.gbRelatorios.BackColor = System.Drawing.Color.PaleGreen;
            this.gbRelatorios.Controls.Add(this.btRtEstoque);
            this.gbRelatorios.Controls.Add(this.btRtAdocao);
            this.gbRelatorios.Controls.Add(this.btRtPessoa);
            this.gbRelatorios.Controls.Add(this.btRtCachorro);
            this.gbRelatorios.Location = new System.Drawing.Point(12, 12);
            this.gbRelatorios.Name = "gbRelatorios";
            this.gbRelatorios.Size = new System.Drawing.Size(643, 571);
            this.gbRelatorios.TabIndex = 0;
            this.gbRelatorios.TabStop = false;
            // 
            // btRtEstoque
            // 
            this.btRtEstoque.Location = new System.Drawing.Point(205, 323);
            this.btRtEstoque.Name = "btRtEstoque";
            this.btRtEstoque.Size = new System.Drawing.Size(221, 40);
            this.btRtEstoque.TabIndex = 3;
            this.btRtEstoque.Text = "Relatório de Estoque";
            this.btRtEstoque.UseVisualStyleBackColor = true;
            this.btRtEstoque.Click += new System.EventHandler(this.btRtEstoque_Click);
            // 
            // btRtAdocao
            // 
            this.btRtAdocao.Location = new System.Drawing.Point(205, 277);
            this.btRtAdocao.Name = "btRtAdocao";
            this.btRtAdocao.Size = new System.Drawing.Size(221, 40);
            this.btRtAdocao.TabIndex = 2;
            this.btRtAdocao.Text = "Relatório de Adoção";
            this.btRtAdocao.UseVisualStyleBackColor = true;
            this.btRtAdocao.Click += new System.EventHandler(this.btRtAdocao_Click);
            // 
            // btRtPessoa
            // 
            this.btRtPessoa.Location = new System.Drawing.Point(205, 231);
            this.btRtPessoa.Name = "btRtPessoa";
            this.btRtPessoa.Size = new System.Drawing.Size(221, 40);
            this.btRtPessoa.TabIndex = 1;
            this.btRtPessoa.Text = "Relatório de Cão-Panheiro";
            this.btRtPessoa.UseVisualStyleBackColor = true;
            this.btRtPessoa.Click += new System.EventHandler(this.btRtPessoa_Click);
            // 
            // btRtCachorro
            // 
            this.btRtCachorro.Location = new System.Drawing.Point(205, 185);
            this.btRtCachorro.Name = "btRtCachorro";
            this.btRtCachorro.Size = new System.Drawing.Size(221, 40);
            this.btRtCachorro.TabIndex = 0;
            this.btRtCachorro.Text = "Relatório de Cachorro";
            this.btRtCachorro.UseVisualStyleBackColor = true;
            this.btRtCachorro.Click += new System.EventHandler(this.btRtCachorro_Click);
            // 
            // fmRelats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.gbRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmRelats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmRelats";
            this.gbRelatorios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRelatorios;
        private System.Windows.Forms.Button btRtEstoque;
        private System.Windows.Forms.Button btRtAdocao;
        private System.Windows.Forms.Button btRtPessoa;
        private System.Windows.Forms.Button btRtCachorro;
    }
}