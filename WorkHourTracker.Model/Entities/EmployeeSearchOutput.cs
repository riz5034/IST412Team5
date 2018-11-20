using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHourTracker.Model.Entities
{
    public class EmployeeSearchOutput
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeUserName { get; set; }
        public string CsvAssignedProjects { get; set; }
        public string CapacityPerProject { get; set; }
        public string HoursWorkedPerProject { get; set; }
    }
}
