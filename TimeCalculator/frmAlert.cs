using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectCollection.TimeCalculator
{
    public partial class frmAlert : Form
    {
        private int x, y;
        private frmAlert.enmAction action;
        public frmAlert()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            start,
            close,
            wait
        }

        public enum enmType
        {
            Info,
            Success,
            Warning,
            Error
        }
        // Form gets shown, this is for closing the alert, Form_Alert 91/115
        private void pbAlert_Click(object sender, EventArgs e)
        {
            tmrAlert.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert()
        {

        }
        private void tmrAlert_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    tmrAlert.Interval = 5000;
                    action = enmAction.close;
                    break;
                case frmAlert.enmAction.start:
                    this.tmrAlert.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = frmAlert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    tmrAlert.Interval = 1;
                    tmrAlert.Interval = 250;
                    this.Opacity -= 0.1;

                    //this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }



        
    }
}
