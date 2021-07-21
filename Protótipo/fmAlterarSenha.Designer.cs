namespace Protótipo
{
    partial class fmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAlterarSenha));
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbConfirmaSenha = new System.Windows.Forms.TextBox();
            this.tbSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Location = new System.Drawing.Point(47, 215);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.PasswordChar = '*';
            this.tbNovaSenha.Size = new System.Drawing.Size(129, 20);
            this.tbNovaSenha.TabIndex = 2;
            this.tbNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNovaSenha_KeyDown);
            this.tbNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNovaSenha_KeyPress);
            // 
            // btCancelar
            // 
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(69, 345);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 23);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrar.Location = new System.Drawing.Point(69, 316);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(88, 23);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Alterar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 274);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbConfirmaSenha
            // 
            this.tbConfirmaSenha.AcceptsTab = true;
            this.tbConfirmaSenha.Location = new System.Drawing.Point(46, 271);
            this.tbConfirmaSenha.Name = "tbConfirmaSenha";
            this.tbConfirmaSenha.PasswordChar = '*';
            this.tbConfirmaSenha.Size = new System.Drawing.Size(130, 20);
            this.tbConfirmaSenha.TabIndex = 3;
            this.tbConfirmaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConfirmaSenha_KeyDown);
            this.tbConfirmaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConfirmaSenha_KeyPress);
            // 
            // tbSenhaAntiga
            // 
            this.tbSenhaAntiga.AcceptsTab = true;
            this.tbSenhaAntiga.Location = new System.Drawing.Point(46, 163);
            this.tbSenhaAntiga.Name = "tbSenhaAntiga";
            this.tbSenhaAntiga.PasswordChar = '*';
            this.tbSenhaAntiga.Size = new System.Drawing.Size(130, 20);
            this.tbSenhaAntiga.TabIndex = 1;
            this.tbSenhaAntiga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSenhaAntiga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenhaAntiga_KeyDown);
            this.tbSenhaAntiga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenhaAntiga_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite a senha atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(64, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Digite a nova senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Redigite a nova senha";
            // 
            // fmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(221, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenhaAntiga);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbConfirmaSenha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmAlterarSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbConfirmaSenha;
        private System.Windows.Forms.TextBox tbSenhaAntiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}