using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCollection.TimeCalculator
{
    public interface ICalculateSimpleTimes
    {
        public string CalculateWorkTime(DateTime start, DateTime end, string lunch);
        public (DateTime, DateTime) ConvertToDateTime(string start, string end);
        public string CalculateOverTime(string workTime, DateTime workHours);
    }
}
