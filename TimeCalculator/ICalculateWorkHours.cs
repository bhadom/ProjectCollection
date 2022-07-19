using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCollection.TimeCalculator
{
    public interface ICalculateWorkHours
    {
        public DateTime CalculateNewWorkHours(double workLoad, DateTime workHours);
    }
}
