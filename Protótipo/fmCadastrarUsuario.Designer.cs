namespace Protótipo
{
    partial class fmCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastrarUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSenhaAdm = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenhaCadastro = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.epUsuarioInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNovoUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(22, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbSenhaAdm
            // 
            this.lbSenhaAdm.AutoSize = true;
            this.lbSenhaAdm.BackColor = System.Drawing.Color.White;
            this.lbSenhaAdm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSenhaAdm.Location = new System.Drawing.Point(64, 131);
            this.lbSenhaAdm.Name = "lbSenhaAdm";
            this.lbSenhaAdm.Size = new System.Drawing.Size(104, 13);
            this.lbSenhaAdm.TabIndex = 6;
            this.lbSenhaAdm.Text = "Senha Administrador";
            this.lbSenhaAdm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSenhaAdm.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.lbSenhaAdm.Click += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsTab = true;
            this.tbPassword.Location = new System.Drawing.Point(57, 128);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(130, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUsuario.Location = new System.Drawing.Point(56, 171);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(75, 13);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "Novo Usuário:";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsuario.Visible = false;
            // 
            // lbSenhaCadastro
            // 
            this.lbSenhaCadastro.AutoSize = true;
            this.lbSenhaCadastro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbSenhaCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSenhaCadastro.Location = new System.Drawing.Point(55, 227);
            this.lbSenhaCadastro.Name = "lbSenhaCadastro";
            this.lbSenhaCadastro.Size = new System.Drawing.Size(122, 13);
            this.lbSenhaCadastro.TabIndex = 15;
            this.lbSenhaCadastro.Text = "Senha do novo Usuário:";
            this.lbSenhaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSenhaCadastro.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(80, 317);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(79, 288);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(88, 23);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Visible = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbSenhaCadastro
            // 
            this.tbSenhaCadastro.AcceptsTab = true;
            this.tbSenhaCadastro.Location = new System.Drawing.Point(56, 243);
            this.tbSenhaCadastro.Name = "tbSenhaCadastro";
            this.tbSenhaCadastro.Size = new System.Drawing.Size(130, 20);
            this.tbSenhaCadastro.TabIndex = 0;
            this.tbSenhaCadastro.Text = "1234";
            this.tbSenhaCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSenhaCadastro.Visible = false;
            this.tbSenhaCadastro.TextChanged += new System.EventHandler(this.tbNovoUsuario_TextChanged);
            this.tbSenhaCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenhaCadastro_KeyDown);
            this.tbSenhaCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenhaCadastro_KeyPress);
            // 
            // epUsuarioInvalido
            // 
            this.epUsuarioInvalido.ContainerControl = this;
            // 
            // tbNovoUsuario
            // 
            this.tbNovoUsuario.Location = new System.Drawing.Point(57, 187);
            this.tbNovoUsuario.Name = "tbNovoUsuario";
            this.tbNovoUsuario.Size = new System.Drawing.Size(129, 20);
            this.tbNovoUsuario.TabIndex = 2;
            this.tbNovoUsuario.Visible = false;
            this.tbNovoUsuario.TextChanged += new System.EventHandler(this.tbNovoUsuario_TextChanged);
            this.tbNovoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNovoUsuario_KeyDown);
            this.tbNovoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNovoUsuario_KeyPress);
            // 
            // fmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(244, 361);
            this.Controls.Add(this.tbNovoUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbSenhaCadastro);
            this.Controls.Add(this.tbSenhaCadastro);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbSenhaAdm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioInvalido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSenhaAdm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenhaCadastro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbSenhaCadastro;
        private System.Windows.Forms.ErrorProvider epUsuarioInvalido;
        private System.Windows.Forms.TextBox tbNovoUsuario;
    }
}