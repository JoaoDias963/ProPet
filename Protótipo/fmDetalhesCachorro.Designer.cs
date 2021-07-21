namespace Protótipo
{
    partial class fmDetalhesCachorro
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
            this.mtbDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.cbIdade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.rtbPortes = new System.Windows.Forms.RichTextBox();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.lbPorte = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRaca = new System.Windows.Forms.Label();
            this.tbNomeCachorro = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.mcDataRegistro = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbSimVacinado = new System.Windows.Forms.CheckBox();
            this.lbVacinado = new System.Windows.Forms.Label();
            this.chbSimFalecido = new System.Windows.Forms.CheckBox();
            this.lbFalecido = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbDataRegistro
            // 
            this.mtbDataRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbDataRegistro.Location = new System.Drawing.Point(134, 370);
            this.mtbDataRegistro.Mask = "00/00/0000";
            this.mtbDataRegistro.Name = "mtbDataRegistro";
            this.mtbDataRegistro.ReadOnly = true;
            this.mtbDataRegistro.Size = new System.Drawing.Size(151, 20);
            this.mtbDataRegistro.TabIndex = 8;
            this.mtbDataRegistro.ValidatingType = typeof(System.DateTime);
            this.mtbDataRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDataRegistro_KeyDown);
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
            this.cbIdade.Location = new System.Drawing.Point(455, 137);
            this.cbIdade.Name = "cbIdade";
            this.cbIdade.Size = new System.Drawing.Size(151, 21);
            this.cbIdade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 48;
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
            this.cbRaca.Location = new System.Drawing.Point(455, 79);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(152, 21);
            this.cbRaca.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.PaleGreen;
            this.lbData.Location = new System.Drawing.Point(23, 373);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(87, 13);
            this.lbData.TabIndex = 46;
            this.lbData.Text = "Data de Registro";
            // 
            // rtbPortes
            // 
            this.rtbPortes.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbPortes.Location = new System.Drawing.Point(385, 242);
            this.rtbPortes.Name = "rtbPortes";
            this.rtbPortes.ReadOnly = true;
            this.rtbPortes.Size = new System.Drawing.Size(156, 88);
            this.rtbPortes.TabIndex = 45;
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
            this.cbPorte.Location = new System.Drawing.Point(79, 293);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(206, 21);
            this.cbPorte.TabIndex = 7;
            // 
            // lbPorte
            // 
            this.lbPorte.AutoSize = true;
            this.lbPorte.BackColor = System.Drawing.Color.PaleGreen;
            this.lbPorte.Location = new System.Drawing.Point(23, 296);
            this.lbPorte.Name = "lbPorte";
            this.lbPorte.Size = new System.Drawing.Size(32, 13);
            this.lbPorte.TabIndex = 44;
            this.lbPorte.Text = "Porte";
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
            this.cbCor.Location = new System.Drawing.Point(456, 222);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(152, 21);
            this.cbCor.TabIndex = 6;
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.BackColor = System.Drawing.Color.PaleGreen;
            this.lbCor.Location = new System.Drawing.Point(358, 225);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(91, 13);
            this.lbCor.TabIndex = 43;
            this.lbCor.Text = "Cor Predominante";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.BackColor = System.Drawing.Color.PaleGreen;
            this.lbIdade.Location = new System.Drawing.Point(358, 140);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(80, 13);
            this.lbIdade.TabIndex = 42;
            this.lbIdade.Text = "Idade Estimada";
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.BackColor = System.Drawing.Color.PaleGreen;
            this.rbMacho.Location = new System.Drawing.Point(231, 223);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 5;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = false;
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.BackColor = System.Drawing.Color.PaleGreen;
            this.rbFemea.Location = new System.Drawing.Point(142, 223);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(57, 17);
            this.rbFemea.TabIndex = 4;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Fêmea";
            this.rbFemea.UseVisualStyleBackColor = false;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.PaleGreen;
            this.lbGenero.Location = new System.Drawing.Point(49, 225);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(42, 13);
            this.lbGenero.TabIndex = 41;
            this.lbGenero.Text = "Genero";
            // 
            // cbBairro
            // 
            this.cbBairro.AllowDrop = true;
            this.cbBairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBairro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Items.AddRange(new object[] {
            "Desconhecido",
            "Água Vermelha",
            "Antenor Garcia",
            "Azulville",
            "Bosque São Carlos",
            "Botafogo",
            "CEAT",
            "Centro Comunitário",
            "Chácara Do Parque",
            "Chácara Parcílio",
            "Cidade Aracy",
            "Cidade Jardim",
            "Cidade Universitária",
            "Condomínio Dom Bosco",
            "Condomínio Oscar Barros",
            "Condomínio Swiss Park",
            "Dona Eugenia",
            "Estância Recreio Santa Lucia",
            "Jardim Albertini",
            "Jardim Alvorada",
            "Jardim Bandeirantes",
            "Jardim Beatriz",
            "Jardim Belvedere",
            "Jardim Cardinalli",
            "Jardim Castelo Branco",
            "Jardim Centenário",
            "Jardim Cruzeiro Do Sul",
            "Jardim Das Torres",
            "Jardim De Cresci",
            "Jardim Dona Francisca",
            "Jardim Gibertoni",
            "Jardim Gonzaga",
            "Jardim Guanabara",
            "Jardim Ipanema",
            "Jardim Jockey Clube",
            "Jardim Lutfalla",
            "Jardim Macarengo",
            "Jardim Maracanã",
            "Jardim Medeiros",
            "Jardim Mercedes",
            "Jardim Mirna",
            "Jardim Munique I",
            "Jardim Munique II",
            "Jardim Nossa Senhora Aparecida I",
            "Jardim Nossa Senhora Aparecida II",
            "Jardim Nova São Carlos",
            "Jardim Novo Horizonte",
            "Jardim Pacaembu",
            "Jardim Paraiso",
            "Jardim Paulista",
            "Jardim Paulistano",
            "Jardim Planalto",
            "Jardim Real",
            "Jardim Ricetti",
            "Jardim Santa Helena",
            "Jardim Santa Tereza",
            "Jardim São Carlos",
            "Jardim São João Batista",
            "Jardim São Paulo",
            "Jardim São Rafael",
            "Jardim Sempre Vale",
            "Jardim Tangará",
            "Jardim Tijuca",
            "Jardim Tijuco Preto",
            "Kartódromo",
            "Lagoa Serena",
            "Maria Stela Fagá",
            "Monte Carlo",
            "Morada Dos Deuses",
            "Moradas São Carlos I",
            "Moradas São Carlos II",
            "Moradas São Carlos III",
            "Nossa Senhora De Fatima",
            "Nova Estância",
            "Parque Anhembi",
            "Parque Belvedere",
            "Parque Delta",
            "Parque dos Coqueiros",
            "Parque Dos Timburis",
            "Parque Douradinho",
            "Parque Eldorado",
            "Parque Faber I",
            "Parque Faber II",
            "Parque Faber III",
            "Parque Fehr",
            "Parque Iguatemi",
            "Parque Itaipu",
            "Parque Itamarati",
            "Parque Montreal",
            "Parque Nova Estância",
            "Parque Primavera",
            "Parque Quebec",
            "Parque Sabará",
            "Parque Santa Felícia",
            "Parque Santa Monica",
            "Parque Santa Paula",
            "Parque São Carlos",
            "Parque São Jorge",
            "Parque São Miguel",
            "Parque Sisi",
            "Parque Vale Do Uirapuru",
            "Parque Vila Verde Sabará",
            "Porta Do Sol",
            "Recreio Campestre",
            "Recreio Dos Bandeirantes",
            "Redenção",
            "Res Américo Alves Margarido",
            "Res Astolpho Luiz Do Prado",
            "Residencial Ana Carolina",
            "Residencial Damha GolfI",
            "Residencial Damha I",
            "Residencial Damha II",
            "Residencial Damha III",
            "Residencial Damha IV",
            "Residencial Monsenhor Romeu Tortorelli",
            "Residencial Montreal",
            "Residencial Parati",
            "Residencial Village I",
            "Residencial Village II",
            "Residencial Village III",
            "Residencial Village IV",
            "Samambaia Residencial",
            "Santa Angelina",
            "Santa Eudóxia",
            "Santa Julia",
            "São Carlos VIII",
            "Terra Nova",
            "Vila Alpes",
            "Vila Arnaldo",
            "Vila Bela Vista",
            "Vila Boa Vista I",
            "Vila Boa Vista II",
            "Vila Caetano",
            "Vila Carmem",
            "Vila Conceição",
            "Vila Costa Do Sol",
            "Vila Deriggi",
            "Vila Elizabeth",
            "Vila Faria",
            "Vila Industrial",
            "Vila Irene",
            "Vila Isabel",
            "Vila Jacobucci",
            "Vila Laura",
            "Vila Lutfalla",
            "Vila Marcelino",
            "Vila Marina",
            "Vila Max",
            "Vila Monteiro",
            "Vila Nery",
            "Vila Palmares",
            "Vila Parque  Industrial",
            "Vila Pelicano",
            "Vila Prado",
            "Vila Pureza",
            "Vila Rancho Velho",
            "Vila Rica",
            "Vila Santa Maria I",
            "Vila Santa Maria II",
            "Vila Santa Maria III",
            "Vila Santo Antônio",
            "Vila São Gabriel",
            "Vila São Jose",
            "Vila São Jose",
            "Vila Sonia",
            "Vista Alegre"});
            this.cbBairro.Location = new System.Drawing.Point(91, 140);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(207, 21);
            this.cbBairro.TabIndex = 2;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.PaleGreen;
            this.lbBairro.Location = new System.Drawing.Point(48, 143);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 40;
            this.lbBairro.Text = "Bairro ";
            // 
            // lbRaca
            // 
            this.lbRaca.AutoSize = true;
            this.lbRaca.BackColor = System.Drawing.Color.PaleGreen;
            this.lbRaca.Location = new System.Drawing.Point(358, 82);
            this.lbRaca.Name = "lbRaca";
            this.lbRaca.Size = new System.Drawing.Size(33, 13);
            this.lbRaca.TabIndex = 39;
            this.lbRaca.Text = "Raça";
            // 
            // tbNomeCachorro
            // 
            this.tbNomeCachorro.Location = new System.Drawing.Point(89, 79);
            this.tbNomeCachorro.Name = "tbNomeCachorro";
            this.tbNomeCachorro.Size = new System.Drawing.Size(209, 20);
            this.tbNomeCachorro.TabIndex = 0;
            this.tbNomeCachorro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeCachorro_KeyDown);
            this.tbNomeCachorro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeCachorro_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.PaleGreen;
            this.lbNome.Location = new System.Drawing.Point(48, 84);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 36;
            this.lbNome.Text = "Nome";
            // 
            // mcDataRegistro
            // 
            this.mcDataRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcDataRegistro.Location = new System.Drawing.Point(353, 342);
            this.mcDataRegistro.Name = "mcDataRegistro";
            this.mcDataRegistro.TabIndex = 47;
            this.mcDataRegistro.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.chbSimVacinado);
            this.groupBox1.Controls.Add(this.lbVacinado);
            this.groupBox1.Controls.Add(this.chbSimFalecido);
            this.groupBox1.Controls.Add(this.lbFalecido);
            this.groupBox1.Controls.Add(this.mtbDataRegistro);
            this.groupBox1.Controls.Add(this.rtbPortes);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.mcDataRegistro);
            this.groupBox1.Controls.Add(this.cbPorte);
            this.groupBox1.Controls.Add(this.lbPorte);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 516);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cachorro";
            // 
            // chbSimVacinado
            // 
            this.chbSimVacinado.AutoSize = true;
            this.chbSimVacinado.Location = new System.Drawing.Point(134, 432);
            this.chbSimVacinado.Name = "chbSimVacinado";
            this.chbSimVacinado.Size = new System.Drawing.Size(43, 17);
            this.chbSimVacinado.TabIndex = 51;
            this.chbSimVacinado.Text = "Sim";
            this.chbSimVacinado.UseVisualStyleBackColor = true;
            // 
            // lbVacinado
            // 
            this.lbVacinado.AutoSize = true;
            this.lbVacinado.Location = new System.Drawing.Point(22, 433);
            this.lbVacinado.Name = "lbVacinado";
            this.lbVacinado.Size = new System.Drawing.Size(104, 13);
            this.lbVacinado.TabIndex = 50;
            this.lbVacinado.Text = "Cachorro Vacinado?";
            // 
            // chbSimFalecido
            // 
            this.chbSimFalecido.AutoSize = true;
            this.chbSimFalecido.Location = new System.Drawing.Point(134, 466);
            this.chbSimFalecido.Name = "chbSimFalecido";
            this.chbSimFalecido.Size = new System.Drawing.Size(43, 17);
            this.chbSimFalecido.TabIndex = 49;
            this.chbSimFalecido.Text = "Sim";
            this.chbSimFalecido.UseVisualStyleBackColor = true;
            // 
            // lbFalecido
            // 
            this.lbFalecido.AutoSize = true;
            this.lbFalecido.Location = new System.Drawing.Point(22, 467);
            this.lbFalecido.Name = "lbFalecido";
            this.lbFalecido.Size = new System.Drawing.Size(96, 13);
            this.lbFalecido.TabIndex = 48;
            this.lbFalecido.Text = "Cachorro falecido?";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(361, 549);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 11;
            this.btConfirmar.Text = "Fechar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(223, 549);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // fmDetalhesCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.cbIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.rbMacho);
            this.Controls.Add(this.rbFemea);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.cbBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbRaca);
            this.Controls.Add(this.tbNomeCachorro);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmDetalhesCachorro";
            this.Text = "fmDetalhesCachorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDataRegistro;
        private System.Windows.Forms.ComboBox cbIdade;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRaca;
        private System.Windows.Forms.TextBox tbNomeCachorro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MonthCalendar mcDataRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lbFalecido;
        private System.Windows.Forms.CheckBox chbSimVacinado;
        private System.Windows.Forms.Label lbVacinado;
        private System.Windows.Forms.CheckBox chbSimFalecido;
    }
}