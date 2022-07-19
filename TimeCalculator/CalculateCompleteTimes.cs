using System;

namespace ProjectCollection.TimeCalculator
{
    class CalculateCompleteTimes : ICalculateCompleteTimes
    {
        private TimeSpan newOverTime;
        /// <summary>
        /// Calculates the overtime according to the given parameters
        /// </summary>
        /// <param name="workTime">How much was worked</param>
        /// <param name="workHours">How long should have been worked</param>
        /// <param name="selected">Is it overtime or undertime</param>
        /// <param name="currentOverTime">Current overtime/undertime</param>
        /// <returns>Returns new overtime/undertime</returns>
        public string CalculateOverTime(string workTime, DateTime workHours, bool selected, DateTime currentOverTime)
        {
            if (selected)
            {
                newOverTime = currentOverTime.TimeOfDay + (Convert.ToDateTime(workTime) - workHours);
            }
            else
            {
                newOverTime = currentOverTime.TimeOfDay - (Convert.ToDateTime(workTime) - workHours);
            }
            return Convert.ToString(newOverTime);
        }
    }
}
