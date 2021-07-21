namespace Protótipo
{
    partial class frRelatCachorros
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
            this.crystRepCachorro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystCachorros1 = new Protótipo.crystCachorros();
            this.SuspendLayout();
            // 
            // crystRepCachorro
            // 
            this.crystRepCachorro.ActiveViewIndex = 0;
            this.crystRepCachorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystRepCachorro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystRepCachorro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystRepCachorro.Location = new System.Drawing.Point(0, 0);
            this.crystRepCachorro.Name = "crystRepCachorro";
            this.crystRepCachorro.ReportSource = this.crystCachorros1;
            this.crystRepCachorro.Size = new System.Drawing.Size(783, 417);
            this.crystRepCachorro.TabIndex = 0;
            this.crystRepCachorro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frRelatCachorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 417);
            this.Controls.Add(this.crystRepCachorro);
            this.Name = "frRelatCachorros";
            this.Text = "Relatporio de Cachorros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frRelatCachorros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystRepCachorro;
        private crystCachorros crystCachorros1;
    }
}