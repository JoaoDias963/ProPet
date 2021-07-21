namespace Protótipo
{
    partial class fmDetalhesPessoas
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
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbInteresse = new System.Windows.Forms.Label();
            this.lbPorte = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.rtbPortes = new System.Windows.Forms.RichTextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDesinteressado = new System.Windows.Forms.RadioButton();
            this.rbDoar = new System.Windows.Forms.RadioButton();
            this.rbAdotar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbInvalido = new System.Windows.Forms.PictureBox();
            this.pbValido = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvalido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValido)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(407, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Cidade *";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(487, 62);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.ReadOnly = true;
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCpf_KeyDown);
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(455, 170);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(130, 20);
            this.tbCidade.TabIndex = 10;
            this.tbCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCidade_KeyDown);
            this.tbCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCidade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(452, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "CPF *";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(297, 170);
            this.mtbCep.Mask = "00000-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(87, 20);
            this.mtbCep.TabIndex = 9;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            this.mtbCep.Enter += new System.EventHandler(this.mtbCep_Enter);
            this.mtbCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCep_KeyDown);
            this.mtbCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbTelefone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(26, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Bairro";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.BackColor = System.Drawing.Color.SpringGreen;
            this.lbTelefone.Location = new System.Drawing.Point(92, 254);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 70;
            this.lbTelefone.Text = "Telefone";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(151, 251);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 11;
            this.mtbTelefone.Click += new System.EventHandler(this.mtbTelefone_Click);
            this.mtbTelefone.Enter += new System.EventHandler(this.mtbTelefone_Enter);
            this.mtbTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbTelefone_KeyDown);
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.BackColor = System.Drawing.Color.SpringGreen;
            this.lbCep.Location = new System.Drawing.Point(261, 174);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(35, 13);
            this.lbCep.TabIndex = 92;
            this.lbCep.Text = "CEP *";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.BackColor = System.Drawing.Color.SpringGreen;
            this.lbCelular.Location = new System.Drawing.Point(372, 254);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 72;
            this.lbCelular.Text = "Celular";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(95, 133);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(490, 20);
            this.tbComplemento.TabIndex = 7;
            this.tbComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbComplemento_KeyDown);
            this.tbComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComplemento_KeyPress);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(417, 251);
            this.mtbCelular.Mask = "(99) 0 0000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbCelular.TabIndex = 12;
            this.mtbCelular.Click += new System.EventHandler(this.mtbCelular_Click);
            this.mtbCelular.Enter += new System.EventHandler(this.mtbCelular_Enter);
            this.mtbCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCelular_KeyDown);
            this.mtbCelular.Leave += new System.EventHandler(this.mtbCelular_Leave);
            // 
            // cbBairro
            // 
            this.cbBairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbBairro.Location = new System.Drawing.Point(82, 171);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(169, 21);
            this.cbBairro.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.SpringGreen;
            this.lbEmail.Location = new System.Drawing.Point(94, 296);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 74;
            this.lbEmail.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(151, 293);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(366, 20);
            this.tbEmail.TabIndex = 13;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // lbInteresse
            // 
            this.lbInteresse.AutoSize = true;
            this.lbInteresse.BackColor = System.Drawing.Color.SpringGreen;
            this.lbInteresse.Location = new System.Drawing.Point(44, 379);
            this.lbInteresse.Name = "lbInteresse";
            this.lbInteresse.Size = new System.Drawing.Size(50, 13);
            this.lbInteresse.TabIndex = 97;
            this.lbInteresse.Text = "Interesse";
            // 
            // lbPorte
            // 
            this.lbPorte.AutoSize = true;
            this.lbPorte.BackColor = System.Drawing.Color.SpringGreen;
            this.lbPorte.Location = new System.Drawing.Point(88, 429);
            this.lbPorte.Name = "lbPorte";
            this.lbPorte.Size = new System.Drawing.Size(32, 13);
            this.lbPorte.TabIndex = 100;
            this.lbPorte.Text = "Porte";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.BackColor = System.Drawing.Color.SpringGreen;
            this.lbComplemento.Location = new System.Drawing.Point(23, 136);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 84;
            this.lbComplemento.Text = "Complemento";
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
            "Gigante",
            "Qualquer Porte"});
            this.cbPorte.Location = new System.Drawing.Point(151, 429);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(200, 21);
            this.cbPorte.TabIndex = 19;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(503, 99);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(82, 20);
            this.tbNumero.TabIndex = 3;
            this.tbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyDown);
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(84, 99);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(345, 20);
            this.tbEndereco.TabIndex = 2;
            this.tbEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEndereco_KeyDown);
            this.tbEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEndereco_KeyPress);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.SpringGreen;
            this.lbNumero.Location = new System.Drawing.Point(450, 102);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(51, 13);
            this.lbNumero.TabIndex = 80;
            this.lbNumero.Text = "Número *";
            // 
            // rtbPortes
            // 
            this.rtbPortes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPortes.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbPortes.Location = new System.Drawing.Point(406, 377);
            this.rtbPortes.Name = "rtbPortes";
            this.rtbPortes.ReadOnly = true;
            this.rtbPortes.Size = new System.Drawing.Size(156, 88);
            this.rtbPortes.TabIndex = 104;
            this.rtbPortes.TabStop = false;
            this.rtbPortes.Text = "Mini ( < 5 kg )\nPequeno ( 5 - 10 kg )\nPequeno/Médio ( 10 - 15 kg )\nMédio ( 15 - 2" +
    "5 kg )\nGrande ( 25 - 40 kg )\nGigante ( > 40 kg )";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.BackColor = System.Drawing.Color.SpringGreen;
            this.lbEndereco.Location = new System.Drawing.Point(23, 102);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(60, 13);
            this.lbEndereco.TabIndex = 78;
            this.lbEndereco.Text = "Endereço *";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.SpringGreen;
            this.lbNome.Location = new System.Drawing.Point(25, 65);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(42, 13);
            this.lbNome.TabIndex = 76;
            this.lbNome.Text = "Nome *";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(84, 65);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(345, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNome_KeyDown);
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(260, 511);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 21;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(390, 511);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 22;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDesinteressado);
            this.panel1.Controls.Add(this.rbDoar);
            this.panel1.Controls.Add(this.rbAdotar);
            this.panel1.Location = new System.Drawing.Point(100, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 25);
            this.panel1.TabIndex = 106;
            // 
            // rbDesinteressado
            // 
            this.rbDesinteressado.AutoSize = true;
            this.rbDesinteressado.Location = new System.Drawing.Point(172, 4);
            this.rbDesinteressado.Name = "rbDesinteressado";
            this.rbDesinteressado.Size = new System.Drawing.Size(92, 17);
            this.rbDesinteressado.TabIndex = 18;
            this.rbDesinteressado.TabStop = true;
            this.rbDesinteressado.Text = "Sem Interesse";
            this.rbDesinteressado.UseVisualStyleBackColor = true;
            // 
            // rbDoar
            // 
            this.rbDoar.AutoSize = true;
            this.rbDoar.BackColor = System.Drawing.Color.SpringGreen;
            this.rbDoar.Location = new System.Drawing.Point(20, 4);
            this.rbDoar.Name = "rbDoar";
            this.rbDoar.Size = new System.Drawing.Size(48, 17);
            this.rbDoar.TabIndex = 17;
            this.rbDoar.TabStop = true;
            this.rbDoar.Text = "Doar";
            this.rbDoar.UseVisualStyleBackColor = false;
            this.rbDoar.CheckedChanged += new System.EventHandler(this.rbDoar_CheckedChanged);
            // 
            // rbAdotar
            // 
            this.rbAdotar.AutoSize = true;
            this.rbAdotar.BackColor = System.Drawing.Color.SpringGreen;
            this.rbAdotar.Location = new System.Drawing.Point(99, 4);
            this.rbAdotar.Name = "rbAdotar";
            this.rbAdotar.Size = new System.Drawing.Size(56, 17);
            this.rbAdotar.TabIndex = 16;
            this.rbAdotar.TabStop = true;
            this.rbAdotar.Text = "Adotar";
            this.rbAdotar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Controls.Add(this.btMostrar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pbInvalido);
            this.groupBox2.Controls.Add(this.pbValido);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btFechar);
            this.groupBox2.Controls.Add(this.btEditar);
            this.groupBox2.Controls.Add(this.tbNome);
            this.groupBox2.Controls.Add(this.lbNome);
            this.groupBox2.Controls.Add(this.lbEndereco);
            this.groupBox2.Controls.Add(this.rtbPortes);
            this.groupBox2.Controls.Add(this.lbNumero);
            this.groupBox2.Controls.Add(this.tbEndereco);
            this.groupBox2.Controls.Add(this.tbNumero);
            this.groupBox2.Controls.Add(this.cbPorte);
            this.groupBox2.Controls.Add(this.lbComplemento);
            this.groupBox2.Controls.Add(this.lbPorte);
            this.groupBox2.Controls.Add(this.lbInteresse);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.cbBairro);
            this.groupBox2.Controls.Add(this.mtbCelular);
            this.groupBox2.Controls.Add(this.tbComplemento);
            this.groupBox2.Controls.Add(this.lbCelular);
            this.groupBox2.Controls.Add(this.lbCep);
            this.groupBox2.Controls.Add(this.mtbTelefone);
            this.groupBox2.Controls.Add(this.lbTelefone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mtbCep);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbCidade);
            this.groupBox2.Controls.Add(this.mtbCpf);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 556);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cão-Panheiro";
            // 
            // btMostrar
            // 
            this.btMostrar.Enabled = false;
            this.btMostrar.Location = new System.Drawing.Point(130, 511);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 110;
            this.btMostrar.Text = "Mostrar Cachorros";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "* Campos obrigatórios";
            // 
            // pbInvalido
            // 
            this.pbInvalido.Image = global::Protótipo.Properties.Resources.close;
            this.pbInvalido.Location = new System.Drawing.Point(523, 292);
            this.pbInvalido.Name = "pbInvalido";
            this.pbInvalido.Size = new System.Drawing.Size(29, 20);
            this.pbInvalido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInvalido.TabIndex = 108;
            this.pbInvalido.TabStop = false;
            this.pbInvalido.Visible = false;
            // 
            // pbValido
            // 
            this.pbValido.Image = global::Protótipo.Properties.Resources.Accept_icon;
            this.pbValido.Location = new System.Drawing.Point(523, 292);
            this.pbValido.Name = "pbValido";
            this.pbValido.Size = new System.Drawing.Size(29, 20);
            this.pbValido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbValido.TabIndex = 107;
            this.pbValido.TabStop = false;
            this.pbValido.Visible = false;
            // 
            // fmDetalhesPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmDetalhesPessoas";
            this.Text = "fmDetalhesPessoas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvalido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbInteresse;
        private System.Windows.Forms.Label lbPorte;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.RichTextBox rtbPortes;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDoar;
        private System.Windows.Forms.RadioButton rbAdotar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDesinteressado;
        private System.Windows.Forms.PictureBox pbInvalido;
        private System.Windows.Forms.PictureBox pbValido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMostrar;
    }
}