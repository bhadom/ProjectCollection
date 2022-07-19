using System;
using System.Windows.Forms;

namespace ProjectCollection.MenuPlan
{
    public partial class FrmMenuPlan : Form
    {
        readonly MenuPlanLogic logic;
        /// <summary>
        /// Initializes elements and calls MenuPlanLogic class
        /// </summary>
        public FrmMenuPlan()
        {
            InitializeComponent();
            logic = new MenuPlanLogic(wvPage);
            logic.CalculateCalendarWeek(DateTime.Now);
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
    }
}
