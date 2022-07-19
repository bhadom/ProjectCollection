using System;

namespace ProjectCollection.TimeCalculator
{
    public interface ICalculateCompleteTimes
    {
        public string CalculateOverTime(string workTime, DateTime workHours, bool selected, DateTime currentOverTime);
    }
}
