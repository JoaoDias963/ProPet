namespace Protótipo
{
    partial class fmSolicitarProduto
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
            this.gbNovoItem = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.lbProdPorte = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.btCadastrarItem = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.gbNovoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNovoItem
            // 
            this.gbNovoItem.BackColor = System.Drawing.Color.Black;
            this.gbNovoItem.Controls.Add(this.cbCategoria);
            this.gbNovoItem.Controls.Add(this.lbCategoria);
            this.gbNovoItem.Controls.Add(this.cbPorte);
            this.gbNovoItem.Controls.Add(this.lbProdPorte);
            this.gbNovoItem.Controls.Add(this.cbUnidadeMedida);
            this.gbNovoItem.Controls.Add(this.btCancelar);
            this.gbNovoItem.Controls.Add(this.lbUnidade);
            this.gbNovoItem.Controls.Add(this.btCadastrarItem);
            this.gbNovoItem.Controls.Add(this.lbNome);
            this.gbNovoItem.Controls.Add(this.tbNome);
            this.gbNovoItem.ForeColor = System.Drawing.SystemColors.Control;
            this.gbNovoItem.Location = new System.Drawing.Point(35, 168);
            this.gbNovoItem.Name = "gbNovoItem";
            this.gbNovoItem.Size = new System.Drawing.Size(593, 262);
            this.gbNovoItem.TabIndex = 19;
            this.gbNovoItem.TabStop = false;
            this.gbNovoItem.Text = "Cadastrar Novo Item";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ração",
            "Shampoo",
            "Vacina",
            "Utilitários"});
            this.cbCategoria.Location = new System.Drawing.Point(256, 32);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(209, 21);
            this.cbCategoria.TabIndex = 15;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(143, 35);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 14;
            this.lbCategoria.Text = "Categoria";
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
            "Todos"});
            this.cbPorte.Location = new System.Drawing.Point(256, 137);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(211, 21);
            this.cbPorte.TabIndex = 13;
            // 
            // lbProdPorte
            // 
            this.lbProdPorte.AutoSize = true;
            this.lbProdPorte.Location = new System.Drawing.Point(146, 140);
            this.lbProdPorte.Name = "lbProdPorte";
            this.lbProdPorte.Size = new System.Drawing.Size(104, 13);
            this.lbProdPorte.TabIndex = 12;
            this.lbProdPorte.Text = "Produto para o porte";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "Unidade (Un)",
            "Quilograma(kg)",
            "Miligrama (mg)",
            "Litro (L)",
            "Mililitro (mL)"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(258, 101);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(209, 21);
            this.cbUnidadeMedida.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(147, 202);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(129, 33);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Location = new System.Drawing.Point(143, 104);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(100, 13);
            this.lbUnidade.TabIndex = 6;
            this.lbUnidade.Text = "Unidade de Medida";
            // 
            // btCadastrarItem
            // 
            this.btCadastrarItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrarItem.Location = new System.Drawing.Point(339, 202);
            this.btCadastrarItem.Name = "btCadastrarItem";
            this.btCadastrarItem.Size = new System.Drawing.Size(129, 33);
            this.btCadastrarItem.TabIndex = 5;
            this.btCadastrarItem.Text = "Cadastrar";
            this.btCadastrarItem.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(143, 69);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(258, 69);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(209, 20);
            this.tbNome.TabIndex = 3;
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // fmSolicitarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.gbNovoItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmSolicitarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmSolicitarProduto";
            this.gbNovoItem.ResumeLayout(false);
            this.gbNovoItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovoItem;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.Label lbProdPorte;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.Button btCadastrarItem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
    }
}