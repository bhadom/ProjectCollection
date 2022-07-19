
namespace ProjectCollection.MenuPlan
{
    partial class FrmMenuPlan
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
            this.btnClose = new System.Windows.Forms.Button();
            this.wvPage = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(896, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // wvPage
            // 
            this.wvPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.wvPage.CreationProperties = null;
            this.wvPage.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.wvPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wvPage.Location = new System.Drawing.Point(0, 49);
            this.wvPage.Name = "wvPage";
            this.wvPage.Size = new System.Drawing.Size(995, 725);
            this.wvPage.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.wvPage.TabIndex = 0;
            this.wvPage.ZoomFactor = 1D;
            // 
            // FrmMenuPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(995, 774);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wvPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPlan";
            this.Text = "FrmMenuPlan";
            ((System.ComponentModel.ISupportInitialize)(this.wvPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPage;
    }
}