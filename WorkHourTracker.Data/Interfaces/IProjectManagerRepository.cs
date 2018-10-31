﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkHourTracker.Model.Entities;

namespace WorkHourTracker.Data.Interfaces
{
   public interface IProjectManagerRepository
    {
        Task CreateNewProject(CreateProjectDatabaseInput input);
    }
}
