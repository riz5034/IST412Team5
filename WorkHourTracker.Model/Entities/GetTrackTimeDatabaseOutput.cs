using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHourTracker.Model.Entities
{
   public class GetTrackTimeDatabaseOutput
    {
        public string ProjectName { get; set; }

        public int HourSun { get; set; }
        public int HourMon { get; set; }
        public int HourTues { get; set; }
        public int HourWed { get; set; }
        public int HourThurs { get; set; }
        public int HourFri { get; set; }
        public int HourSat { get; set; }

        public string Comments { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
