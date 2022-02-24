using System;

namespace ShiftApi
{
    public class ShiftService
    {
        public static TimeSpan getTimeSpan(DateTime start, DateTime end)
        {

            TimeSpan duration = end.Subtract(start);
            

            return duration;
        }

    }
}
