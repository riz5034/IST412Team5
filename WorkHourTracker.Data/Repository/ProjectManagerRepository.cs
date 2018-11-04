﻿using System;
using System.Collections.Generic;
using System.Text;
using WorkHourTracker.Data.Interfaces;
using WorkHourTracker.Model.Entities;
using WorkHourTracker.Model.Exceptions;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace WorkHourTracker.Data.Repository
{
   public class ProjectManagerRepository : IProjectManagerRepository
    {
        //the connection string to the Azure Database.
        //It is readonly as we do not want it to change once set
        private readonly string _connectionString = @"Server=tcp:workhourtracker412.database.windows.net,1433;Initial Catalog=WorkHourTrackerDatabase;Persist Security Info=False;User ID=IST412WHTAdmin;Password=Team5WHT412;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public async Task CreateNewProject(CreateProjectDatabaseInput input)
        {
            var p = new DynamicParameters();
            p.Add("@p_ProjectGuid", input.ProjectGuid);
            p.Add("@p_ProjectName", input.ProjectName);
            p.Add("@p_ProjectCodeName", input.ProjectCodeName);
            p.Add("@p_CreateDate", input.CreateDate);
            p.Add("@p_CreateUser", input.CreateUser);

            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("sp_CreateProject", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
