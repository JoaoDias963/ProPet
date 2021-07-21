namespace Protótipo
{
    partial class rtExtrato
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
            this.crystExtrato = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crExtrato1 = new Protótipo.crExtrato();
            this.SuspendLayout();
            // 
            // crystExtrato
            // 
            this.crystExtrato.ActiveViewIndex = 0;
            this.crystExtrato.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystExtrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystExtrato.Location = new System.Drawing.Point(0, 0);
            this.crystExtrato.Name = "crystExtrato";
            this.crystExtrato.ReportSource = this.crExtrato1;
            this.crystExtrato.ShowPageNavigateButtons = false;
            this.crystExtrato.Size = new System.Drawing.Size(431, 498);
            this.crystExtrato.TabIndex = 0;
            this.crystExtrato.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rtExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 498);
            this.Controls.Add(this.crystExtrato);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rtExtrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificado de Adoção";
            this.Load += new System.EventHandler(this.rtExtrato_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystExtrato;
        private crExtrato crExtrato1;
    }
}