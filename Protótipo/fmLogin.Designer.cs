namespace Protótipo
{
    partial class fmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.llCadastrarUsuario = new System.Windows.Forms.LinkLabel();
            this.btEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbProPet = new System.Windows.Forms.Label();
            this.llEsqueciSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.AcceptsTab = true;
            this.tbLogin.Location = new System.Drawing.Point(48, 148);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(139, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_TextChanged);
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsTab = true;
            this.tbPassword.Location = new System.Drawing.Point(205, 148);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(130, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.White;
            this.lbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbUsuario.Location = new System.Drawing.Point(56, 151);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Usuário";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsuario.Click += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.White;
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSenha.Location = new System.Drawing.Point(218, 151);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha";
            this.lbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSenha.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.lbSenha.Click += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // llCadastrarUsuario
            // 
            this.llCadastrarUsuario.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.llCadastrarUsuario.AutoSize = true;
            this.llCadastrarUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.llCadastrarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.llCadastrarUsuario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.llCadastrarUsuario.Location = new System.Drawing.Point(96, 181);
            this.llCadastrarUsuario.Name = "llCadastrarUsuario";
            this.llCadastrarUsuario.Size = new System.Drawing.Size(91, 13);
            this.llCadastrarUsuario.TabIndex = 5;
            this.llCadastrarUsuario.TabStop = true;
            this.llCadastrarUsuario.Text = "Cadastrar Usuário";
            this.llCadastrarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCadastrarUsuario_LinkClicked);
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(351, 147);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(88, 23);
            this.btEntrar.TabIndex = 3;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(32, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(351, 176);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Sair";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbProPet
            // 
            this.lbProPet.AutoSize = true;
            this.lbProPet.Font = new System.Drawing.Font("Kristen ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProPet.Location = new System.Drawing.Point(246, 55);
            this.lbProPet.Name = "lbProPet";
            this.lbProPet.Size = new System.Drawing.Size(179, 54);
            this.lbProPet.TabIndex = 12;
            this.lbProPet.Text = "ProPeT";
            // 
            // llEsqueciSenha
            // 
            this.llEsqueciSenha.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.llEsqueciSenha.AutoSize = true;
            this.llEsqueciSenha.BackColor = System.Drawing.Color.DarkSlateGray;
            this.llEsqueciSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.llEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.llEsqueciSenha.Location = new System.Drawing.Point(244, 181);
            this.llEsqueciSenha.Name = "llEsqueciSenha";
            this.llEsqueciSenha.Size = new System.Drawing.Size(88, 13);
            this.llEsqueciSenha.TabIndex = 6;
            this.llEsqueciSenha.TabStop = true;
            this.llEsqueciSenha.Text = "Esqueci a Senha";
            this.llEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEsqueciSenha_LinkClicked);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.ControlBox = false;
            this.Controls.Add(this.llEsqueciSenha);
            this.Controls.Add(this.lbProPet);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.llCadastrarUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.LinkLabel llCadastrarUsuario;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbProPet;
        private System.Windows.Forms.LinkLabel llEsqueciSenha;
    }
}

