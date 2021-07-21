namespace Protótipo
{
    partial class fmCadastrarCachorroAdocao
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
            this.chbSimVacinado = new System.Windows.Forms.CheckBox();
            this.lbVacinado = new System.Windows.Forms.Label();
            this.mtbDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.mcDataRegistro = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIdade = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.rtbPortes = new System.Windows.Forms.RichTextBox();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.lbPorte = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbRaca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.lbDono = new System.Windows.Forms.Label();
            this.lbProPeT = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.cachorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chbSimVacinado
            // 
            this.chbSimVacinado.AutoSize = true;
            this.chbSimVacinado.Location = new System.Drawing.Point(145, 375);
            this.chbSimVacinado.Name = "chbSimVacinado";
            this.chbSimVacinado.Size = new System.Drawing.Size(43, 17);
            this.chbSimVacinado.TabIndex = 53;
            this.chbSimVacinado.Text = "Sim";
            this.chbSimVacinado.UseVisualStyleBackColor = true;
            // 
            // lbVacinado
            // 
            this.lbVacinado.AutoSize = true;
            this.lbVacinado.Location = new System.Drawing.Point(33, 376);
            this.lbVacinado.Name = "lbVacinado";
            this.lbVacinado.Size = new System.Drawing.Size(104, 13);
            this.lbVacinado.TabIndex = 52;
            this.lbVacinado.Text = "Cachorro Vacinado?";
            // 
            // mtbDataRegistro
            // 
            this.mtbDataRegistro.Location = new System.Drawing.Point(161, 306);
            this.mtbDataRegistro.Mask = "00/00/0000";
            this.mtbDataRegistro.Name = "mtbDataRegistro";
            this.mtbDataRegistro.ReadOnly = true;
            this.mtbDataRegistro.Size = new System.Drawing.Size(151, 20);
            this.mtbDataRegistro.TabIndex = 9;
            this.mtbDataRegistro.ValidatingType = typeof(System.DateTime);
            this.mtbDataRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDataRegistro_KeyDown);
            this.mtbDataRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDataRegistro_KeyPress);
            // 
            // gbCadastro
            // 
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.btCancelar);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Controls.Add(this.btCadastrar);
            this.gbCadastro.Controls.Add(this.mcDataRegistro);
            this.gbCadastro.Controls.Add(this.groupBox1);
            this.gbCadastro.Location = new System.Drawing.Point(11, 74);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(645, 514);
            this.gbCadastro.TabIndex = 9;
            this.gbCadastro.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(101, 477);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(161, 23);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 28;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(355, 477);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(161, 23);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // mcDataRegistro
            // 
            this.mcDataRegistro.Location = new System.Drawing.Point(363, 267);
            this.mcDataRegistro.Name = "mcDataRegistro";
            this.mcDataRegistro.TabIndex = 26;
            this.mcDataRegistro.TabStop = false;
            this.mcDataRegistro.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcDataRegistro_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.chbSimVacinado);
            this.groupBox1.Controls.Add(this.cbIdade);
            this.groupBox1.Controls.Add(this.lbVacinado);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.mtbDataRegistro);
            this.groupBox1.Controls.Add(this.rtbPortes);
            this.groupBox1.Controls.Add(this.cbPorte);
            this.groupBox1.Controls.Add(this.lbPorte);
            this.groupBox1.Controls.Add(this.cbRaca);
            this.groupBox1.Controls.Add(this.cbCor);
            this.groupBox1.Controls.Add(this.lbCor);
            this.groupBox1.Controls.Add(this.rbFemea);
            this.groupBox1.Controls.Add(this.lbGenero);
            this.groupBox1.Controls.Add(this.rbMacho);
            this.groupBox1.Controls.Add(this.lbIdade);
            this.groupBox1.Controls.Add(this.lbRaca);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 452);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbIdade
            // 
            this.cbIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdade.FormattingEnabled = true;
            this.cbIdade.Items.AddRange(new object[] {
            "Filhote",
            "1-2 anos",
            "3-4 anos",
            "5-6 anos",
            "7-8 anos",
            "9-10 anos"});
            this.cbIdade.Location = new System.Drawing.Point(445, 92);
            this.cbIdade.Name = "cbIdade";
            this.cbIdade.Size = new System.Drawing.Size(151, 21);
            this.cbIdade.TabIndex = 4;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.PaleGreen;
            this.lbData.Location = new System.Drawing.Point(33, 309);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(87, 13);
            this.lbData.TabIndex = 24;
            this.lbData.Text = "Data de Registro";
            // 
            // rtbPortes
            // 
            this.rtbPortes.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbPortes.Location = new System.Drawing.Point(389, 148);
            this.rtbPortes.Name = "rtbPortes";
            this.rtbPortes.ReadOnly = true;
            this.rtbPortes.Size = new System.Drawing.Size(156, 88);
            this.rtbPortes.TabIndex = 23;
            this.rtbPortes.TabStop = false;
            this.rtbPortes.Text = "Mini ( < 5 kg )\nPequeno ( 5 - 10 kg )\nPequeno/Médio ( 10 - 15 kg )\nMédio ( 15 - 2" +
    "5 kg )\nGrande ( 25 - 40 kg )\nGigante ( > 40 kg )";
            // 
            // cbPorte
            // 
            this.cbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorte.FormattingEnabled = true;
            this.cbPorte.Items.AddRange(new object[] {
            "Mini",
            "Pequeno",
            "Pequeno/Médio",
            "Médio",
            "Grande",
            "Gigante"});
            this.cbPorte.Location = new System.Drawing.Point(160, 183);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(152, 21);
            this.cbPorte.TabIndex = 8;
            // 
            // lbPorte
            // 
            this.lbPorte.AutoSize = true;
            this.lbPorte.BackColor = System.Drawing.Color.PaleGreen;
            this.lbPorte.Location = new System.Drawing.Point(42, 186);
            this.lbPorte.Name = "lbPorte";
            this.lbPorte.Size = new System.Drawing.Size(32, 13);
            this.lbPorte.TabIndex = 21;
            this.lbPorte.Text = "Porte";
            // 
            // cbRaca
            // 
            this.cbRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Raça Não Definida (RND)",
            "Afghan Hound",
            "Airedale Terrier",
            "Akita Americano",
            "Akita Inu",
            "American Pitbull",
            "Basset Hound",
            "Beagle",
            "Bichon Frisé",
            "Boxer",
            "Bulldog",
            "Bullmastiff",
            "Bull Terrier",
            "Chihuahua",
            "Chow Chow",
            "Cocker Americano",
            "Cocker Inglês",
            "Collie",
            "Dálmata",
            "Dobermann",
            "Dogue Alemão",
            "Fila Brasileiro",
            "Foxhound Inglês",
            "Fox Terrier Pelo Duro",
            "Fox Terrier Pelo Liso",
            "Golden Retriever",
            "Husky Siberiano",
            "Retriever Do Labrador",
            "Labrador",
            "Lhasa Apso",
            "Lulu Da Pomerânia",
            "Maltês",
            "Mastiff",
            "Mastino Napoletano",
            "Old English Sheepdog",
            "Pastor Alemão",
            "Pequinês",
            "Perdigueiro",
            "Pinscher",
            "Pointer Inglês",
            "Poodle",
            "Rottweiler",
            "São Bernardo",
            "Schnauzer Gigante",
            "Schnauzer Miniatura",
            "Schnauzer Standard",
            "Setter Inglês",
            "Setter Irlandês",
            "Shar Pei",
            "Shih Tzu",
            "Spitz Alemão",
            "Staff Bull Terrier",
            "Teckel",
            "Terrier Brasileiro",
            "Yorkshire Terrier"});
            this.cbRaca.Location = new System.Drawing.Point(445, 50);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(152, 21);
            this.cbRaca.TabIndex = 2;
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Amarelo",
            "Azul",
            "Branco",
            "Chocolate",
            "Cinza",
            "Creme",
            "Dourado",
            "Preto",
            "Vermelho",
            "Bicolor",
            "Tigrado",
            "Pintado/Pintaigado",
            "Outra"});
            this.cbCor.Location = new System.Drawing.Point(160, 97);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(152, 21);
            this.cbCor.TabIndex = 7;
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.BackColor = System.Drawing.Color.PaleGreen;
            this.lbCor.Location = new System.Drawing.Point(32, 100);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(91, 13);
            this.lbCor.TabIndex = 19;
            this.lbCor.Text = "Cor Predominante";
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.BackColor = System.Drawing.Color.PaleGreen;
            this.rbFemea.Location = new System.Drawing.Point(125, 53);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(57, 17);
            this.rbFemea.TabIndex = 5;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Fêmea";
            this.rbFemea.UseVisualStyleBackColor = false;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.PaleGreen;
            this.lbGenero.Location = new System.Drawing.Point(32, 55);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(42, 13);
            this.lbGenero.TabIndex = 14;
            this.lbGenero.Text = "Genero";
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.BackColor = System.Drawing.Color.PaleGreen;
            this.rbMacho.Location = new System.Drawing.Point(214, 53);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 6;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = false;
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.BackColor = System.Drawing.Color.PaleGreen;
            this.lbIdade.Location = new System.Drawing.Point(348, 95);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(80, 13);
            this.lbIdade.TabIndex = 17;
            this.lbIdade.Text = "Idade Estimada";
            // 
            // lbRaca
            // 
            this.lbRaca.AutoSize = true;
            this.lbRaca.BackColor = System.Drawing.Color.PaleGreen;
            this.lbRaca.Location = new System.Drawing.Point(348, 53);
            this.lbRaca.Name = "lbRaca";
            this.lbRaca.Size = new System.Drawing.Size(33, 13);
            this.lbRaca.TabIndex = 10;
            this.lbRaca.Text = "Raça";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(92, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 40);
            this.panel1.TabIndex = 54;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnSuperior.Controls.Add(this.lbNomeDono);
            this.pnSuperior.Controls.Add(this.lbDono);
            this.pnSuperior.Controls.Add(this.lbProPeT);
            this.pnSuperior.Controls.Add(this.lbHora);
            this.pnSuperior.Location = new System.Drawing.Point(0, 6);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 8;
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDono.Location = new System.Drawing.Point(25, 23);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(66, 24);
            this.lbNomeDono.TabIndex = 10;
            this.lbNomeDono.Text = "Dono:";
            // 
            // lbDono
            // 
            this.lbDono.AutoSize = true;
            this.lbDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDono.Location = new System.Drawing.Point(108, 23);
            this.lbDono.Name = "lbDono";
            this.lbDono.Size = new System.Drawing.Size(60, 24);
            this.lbDono.TabIndex = 9;
            this.lbDono.Text = "Dono";
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
            // cachorroBindingSource
            // 
            this.cachorroBindingSource.DataSource = typeof(Protótipo.Cachorro);
            // 
            // fmCadastrarCachorroAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCadastrarCachorroAdocao";
            this.Text = "fmCadastrarCachorroAdocao";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cachorroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cachorroBindingSource;
        private System.Windows.Forms.CheckBox chbSimVacinado;
        private System.Windows.Forms.Label lbVacinado;
        private System.Windows.Forms.MaskedTextBox mtbDataRegistro;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.ComboBox cbIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.RichTextBox rtbPortes;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.Label lbPorte;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbRaca;
        private System.Windows.Forms.MonthCalendar mcDataRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbProPeT;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbNomeDono;
        private System.Windows.Forms.Label lbDono;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}