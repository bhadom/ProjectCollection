using Microsoft.Extensions.Logging;
using ProjectCollection.MenuPlan;
using ProjectCollection.TimeCalculator;
using ProjectCollection.Logging;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProjectCollection
{
    /// <summary>
    /// This class shows the Menu and Layout of the Program
    /// </summary>
    public partial class FrmMain : Form
    {
    #pragma warning disable 0649
        private Form activeForm = null;
        private readonly ILogger<FrmClient> _logger;
        private readonly ILogger<FrmTimeCalculatorComplete> _timeCalcCompleteLogger;
        private readonly ILogger<FrmTimeCalculatorSimple> _timeCalcSimpleLogger;
        private readonly ICalculateSimpleTimes _calculateTimes;
        private readonly ICalculateWorkHours _calculateWorkHours;
        private readonly ICalculateCompleteTimes _calculateCompleteTimes;
        private readonly ICreateMail _createMail;
        private readonly ICreateLogging _createLogging;
        private Time _times;
#pragma warning restore 0649

        /// <summary>
        /// Initializes every Element in the Form and calls the Method to set the DropDown menu
        /// </summary>
        /// <param name="createMail">Takes ICreateMail Interface parameter</param>
        public FrmMain(ICreateMail createMail, ICreateLogging createLogging, ICalculateSimpleTimes calculateTimes, ICalculateWorkHours calculateWorkHours, ICalculateCompleteTimes calculateCompleteTimes, Time times)
        {
            InitializeComponent();
            _createMail = createMail;
            _createLogging = createLogging;
            _calculateTimes = calculateTimes;
            _calculateWorkHours = calculateWorkHours;
            _calculateCompleteTimes = calculateCompleteTimes;
            _times = times;
            CustomizeDesign();
        }

        /// <summary>
        /// Hides every Submenu on the Menubar
        /// </summary>
        private void CustomizeDesign()
        {
            pnlMailSub.Visible = false;
            pnlMenuPlanSub.Visible = false;
            pnlTimeCalculatorSub.Visible = false;
        }

        /// <summary>
        /// Hides the Submenu if its currently shown
        /// </summary>
        private void HideSubMenu()
        {
            if (pnlMailSub.Visible) { pnlMailSub.Visible = false; };
            if (pnlMenuPlanSub.Visible) { pnlMenuPlanSub.Visible = false; };
            if (pnlTimeCalculatorSub.Visible) { pnlTimeCalculatorSub.Visible = false; };


        }

        /// <summary>
        /// Shows the submenu when its currently hidden
        /// </summary>
        /// <param name="subMenu">Submenu of the clicked Button</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Mail Menu
        /// <summary>
        /// Shows the submenu for the Mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMailMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMailSub);
        }

        /// <summary>
        /// Opens the Gmail Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGmail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClient(_logger, _createMail));

            HideSubMenu();
        }

        /// <summary>
        /// Opens the Bluewin form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBluewin_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        /// <summary>
        /// Opens the Hotmail form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHotmail_Click(object sender, EventArgs e)
        {


            HideSubMenu();
        }
        #endregion

        #region TimeCalculator Menu
        /// <summary>
        /// Expands the submenu of the Timecalculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWorkMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlTimeCalculatorSub);
        }

        /// <summary>
        /// Opens the Timecalculator form which doesnt take Workload and over/undertime into account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWorkSimple_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTimeCalculatorSimple(_timeCalcSimpleLogger, _createLogging, _calculateTimes));

            HideSubMenu();
        }
        /// <summary>
        /// Opens the Timecalculator form which takes everything into account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWorkComplete_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTimeCalculatorComplete(_timeCalcCompleteLogger, _createLogging, _calculateTimes, _calculateWorkHours, _calculateCompleteTimes));

            HideSubMenu();
        }

        #endregion

        #region MenuPlan Menu
        /// <summary>
        /// Expands the Menuplan Submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlanMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMenuPlanSub);
        }

        /// <summary>
        /// Opens the Form to show this weeks Menuplan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlanToday_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMenuPlan());

            HideSubMenu();
        }

        /// <summary>
        /// Opens the form to show a menuplan from a userinput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlanCustom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCustomMenuPlan());

            HideSubMenu();
        }
        #endregion

        /// <summary>
        /// Opens the newly selected form and fits it into the panel. If any form was open before it, it will discard it
        /// </summary>
        /// <param name="childForm">Form to open</param>
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
