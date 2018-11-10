using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkHourTracker.Web.Models
{
    public class AssignProject
    {
        [Required]
        [MaxLength(50)]
        public string AssignedUserName { get; set; }

        [Required]
        [MaxLength(20)]
        public string AssignedProjectName { get; set; }
    }
}
