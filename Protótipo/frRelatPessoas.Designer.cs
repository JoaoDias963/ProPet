namespace Protótipo
{
    partial class frRelatPessoas
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
            this.crysRPessoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystPessoas1 = new Protótipo.crystPessoas();
            this.SuspendLayout();
            // 
            // crysRPessoa
            // 
            this.crysRPessoa.ActiveViewIndex = 0;
            this.crysRPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysRPessoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysRPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysRPessoa.Location = new System.Drawing.Point(0, 0);
            this.crysRPessoa.Name = "crysRPessoa";
            this.crysRPessoa.ReportSource = this.crystPessoas1;
            this.crysRPessoa.Size = new System.Drawing.Size(723, 403);
            this.crysRPessoa.TabIndex = 0;
            this.crysRPessoa.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frRelatPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 403);
            this.Controls.Add(this.crysRPessoa);
            this.Name = "frRelatPessoas";
            this.Text = "Relatório de Pessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frRelatPessoas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crysRPessoa;
        private crystPessoas crystPessoas1;
    }
}