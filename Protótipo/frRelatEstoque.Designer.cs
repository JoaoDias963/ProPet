namespace Protótipo
{
    partial class frRelatEstoque
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
            this.crystVEstoque = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crEstoque1 = new Protótipo.crEstoque();
            this.SuspendLayout();
            // 
            // crystVEstoque
            // 
            this.crystVEstoque.ActiveViewIndex = 0;
            this.crystVEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystVEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystVEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystVEstoque.Location = new System.Drawing.Point(0, 0);
            this.crystVEstoque.Name = "crystVEstoque";
            this.crystVEstoque.ReportSource = this.crEstoque1;
            this.crystVEstoque.Size = new System.Drawing.Size(778, 338);
            this.crystVEstoque.TabIndex = 0;
            this.crystVEstoque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frRelatEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 338);
            this.Controls.Add(this.crystVEstoque);
            this.Name = "frRelatEstoque";
            this.Text = "Relatório de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frRelatEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystVEstoque;
        private crEstoque crEstoque1;
    }
}