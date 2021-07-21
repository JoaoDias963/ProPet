namespace Protótipo
{
    partial class fmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTelaPrincipal));
            this.niPropet = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbAreaUsuario = new System.Windows.Forms.GroupBox();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.btGerarRelatorios = new System.Windows.Forms.Button();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pnAreaUsuario = new System.Windows.Forms.Panel();
            this.btCachorros = new System.Windows.Forms.Button();
            this.btCaoPanheiros = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.btAdocao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAreaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.pnAreaUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // niPropet
            // 
            this.niPropet.Icon = ((System.Drawing.Icon)(resources.GetObject("niPropet.Icon")));
            this.niPropet.Text = "ProPet";
            this.niPropet.Visible = true;
            // 
            // gbAreaUsuario
            // 
            this.gbAreaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAreaUsuario.Controls.Add(this.pbFechar);
            this.gbAreaUsuario.Controls.Add(this.btGerarRelatorios);
            this.gbAreaUsuario.Controls.Add(this.btAlterarSenha);
            this.gbAreaUsuario.Controls.Add(this.pbMinimizar);
            this.gbAreaUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.gbAreaUsuario.Location = new System.Drawing.Point(3, 7);
            this.gbAreaUsuario.Name = "gbAreaUsuario";
            this.gbAreaUsuario.Size = new System.Drawing.Size(121, 266);
            this.gbAreaUsuario.TabIndex = 1;
            this.gbAreaUsuario.TabStop = false;
            this.gbAreaUsuario.Text = "Área de Usuário";
            // 
            // pbFechar
            // 
            this.pbFechar.Image = global::Protótipo.Properties.Resources.Maximizar;
            this.pbFechar.Location = new System.Drawing.Point(68, 202);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(34, 32);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFechar.TabIndex = 6;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // btGerarRelatorios
            // 
            this.btGerarRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btGerarRelatorios.BackColor = System.Drawing.SystemColors.Desktop;
            this.btGerarRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorios.ForeColor = System.Drawing.SystemColors.Control;
            this.btGerarRelatorios.Location = new System.Drawing.Point(4, 36);
            this.btGerarRelatorios.Name = "btGerarRelatorios";
            this.btGerarRelatorios.Size = new System.Drawing.Size(114, 54);
            this.btGerarRelatorios.TabIndex = 1;
            this.btGerarRelatorios.Text = "Gerar Relatórios";
            this.btGerarRelatorios.UseVisualStyleBackColor = false;
            this.btGerarRelatorios.Click += new System.EventHandler(this.btGerarRelatorios_Click);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAlterarSenha.BackColor = System.Drawing.SystemColors.Desktop;
            this.btAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlterarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.btAlterarSenha.Location = new System.Drawing.Point(4, 113);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(114, 48);
            this.btAlterarSenha.TabIndex = 0;
            this.btAlterarSenha.Text = "Alterar Senha";
            this.btAlterarSenha.UseVisualStyleBackColor = false;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = global::Protótipo.Properties.Resources.Minimizar;
            this.pbMinimizar.Location = new System.Drawing.Point(17, 202);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(34, 32);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 4;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pnAreaUsuario
            // 
            this.pnAreaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnAreaUsuario.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnAreaUsuario.Controls.Add(this.gbAreaUsuario);
            this.pnAreaUsuario.Location = new System.Drawing.Point(2, 321);
            this.pnAreaUsuario.Name = "pnAreaUsuario";
            this.pnAreaUsuario.Size = new System.Drawing.Size(127, 276);
            this.pnAreaUsuario.TabIndex = 0;
            // 
            // btCachorros
            // 
            this.btCachorros.BackColor = System.Drawing.SystemColors.Desktop;
            this.btCachorros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCachorros.ForeColor = System.Drawing.SystemColors.Control;
            this.btCachorros.Location = new System.Drawing.Point(6, 86);
            this.btCachorros.Name = "btCachorros";
            this.btCachorros.Size = new System.Drawing.Size(114, 48);
            this.btCachorros.TabIndex = 2;
            this.btCachorros.Text = "Cachorros";
            this.btCachorros.UseVisualStyleBackColor = false;
            this.btCachorros.Click += new System.EventHandler(this.btCachorros_Click);
            // 
            // btCaoPanheiros
            // 
            this.btCaoPanheiros.BackColor = System.Drawing.SystemColors.Desktop;
            this.btCaoPanheiros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCaoPanheiros.ForeColor = System.Drawing.SystemColors.Control;
            this.btCaoPanheiros.Location = new System.Drawing.Point(6, 144);
            this.btCaoPanheiros.Name = "btCaoPanheiros";
            this.btCaoPanheiros.Size = new System.Drawing.Size(114, 48);
            this.btCaoPanheiros.TabIndex = 3;
            this.btCaoPanheiros.Text = "Cão Panheiros";
            this.btCaoPanheiros.UseVisualStyleBackColor = false;
            this.btCaoPanheiros.Click += new System.EventHandler(this.btCaoPanheiros_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btProdutos.ForeColor = System.Drawing.SystemColors.Control;
            this.btProdutos.Location = new System.Drawing.Point(6, 261);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(114, 48);
            this.btProdutos.TabIndex = 4;
            this.btProdutos.Text = "Produtos";
            this.btProdutos.UseVisualStyleBackColor = false;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // btAdocao
            // 
            this.btAdocao.BackColor = System.Drawing.SystemColors.Desktop;
            this.btAdocao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdocao.ForeColor = System.Drawing.SystemColors.Control;
            this.btAdocao.Location = new System.Drawing.Point(6, 202);
            this.btAdocao.Name = "btAdocao";
            this.btAdocao.Size = new System.Drawing.Size(114, 48);
            this.btAdocao.TabIndex = 5;
            this.btAdocao.Text = "Adoção";
            this.btAdocao.UseVisualStyleBackColor = false;
            this.btAdocao.Click += new System.EventHandler(this.btAdocao_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.btAdocao);
            this.panel1.Controls.Add(this.btProdutos);
            this.panel1.Controls.Add(this.btCaoPanheiros);
            this.panel1.Controls.Add(this.btCachorros);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 320);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAreaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmTelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmTelaPrincipal";
            this.gbAreaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.pnAreaUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niPropet;
        private System.Windows.Forms.GroupBox gbAreaUsuario;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.Button btGerarRelatorios;
        private System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Panel pnAreaUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCachorros;
        private System.Windows.Forms.Button btCaoPanheiros;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btAdocao;
        private System.Windows.Forms.Panel panel1;
    }
}