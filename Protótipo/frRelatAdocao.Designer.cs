namespace Protótipo
{
    partial class frRelatAdocao
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
            this.crystVAdocao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crAdocao1 = new Protótipo.crAdocao();
            this.SuspendLayout();
            // 
            // crystVAdocao
            // 
            this.crystVAdocao.ActiveViewIndex = 0;
            this.crystVAdocao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystVAdocao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystVAdocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystVAdocao.Location = new System.Drawing.Point(0, 0);
            this.crystVAdocao.Name = "crystVAdocao";
            this.crystVAdocao.ReportSource = this.crAdocao1;
            this.crystVAdocao.Size = new System.Drawing.Size(788, 420);
            this.crystVAdocao.TabIndex = 0;
            this.crystVAdocao.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frRelatAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 420);
            this.Controls.Add(this.crystVAdocao);
            this.Name = "frRelatAdocao";
            this.Text = "Relatório de Adoção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frRelatAdocao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystVAdocao;
        private crAdocao crAdocao1;
    }
}