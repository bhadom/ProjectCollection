using System;

namespace ProjectCollection.TimeCalculator
{   
    class CalculateTimes : ICalculateSimpleTimes
    {
        private DateTime start;
        private DateTime end;
        private TimeSpan workTime;

        /// <summary>
        /// Calculates the time worked today
        /// </summary>
        /// <param name="start">Starting time</param>
        /// <param name="end">Ending time</param>
        /// <param name="lunch">Lunch in minutes</param>
        /// <returns></returns>
        public string CalculateWorkTime(DateTime start, DateTime end, string lunch)
        {
            TimeSpan totalWorkTime = end - start;
            totalWorkTime = totalWorkTime.Subtract(TimeSpan.FromMinutes(Convert.ToDouble(lunch)));
            return Convert.ToString(totalWorkTime);
        }
        /// <summary>
        /// Converts the strings from the textboxes to datetimes.
        /// </summary>
        /// <param name="start">starting time string</param>
        /// <param name="end">ending time string</param>
        /// <returns>starting time and ending time in datetime</returns>
        public (DateTime, DateTime) ConvertToDateTime(string start, string end)
        {
            this.start = Convert.ToDateTime(start);
            this.end = Convert.ToDateTime(end);
            return (this.start, this.end);
        }
        /// <summary>
        /// Calculates the overtime/undertime of today
        /// </summary>
        /// <param name="workTime">Time worked today</param>
        /// <param name="workHours">Block times</param>
        /// <returns></returns>
        public string CalculateOverTime(string workTime, DateTime workHours)
        {
            this.workTime = Convert.ToDateTime(workTime) - workHours;
            return Convert.ToString(this.workTime);
        }
    }
}