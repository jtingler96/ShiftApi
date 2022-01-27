using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftApi
{
    public class ShiftService
    {
        public static TimeSpan getTimeSpan(DateTime start, DateTime end)
        {

            TimeSpan duration = end.Subtract(start).to;
            

            return duration;
        }

    }
}
