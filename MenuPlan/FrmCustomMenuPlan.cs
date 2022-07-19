using System;
using System.Windows.Forms;

namespace ProjectCollection.MenuPlan
{
    /// <summary>
    /// Calls the MenuPlan according to the picked date
    /// </summary>
    public partial class FrmCustomMenuPlan : Form
    {
        readonly MenuPlanLogic logic;
        DateTime customDateTime = DateTime.Now;
        /// <summary>
        /// Starts the Form, creats the elements and calls MenuPlanLogic class
        /// </summary>
        public FrmCustomMenuPlan()
        {
            InitializeComponent();
            logic = new MenuPlanLogic(wvPage);
            logic.CalculateCalendarWeek(customDateTime);
        }
        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// When the user changes the Date, update the variable and call MenuPlanLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            customDateTime = dtpDate.Value;
            logic.CalculateCalendarWeek(customDateTime);
        }
    }
}
