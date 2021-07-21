namespace Protótipo
{
    partial class fmCadastrarAdocao
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbProPeT = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbCadastrar = new System.Windows.Forms.Label();
            this.pbCadastrar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCadastroCachorro = new System.Windows.Forms.GroupBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcDataRegistro = new System.Windows.Forms.MonthCalendar();
            this.mtbDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.gbAmiguinho = new System.Windows.Forms.GroupBox();
            this.lbDono = new System.Windows.Forms.Label();
            this.lbDono1 = new System.Windows.Forms.Label();
            this.tbSelecionado = new System.Windows.Forms.TextBox();
            this.lbCachorroSelecionado = new System.Windows.Forms.Label();
            this.btDisponiveis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.gbCadastroCachorro.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAmiguinho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnSuperior.Location = new System.Drawing.Point(0, 1);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 10;
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
            this.lbBuscar.Location = new System.Drawing.Point(172, 19);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(114, 17);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Listar Adoções";
            this.lbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
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
            // 
            // pbCadastrar
            // 
            this.pbCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbCadastrar.Image = global::Protótipo.Properties.Resources.botao;
            this.pbCadastrar.InitialImage = global::Protótipo.Properties.Resources.botao;
            this.pbCadastrar.Location = new System.Drawing.Point(2, 3);
            this.pbCadastrar.Name = "pbCadastrar";
            this.pbCadastrar.Size = new System.Drawing.Size(140, 60);
            this.pbCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCadastrar.TabIndex = 0;
            this.pbCadastrar.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Protótipo.Properties.Resources.botaoNormal;
            this.pbBuscar.Location = new System.Drawing.Point(155, 3);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(140, 60);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 3;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // gbCadastroCachorro
            // 
            this.gbCadastroCachorro.BackColor = System.Drawing.Color.PaleGreen;
            this.gbCadastroCachorro.Controls.Add(this.btCadastrar);
            this.gbCadastroCachorro.Controls.Add(this.btCancelar);
            this.gbCadastroCachorro.Controls.Add(this.gbData);
            this.gbCadastroCachorro.Controls.Add(this.gbAmiguinho);
            this.gbCadastroCachorro.Controls.Add(this.groupBox1);
            this.gbCadastroCachorro.Location = new System.Drawing.Point(11, 83);
            this.gbCadastroCachorro.Name = "gbCadastroCachorro";
            this.gbCadastroCachorro.Size = new System.Drawing.Size(645, 500);
            this.gbCadastroCachorro.TabIndex = 11;
            this.gbCadastroCachorro.TabStop = false;
            this.gbCadastroCachorro.Text = "Nova Adoção";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(334, 445);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(161, 23);
            this.btCadastrar.TabIndex = 42;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancelar.Location = new System.Drawing.Point(154, 445);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(161, 23);
            this.btCancelar.TabIndex = 41;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.mcDataRegistro);
            this.gbData.Controls.Add(this.mtbDataRegistro);
            this.gbData.ForeColor = System.Drawing.SystemColors.MenuText;
            this.gbData.Location = new System.Drawing.Point(37, 247);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(572, 175);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(60, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Selecione a Data";
            // 
            // mcDataRegistro
            // 
            this.mcDataRegistro.Location = new System.Drawing.Point(340, 8);
            this.mcDataRegistro.Name = "mcDataRegistro";
            this.mcDataRegistro.TabIndex = 28;
            this.mcDataRegistro.TabStop = false;
            this.mcDataRegistro.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcDataRegistro_DateSelected);
            // 
            // mtbDataRegistro
            // 
            this.mtbDataRegistro.Location = new System.Drawing.Point(155, 71);
            this.mtbDataRegistro.Mask = "00/00/0000";
            this.mtbDataRegistro.Name = "mtbDataRegistro";
            this.mtbDataRegistro.ReadOnly = true;
            this.mtbDataRegistro.Size = new System.Drawing.Size(151, 20);
            this.mtbDataRegistro.TabIndex = 27;
            this.mtbDataRegistro.ValidatingType = typeof(System.DateTime);
            this.mtbDataRegistro.Click += new System.EventHandler(this.mtbDataRegistro_Click);
            this.mtbDataRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDataRegistro_KeyDown);
            // 
            // gbAmiguinho
            // 
            this.gbAmiguinho.BackColor = System.Drawing.Color.LightCyan;
            this.gbAmiguinho.Controls.Add(this.lbEnd);
            this.gbAmiguinho.Controls.Add(this.lbDono);
            this.gbAmiguinho.Controls.Add(this.lbDono1);
            this.gbAmiguinho.Controls.Add(this.tbSelecionado);
            this.gbAmiguinho.Controls.Add(this.lbCachorroSelecionado);
            this.gbAmiguinho.Controls.Add(this.btDisponiveis);
            this.gbAmiguinho.Location = new System.Drawing.Point(37, 33);
            this.gbAmiguinho.Name = "gbAmiguinho";
            this.gbAmiguinho.Size = new System.Drawing.Size(572, 88);
            this.gbAmiguinho.TabIndex = 1;
            this.gbAmiguinho.TabStop = false;
            this.gbAmiguinho.Text = "Amiguinho";
            // 
            // lbDono
            // 
            this.lbDono.AutoSize = true;
            this.lbDono.Location = new System.Drawing.Point(363, 60);
            this.lbDono.Name = "lbDono";
            this.lbDono.Size = new System.Drawing.Size(43, 13);
            this.lbDono.TabIndex = 3;
            this.lbDono.Text = "lblDono";
            this.lbDono.Visible = false;
            // 
            // lbDono1
            // 
            this.lbDono1.AutoSize = true;
            this.lbDono1.Location = new System.Drawing.Point(321, 60);
            this.lbDono1.Name = "lbDono1";
            this.lbDono1.Size = new System.Drawing.Size(36, 13);
            this.lbDono1.TabIndex = 2;
            this.lbDono1.Text = "Dono:";
            this.lbDono1.Visible = false;
            // 
            // tbSelecionado
            // 
            this.tbSelecionado.Location = new System.Drawing.Point(324, 37);
            this.tbSelecionado.Name = "tbSelecionado";
            this.tbSelecionado.ReadOnly = true;
            this.tbSelecionado.Size = new System.Drawing.Size(148, 20);
            this.tbSelecionado.TabIndex = 1;
            this.tbSelecionado.Click += new System.EventHandler(this.tbSelecionado_Click);
            this.tbSelecionado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSelecionado_KeyDown);
            this.tbSelecionado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSelecionado_KeyPress);
            // 
            // lbCachorroSelecionado
            // 
            this.lbCachorroSelecionado.AutoSize = true;
            this.lbCachorroSelecionado.Location = new System.Drawing.Point(321, 16);
            this.lbCachorroSelecionado.Name = "lbCachorroSelecionado";
            this.lbCachorroSelecionado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCachorroSelecionado.Size = new System.Drawing.Size(115, 13);
            this.lbCachorroSelecionado.TabIndex = 1;
            this.lbCachorroSelecionado.Text = "Cachorro Selecionado:";
            // 
            // btDisponiveis
            // 
            this.btDisponiveis.Location = new System.Drawing.Point(107, 35);
            this.btDisponiveis.Name = "btDisponiveis";
            this.btDisponiveis.Size = new System.Drawing.Size(111, 23);
            this.btDisponiveis.TabIndex = 0;
            this.btDisponiveis.Text = "Mostrar Disponíveis";
            this.btDisponiveis.UseVisualStyleBackColor = true;
            this.btDisponiveis.Click += new System.EventHandler(this.btDisponiveis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lbCpf);
            this.groupBox1.Location = new System.Drawing.Point(37, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cão-Panheiro";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(266, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(269, 19);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.ReadOnly = true;
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 2;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.TextChanged += new System.EventHandler(this.mtbCpfDigitando);
            this.mtbCpf.Enter += new System.EventHandler(this.mtbCpf_Enter);
            this.mtbCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCpf_KeyDown);
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(197, 22);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(66, 13);
            this.lbCpf.TabIndex = 0;
            this.lbCpf.Text = "Digite o CPF";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(363, 75);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(34, 13);
            this.lbEnd.TabIndex = 4;
            this.lbEnd.Text = "lbEnd";
            this.lbEnd.Visible = false;
            // 
            // fmCadastrarAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.gbCadastroCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCadastrarAdocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmAdocao";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.gbCadastroCachorro.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbAmiguinho.ResumeLayout(false);
            this.gbAmiguinho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbProPeT;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbCadastrar;
        private System.Windows.Forms.PictureBox pbCadastrar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbCadastroCachorro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAmiguinho;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mcDataRegistro;
        private System.Windows.Forms.MaskedTextBox mtbDataRegistro;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbSelecionado;
        private System.Windows.Forms.Label lbCachorroSelecionado;
        private System.Windows.Forms.Button btDisponiveis;
        private System.Windows.Forms.Label lbDono;
        private System.Windows.Forms.Label lbDono1;
        private System.Windows.Forms.Label lbEnd;
    }
}