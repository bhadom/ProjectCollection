
namespace ProjectCollection.TimeCalculator
{
    partial class FrmTimeCalculatorComplete
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
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.lblOverTime = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.lblLunch = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtWorkLoad = new System.Windows.Forms.TextBox();
            this.lblWorkLoad = new System.Windows.Forms.Label();
            this.txtCurrentOverTime = new System.Windows.Forms.TextBox();
            this.lblCurrentOverTime = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewOverTime = new System.Windows.Forms.TextBox();
            this.lblNewOverTime = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOverTime
            // 
            this.txtOverTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOverTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOverTime.Enabled = false;
            this.txtOverTime.Location = new System.Drawing.Point(230, 404);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(100, 16);
            this.txtOverTime.TabIndex = 9;
            // 
            // lblOverTime
            // 
            this.lblOverTime.AutoSize = true;
            this.lblOverTime.Location = new System.Drawing.Point(34, 404);
            this.lblOverTime.Name = "lblOverTime";
            this.lblOverTime.Size = new System.Drawing.Size(84, 15);
            this.lblOverTime.TabIndex = 36;
            this.lblOverTime.Text = "Über/Unterzeit";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(230, 366);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 16);
            this.txtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(34, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 15);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Totale Arbeitszeit";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(848, 675);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 34);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(34, 675);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Felder leeren";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnd.Location = new System.Drawing.Point(230, 283);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 16);
            this.txtEnd.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(34, 283);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(82, 15);
            this.lblEnd.TabIndex = 33;
            this.lblEnd.Text = "Arbeitsschluss";
            // 
            // txtLunch
            // 
            this.txtLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLunch.Location = new System.Drawing.Point(230, 232);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(100, 16);
            this.txtLunch.TabIndex = 6;
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(34, 232);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(139, 15);
            this.lblLunch.TabIndex = 32;
            this.lblLunch.Text = "Mittagspause in Minuten";
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStart.Location = new System.Drawing.Point(230, 176);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 16);
            this.txtStart.TabIndex = 5;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(34, 176);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(81, 15);
            this.lblStart.TabIndex = 31;
            this.lblStart.Text = "Arbeitsbeginn";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(848, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 34);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtWorkLoad
            // 
            this.txtWorkLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtWorkLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkLoad.Location = new System.Drawing.Point(230, 36);
            this.txtWorkLoad.Name = "txtWorkLoad";
            this.txtWorkLoad.Size = new System.Drawing.Size(100, 16);
            this.txtWorkLoad.TabIndex = 1;
            // 
            // lblWorkLoad
            // 
            this.lblWorkLoad.AutoSize = true;
            this.lblWorkLoad.Location = new System.Drawing.Point(34, 36);
            this.lblWorkLoad.Name = "lblWorkLoad";
            this.lblWorkLoad.Size = new System.Drawing.Size(143, 15);
            this.lblWorkLoad.TabIndex = 38;
            this.lblWorkLoad.Text = "Arbeitspensum in Prozent";
            // 
            // txtCurrentOverTime
            // 
            this.txtCurrentOverTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCurrentOverTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentOverTime.Location = new System.Drawing.Point(230, 69);
            this.txtCurrentOverTime.Name = "txtCurrentOverTime";
            this.txtCurrentOverTime.Size = new System.Drawing.Size(100, 16);
            this.txtCurrentOverTime.TabIndex = 2;
            // 
            // lblCurrentOverTime
            // 
            this.lblCurrentOverTime.AutoSize = true;
            this.lblCurrentOverTime.Location = new System.Drawing.Point(34, 69);
            this.lblCurrentOverTime.Name = "lblCurrentOverTime";
            this.lblCurrentOverTime.Size = new System.Drawing.Size(130, 15);
            this.lblCurrentOverTime.TabIndex = 40;
            this.lblCurrentOverTime.Text = "Aktuelle Über/Unterzeit";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(230, 101);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(35, 19);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Ja";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(280, 101);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 19);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Nein";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ist die angegebene Zeit Überzeit?";
            // 
            // txtNewOverTime
            // 
            this.txtNewOverTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewOverTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewOverTime.Enabled = false;
            this.txtNewOverTime.Location = new System.Drawing.Point(230, 468);
            this.txtNewOverTime.Name = "txtNewOverTime";
            this.txtNewOverTime.Size = new System.Drawing.Size(100, 16);
            this.txtNewOverTime.TabIndex = 10;
            // 
            // lblNewOverTime
            // 
            this.lblNewOverTime.AutoSize = true;
            this.lblNewOverTime.Location = new System.Drawing.Point(34, 468);
            this.lblNewOverTime.Name = "lblNewOverTime";
            this.lblNewOverTime.Size = new System.Drawing.Size(115, 15);
            this.lblNewOverTime.TabIndex = 45;
            this.lblNewOverTime.Text = "Neue Über/Unterzeit";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(34, 548);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(309, 30);
            this.lblError.TabIndex = 51;
            this.lblError.Text = "Bitte gültige Zeiten eintragen.";
            this.lblError.Visible = false;
            // 
            // FrmTimeCalculatorComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(979, 735);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNewOverTime);
            this.Controls.Add(this.lblNewOverTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.txtCurrentOverTime);
            this.Controls.Add(this.lblCurrentOverTime);
            this.Controls.Add(this.txtWorkLoad);
            this.Controls.Add(this.lblWorkLoad);
            this.Controls.Add(this.txtOverTime);
            this.Controls.Add(this.lblOverTime);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtLunch);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimeCalculatorComplete";
            this.Text = "FrmTimeCalculatorComplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOverTime;
        private System.Windows.Forms.Label lblOverTime;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtWorkLoad;
        private System.Windows.Forms.Label lblWorkLoad;
        private System.Windows.Forms.TextBox txtCurrentOverTime;
        private System.Windows.Forms.Label lblCurrentOverTime;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewOverTime;
        private System.Windows.Forms.Label lblNewOverTime;
        private System.Windows.Forms.Label lblError;
    }
}