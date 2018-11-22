using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHourTracker.Model.Entities
{
   public class ProjectSearchDatabaseOutput
    {
        public string ProjectName { get; set; }
        public string ProjectCodeName { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string CsvIndividualsOnProject { get; set; }
        public string GrandTotalHoursWorkedOnProject { get; set; }

        //Convert the DateTime from the database to Short Date Format
        public string ShortDate => Convert.ToDateTime(CreateDate).ToShortDateString();
    }
}
