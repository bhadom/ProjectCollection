using System;

namespace ProjectCollection.TimeCalculator
{
    class CalculateWorkHours : ICalculateWorkHours
    {
        /// <summary>
        /// Calculates the block times according to the given workload
        /// </summary>
        /// <param name="workLoad">Workload in percent</param>
        /// <param name="workHours">Workhours for 100%</param>
        /// <returns>Returns the new block times</returns>
        public DateTime CalculateNewWorkHours(double workLoad, DateTime workHours)
        {
            double hours = workHours.Hour;
            double minutes = workHours.Minute;
            minutes = (hours * 60) + minutes;
            double newWorkMinutes = (minutes / 100) * workLoad;
            DateTime newWorkHours = DateTime.Now.Date;
            newWorkHours = newWorkHours.AddMinutes(newWorkMinutes);

            return newWorkHours;
        }
    }
}
