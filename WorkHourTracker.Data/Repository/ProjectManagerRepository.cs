using System;
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

        public async Task AssignProject(AssignProjectToEmployeeDatabaseInput input)
        {
            var p = new DynamicParameters();
            p.Add("@p_AssignedEmployeeUserName", input.AssignedUserName);
            p.Add("@p_AssignedProjectName", input.AssignedProjectName);
            p.Add("@p_CreateUser", input.CreateUser);

            var validUserNameAndProject = new DynamicParameters();
            p.Add("@p_UserName", input.AssignedUserName);
            p.Add("@p_ProjectName", input.AssignedProjectName);

            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                bool isValid = false;

                isValid = await connection.QueryFirstAsync<bool>("sp_IsAssignAProjectInputValid", p, commandType: CommandType.StoredProcedure);

                if (!isValid)
                {

                }

                await connection.ExecuteAsync("sp_AssignProjectToEmployee", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
