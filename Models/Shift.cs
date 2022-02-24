using System;

namespace ShiftApi
{
    public class Shift
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public decimal HourlyRate { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
        public TimeSpan HoursWorked { get; set; }
        public decimal ShiftEarnings { get; set; }
    }
}
