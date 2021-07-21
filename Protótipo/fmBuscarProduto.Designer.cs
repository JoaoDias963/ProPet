namespace Protótipo
{
    partial class fmBuscarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.clProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.gbCadastroCachorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
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
            this.pnSuperior.Location = new System.Drawing.Point(0, 3);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(667, 63);
            this.pnSuperior.TabIndex = 14;
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
            this.lbBuscar.Location = new System.Drawing.Point(195, 20);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(65, 17);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Estoque";
            this.lbBuscar.MouseLeave += new System.EventHandler(this.pbBuscar_MouseLeave);
            this.lbBuscar.MouseHover += new System.EventHandler(this.pbBuscar_MouseHover);
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
            this.lbCadastrar.Click += new System.EventHandler(this.pbCadastrar_Click);
            this.lbCadastrar.MouseLeave += new System.EventHandler(this.pbCadastrar_MouseLeave);
            this.lbCadastrar.MouseHover += new System.EventHandler(this.pbCadastrar_MouseHover);
            // 
            // pbCadastrar
            // 
            this.pbCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbCadastrar.Image = global::Protótipo.Properties.Resources.botaoNormal;
            this.pbCadastrar.InitialImage = null;
            this.pbCadastrar.Location = new System.Drawing.Point(2, 3);
            this.pbCadastrar.Name = "pbCadastrar";
            this.pbCadastrar.Size = new System.Drawing.Size(140, 60);
            this.pbCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCadastrar.TabIndex = 0;
            this.pbCadastrar.TabStop = false;
            this.pbCadastrar.Click += new System.EventHandler(this.pbCadastrar_Click);
            this.pbCadastrar.MouseLeave += new System.EventHandler(this.pbCadastrar_MouseLeave);
            this.pbCadastrar.MouseHover += new System.EventHandler(this.pbCadastrar_MouseHover);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Protótipo.Properties.Resources.botao;
            this.pbBuscar.Location = new System.Drawing.Point(155, 3);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(140, 60);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 3;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.MouseLeave += new System.EventHandler(this.pbBuscar_MouseLeave);
            this.pbBuscar.MouseHover += new System.EventHandler(this.pbBuscar_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCadastroCachorro
            // 
            this.gbCadastroCachorro.BackColor = System.Drawing.Color.PaleGreen;
            this.gbCadastroCachorro.Controls.Add(this.tbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.lbPesquisar);
            this.gbCadastroCachorro.Controls.Add(this.dgvEstoque);
            this.gbCadastroCachorro.Location = new System.Drawing.Point(11, 83);
            this.gbCadastroCachorro.Name = "gbCadastroCachorro";
            this.gbCadastroCachorro.Size = new System.Drawing.Size(645, 500);
            this.gbCadastroCachorro.TabIndex = 15;
            this.gbCadastroCachorro.TabStop = false;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(27, 58);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(257, 20);
            this.tbPesquisar.TabIndex = 13;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesquisar_KeyPress);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(25, 36);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(158, 13);
            this.lbPesquisar.TabIndex = 12;
            this.lbPesquisar.Text = "Pesquisar (Marca ou Categoria):";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeColumns = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProduto,
            this.clCategoria,
            this.clQuantidade,
            this.clDataRegistro});
            this.dgvEstoque.Location = new System.Drawing.Point(6, 98);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(633, 396);
            this.dgvEstoque.TabIndex = 1;
            // 
            // clProduto
            // 
            this.clProduto.HeaderText = "Produto";
            this.clProduto.Name = "clProduto";
            this.clProduto.ReadOnly = true;
            // 
            // clCategoria
            // 
            this.clCategoria.HeaderText = "Categoria";
            this.clCategoria.Name = "clCategoria";
            this.clCategoria.ReadOnly = true;
            // 
            // clQuantidade
            // 
            this.clQuantidade.HeaderText = "Quantidade";
            this.clQuantidade.Name = "clQuantidade";
            this.clQuantidade.ReadOnly = true;
            // 
            // clDataRegistro
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clDataRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.clDataRegistro.HeaderText = "Data Registro";
            this.clDataRegistro.Name = "clDataRegistro";
            this.clDataRegistro.ReadOnly = true;
            // 
            // fmBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 595);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.gbCadastroCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBuscarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmBuscarProduto";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.gbCadastroCachorro.ResumeLayout(false);
            this.gbCadastroCachorro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataRegistro;
    }
}