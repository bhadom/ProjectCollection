
namespace ProjectCollection
{
    partial class FrmMain
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlMenuPlanSub = new System.Windows.Forms.Panel();
            this.btnPlanCustom = new System.Windows.Forms.Button();
            this.btnPlanToday = new System.Windows.Forms.Button();
            this.btnPlanMenu = new System.Windows.Forms.Button();
            this.pnlTimeCalculatorSub = new System.Windows.Forms.Panel();
            this.btnWorkComplete = new System.Windows.Forms.Button();
            this.btnWorkSimple = new System.Windows.Forms.Button();
            this.btnWorkMenu = new System.Windows.Forms.Button();
            this.pnlMailSub = new System.Windows.Forms.Panel();
            this.btnHotmail = new System.Windows.Forms.Button();
            this.btnBluewin = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnMailMenu = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            this.pnlMenuPlanSub.SuspendLayout();
            this.pnlTimeCalculatorSub.SuspendLayout();
            this.pnlMailSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.AutoScroll = true;
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.pnlMainMenu.Controls.Add(this.pnlMenuPlanSub);
            this.pnlMainMenu.Controls.Add(this.btnPlanMenu);
            this.pnlMainMenu.Controls.Add(this.pnlTimeCalculatorSub);
            this.pnlMainMenu.Controls.Add(this.btnWorkMenu);
            this.pnlMainMenu.Controls.Add(this.pnlMailSub);
            this.pnlMainMenu.Controls.Add(this.btnMailMenu);
            this.pnlMainMenu.Controls.Add(this.pnlFill);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(269, 774);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // pnlMenuPlanSub
            // 
            this.pnlMenuPlanSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlMenuPlanSub.Controls.Add(this.btnPlanCustom);
            this.pnlMenuPlanSub.Controls.Add(this.btnPlanToday);
            this.pnlMenuPlanSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuPlanSub.Location = new System.Drawing.Point(0, 392);
            this.pnlMenuPlanSub.Name = "pnlMenuPlanSub";
            this.pnlMenuPlanSub.Size = new System.Drawing.Size(269, 80);
            this.pnlMenuPlanSub.TabIndex = 6;
            // 
            // btnPlanCustom
            // 
            this.btnPlanCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanCustom.FlatAppearance.BorderSize = 0;
            this.btnPlanCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanCustom.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlanCustom.Location = new System.Drawing.Point(0, 40);
            this.btnPlanCustom.Name = "btnPlanCustom";
            this.btnPlanCustom.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPlanCustom.Size = new System.Drawing.Size(269, 40);
            this.btnPlanCustom.TabIndex = 1;
            this.btnPlanCustom.Text = "Menuplan nach Datum";
            this.btnPlanCustom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanCustom.UseVisualStyleBackColor = true;
            this.btnPlanCustom.Click += new System.EventHandler(this.BtnPlanCustom_Click);
            // 
            // btnPlanToday
            // 
            this.btnPlanToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanToday.FlatAppearance.BorderSize = 0;
            this.btnPlanToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanToday.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlanToday.Location = new System.Drawing.Point(0, 0);
            this.btnPlanToday.Name = "btnPlanToday";
            this.btnPlanToday.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPlanToday.Size = new System.Drawing.Size(269, 40);
            this.btnPlanToday.TabIndex = 0;
            this.btnPlanToday.Text = "Menuplan von dieser Woche";
            this.btnPlanToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanToday.UseVisualStyleBackColor = true;
            this.btnPlanToday.Click += new System.EventHandler(this.BtnPlanToday_Click);
            // 
            // btnPlanMenu
            // 
            this.btnPlanMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanMenu.FlatAppearance.BorderSize = 0;
            this.btnPlanMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlanMenu.Location = new System.Drawing.Point(0, 347);
            this.btnPlanMenu.Name = "btnPlanMenu";
            this.btnPlanMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlanMenu.Size = new System.Drawing.Size(269, 45);
            this.btnPlanMenu.TabIndex = 5;
            this.btnPlanMenu.Text = "Acherli Menuplan";
            this.btnPlanMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanMenu.UseVisualStyleBackColor = true;
            this.btnPlanMenu.Click += new System.EventHandler(this.BtnPlanMenu_Click);
            // 
            // pnlTimeCalculatorSub
            // 
            this.pnlTimeCalculatorSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlTimeCalculatorSub.Controls.Add(this.btnWorkComplete);
            this.pnlTimeCalculatorSub.Controls.Add(this.btnWorkSimple);
            this.pnlTimeCalculatorSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimeCalculatorSub.Location = new System.Drawing.Point(0, 267);
            this.pnlTimeCalculatorSub.Name = "pnlTimeCalculatorSub";
            this.pnlTimeCalculatorSub.Size = new System.Drawing.Size(269, 80);
            this.pnlTimeCalculatorSub.TabIndex = 4;
            // 
            // btnWorkComplete
            // 
            this.btnWorkComplete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkComplete.FlatAppearance.BorderSize = 0;
            this.btnWorkComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkComplete.ForeColor = System.Drawing.Color.LightGray;
            this.btnWorkComplete.Location = new System.Drawing.Point(0, 40);
            this.btnWorkComplete.Name = "btnWorkComplete";
            this.btnWorkComplete.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnWorkComplete.Size = new System.Drawing.Size(269, 40);
            this.btnWorkComplete.TabIndex = 1;
            this.btnWorkComplete.Text = "Vollständig";
            this.btnWorkComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkComplete.UseVisualStyleBackColor = true;
            this.btnWorkComplete.Click += new System.EventHandler(this.BtnWorkComplete_Click);
            // 
            // btnWorkSimple
            // 
            this.btnWorkSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkSimple.FlatAppearance.BorderSize = 0;
            this.btnWorkSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkSimple.ForeColor = System.Drawing.Color.LightGray;
            this.btnWorkSimple.Location = new System.Drawing.Point(0, 0);
            this.btnWorkSimple.Name = "btnWorkSimple";
            this.btnWorkSimple.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnWorkSimple.Size = new System.Drawing.Size(269, 40);
            this.btnWorkSimple.TabIndex = 0;
            this.btnWorkSimple.Text = "Einfach";
            this.btnWorkSimple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkSimple.UseVisualStyleBackColor = true;
            this.btnWorkSimple.Click += new System.EventHandler(this.BtnWorkSimple_Click);
            // 
            // btnWorkMenu
            // 
            this.btnWorkMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkMenu.FlatAppearance.BorderSize = 0;
            this.btnWorkMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWorkMenu.Location = new System.Drawing.Point(0, 222);
            this.btnWorkMenu.Name = "btnWorkMenu";
            this.btnWorkMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWorkMenu.Size = new System.Drawing.Size(269, 45);
            this.btnWorkMenu.TabIndex = 3;
            this.btnWorkMenu.Text = "Arbeitszeitrechner";
            this.btnWorkMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkMenu.UseVisualStyleBackColor = true;
            this.btnWorkMenu.Click += new System.EventHandler(this.BtnWorkMenu_Click);
            // 
            // pnlMailSub
            // 
            this.pnlMailSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlMailSub.Controls.Add(this.btnHotmail);
            this.pnlMailSub.Controls.Add(this.btnBluewin);
            this.pnlMailSub.Controls.Add(this.btnGmail);
            this.pnlMailSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMailSub.Location = new System.Drawing.Point(0, 102);
            this.pnlMailSub.Name = "pnlMailSub";
            this.pnlMailSub.Size = new System.Drawing.Size(269, 120);
            this.pnlMailSub.TabIndex = 2;
            // 
            // btnHotmail
            // 
            this.btnHotmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHotmail.FlatAppearance.BorderSize = 0;
            this.btnHotmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotmail.ForeColor = System.Drawing.Color.LightGray;
            this.btnHotmail.Location = new System.Drawing.Point(0, 80);
            this.btnHotmail.Name = "btnHotmail";
            this.btnHotmail.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHotmail.Size = new System.Drawing.Size(269, 40);
            this.btnHotmail.TabIndex = 2;
            this.btnHotmail.Text = "Hotmail";
            this.btnHotmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotmail.UseVisualStyleBackColor = true;
            this.btnHotmail.Click += new System.EventHandler(this.BtnHotmail_Click);
            // 
            // btnBluewin
            // 
            this.btnBluewin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBluewin.FlatAppearance.BorderSize = 0;
            this.btnBluewin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBluewin.ForeColor = System.Drawing.Color.LightGray;
            this.btnBluewin.Location = new System.Drawing.Point(0, 40);
            this.btnBluewin.Name = "btnBluewin";
            this.btnBluewin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBluewin.Size = new System.Drawing.Size(269, 40);
            this.btnBluewin.TabIndex = 1;
            this.btnBluewin.Text = "Bluewin";
            this.btnBluewin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBluewin.UseVisualStyleBackColor = true;
            this.btnBluewin.Click += new System.EventHandler(this.BtnBluewin_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGmail.FlatAppearance.BorderSize = 0;
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.ForeColor = System.Drawing.Color.LightGray;
            this.btnGmail.Location = new System.Drawing.Point(0, 0);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGmail.Size = new System.Drawing.Size(269, 40);
            this.btnGmail.TabIndex = 0;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.BtnGmail_Click);
            // 
            // btnMailMenu
            // 
            this.btnMailMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailMenu.FlatAppearance.BorderSize = 0;
            this.btnMailMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMailMenu.Location = new System.Drawing.Point(0, 57);
            this.btnMailMenu.Name = "btnMailMenu";
            this.btnMailMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMailMenu.Size = new System.Drawing.Size(269, 45);
            this.btnMailMenu.TabIndex = 1;
            this.btnMailMenu.Text = "E-Mail";
            this.btnMailMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailMenu.UseVisualStyleBackColor = true;
            this.btnMailMenu.Click += new System.EventHandler(this.BtnMailMenu_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(269, 57);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(269, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(995, 774);
            this.pnlChildForm.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 774);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "FrmMain";
            this.Text = "Menu";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMenuPlanSub.ResumeLayout(false);
            this.pnlTimeCalculatorSub.ResumeLayout(false);
            this.pnlMailSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlMenuPlanSub;
        private System.Windows.Forms.Button btnPlanCustom;
        private System.Windows.Forms.Button btnPlanToday;
        private System.Windows.Forms.Button btnPlanMenu;
        private System.Windows.Forms.Panel pnlTimeCalculatorSub;
        private System.Windows.Forms.Button btnWorkComplete;
        private System.Windows.Forms.Button btnWorkSimple;
        private System.Windows.Forms.Button btnWorkMenu;
        private System.Windows.Forms.Panel pnlMailSub;
        private System.Windows.Forms.Button btnHotmail;
        private System.Windows.Forms.Button btnBluewin;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnMailMenu;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}