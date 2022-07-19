using Microsoft.Extensions.Logging;
using ProjectCollection.Logging;
using System;
using System.Windows.Forms;

namespace ProjectCollection.TimeCalculator
{
    public partial class FrmTimeCalculatorComplete : Form
    {
#pragma warning disable IDE0052
        private readonly DateTime workHours = Convert.ToDateTime("08:06");
        private DateTime start;
        private DateTime end;
        private readonly ILogger _logger;
        private readonly ICreateLogging _createLogging;
        private readonly ICalculateSimpleTimes _calculateTimes;
        private readonly ICalculateWorkHours _calculateWorkHours;
        private readonly ICalculateCompleteTimes _calculateCompleteTimes;
#pragma warning restore IDE0052
        public FrmTimeCalculatorComplete(ILogger<FrmTimeCalculatorComplete> logger, ICreateLogging createLogging, ICalculateSimpleTimes calculateTimes, ICalculateWorkHours calculateWorkHours, ICalculateCompleteTimes calculateCompleteTimes)
        {
            InitializeComponent();
            _logger = logger;
            _createLogging = createLogging;
            _calculateTimes = calculateTimes;
            _calculateWorkHours = calculateWorkHours;
            _calculateCompleteTimes = calculateCompleteTimes;
        }
        /// <summary>
        /// Clears all TextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }
        /// <summary>
        /// Closes the current Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Converts strings from starting and ending time to Datetimes
        /// </summary>
        /// <param name="start">starting time from textbox</param>
        /// <param name="end">ending time from textbox</param>
        public void ConvertToDateTime(string start, string end)
        {
            (this.start, this.end) = _calculateTimes.ConvertToDateTime(start, end);
        }
        /// <summary>
        /// Calculates the total time worked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            try
            {
                ConvertToDateTime(txtStart.Text, txtEnd.Text);
                txtTotal.Text = _calculateTimes.CalculateWorkTime(start, end, txtLunch.Text);
                CalculateWorkHours(Convert.ToDouble(txtWorkLoad.Text));
                _createLogging.CreateCustomLogs("Calculation complete", "Information");
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                _createLogging.CreateLogs(ex);
            }
        }
        /// <summary>
        /// Calculates the new over/undertime based on given workLoad
        /// </summary>
        /// <param name="workLoad">Workload given by the user</param>
        public void CalculateWorkHours(double workLoad)
        {
            DateTime newWorkHours =_calculateWorkHours.CalculateNewWorkHours(workLoad, workHours);
            CalculateOverTime(newWorkHours);
        }
        /// <summary>
        /// Calculates over or undertime for the day
        /// </summary>
        /// <param name="today">timespan of time worked</param>
        /// <param name="workHours">total workhours</param>
        public void CalculateOverTime(DateTime workHours)
        {
            txtOverTime.Text = _calculateTimes.CalculateOverTime(txtTotal.Text, workHours);
            txtNewOverTime.Text = _calculateCompleteTimes.CalculateOverTime(txtTotal.Text, workHours, rbYes.Checked, Convert.ToDateTime(txtCurrentOverTime.Text));
        }

    }
}
