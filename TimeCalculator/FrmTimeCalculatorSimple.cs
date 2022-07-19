using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;
using ProjectCollection.Logging;
using FluentValidation.Results;
using FluentValidation;
using System.Collections.Generic;
using System.Drawing;

namespace ProjectCollection.TimeCalculator
{
    public partial class FrmTimeCalculatorSimple : Form
    {
#pragma warning disable IDE0052
        private readonly DateTime workHours = Convert.ToDateTime("08:06");
        private DateTime start;
        private DateTime end;
        private readonly ILogger _logger;
        private readonly ICreateLogging _createLogging;
        private readonly ICalculateSimpleTimes _calculateTimes;
        private ValidationResult result;
        private Time times;
#pragma warning restore IDE0052
        public FrmTimeCalculatorSimple(ILogger<FrmTimeCalculatorSimple> logger, ICreateLogging createLogging, ICalculateSimpleTimes calcualteTimes)
        {
            InitializeComponent();
            _logger = logger;
            _createLogging = createLogging;
            _calculateTimes = calcualteTimes;
            times = new Time();
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
        /// Clears all TextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnClear_Click(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }

        /// <summary>
        /// Calculates the total time worked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            SetBackColor();
            AssignTimes(txtStart.Text, txtLunch.Text, txtEnd.Text);
            lblError.Visible = false;
            lblError.Text = "";
            ValidateTimeCalculator validator = new ValidateTimeCalculator();
            result = validator.Validate(times);
            if (!result.IsValid)
            {
                foreach(var failure in result.Errors)
                {
                    ShowError(failure.PropertyName);
                    lblError.Text += failure.ErrorCode + System.Environment.NewLine;
                    _createLogging.CreateCustomLogs(failure.ErrorCode, "Error");
                }
                lblError.Visible = true;
            }
            else
            {
                ConvertTimesToDateTime(times.Start, times.End);
                txtTotal.Text = _calculateTimes.CalculateWorkTime(start, end, times.Lunch);
                CalculateOverTime();
            }
        }
        /// <summary>
        /// Converts strings from starting and ending time to Datetimes
        /// </summary>
        /// <param name="start">starting time from textbox</param>
        /// <param name="end">ending time from textbox</param>
        public void ConvertTimesToDateTime(string start, string end)
        {
            (this.start,this.end) = _calculateTimes.ConvertToDateTime(start, end);
        } 
        /// <summary>
        /// Calculates over or undertime for the day
        /// </summary>
        /// <param name="today">timespan of time worked</param>
        /// <param name="workHours">total workhours</param>
        public void CalculateOverTime()
        {
            txtOverTime.Text = _calculateTimes.CalculateOverTime(txtTotal.Text, workHours);
        }

        public void AssignTimes(string start, string lunch, string end)
        {
            times.Start = start;
            times.Lunch = lunch;
            times.End = end;
        }
        public void ShowError(string textBox)
        {
            switch (textBox)
            {
                case "Start":
                    txtStart.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case "Lunch":
                    txtLunch.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case "End":
                    txtEnd.BackColor = System.Drawing.Color.DarkRed;
                    break;
            }
        }
        public void SetBackColor()
        {
            txtStart.BackColor = Color.FromArgb(204, 204, 204);
            txtLunch.BackColor = Color.FromArgb(204, 204, 204);
            txtEnd.BackColor = Color.FromArgb(204, 204, 204);
        }
    }
}
