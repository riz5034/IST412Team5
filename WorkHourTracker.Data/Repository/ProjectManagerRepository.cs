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
            p.Add("@p_Capacity", input.Capacity);
            p.Add("@p_CreateUser", input.CreateUser);

            var validUserNameAndProject = new DynamicParameters();
            validUserNameAndProject.Add("@p_UserName", input.AssignedUserName);
            validUserNameAndProject.Add("@p_ProjectName", input.AssignedProjectName);


            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                bool isValid = false;

                isValid = await connection.QueryFirstAsync<bool>("sp_IsAssignAProjectInputValid", validUserNameAndProject, commandType: CommandType.StoredProcedure);

                if (!isValid)
                {
                    throw new AssignAProjectException("Either the UserName or ProjectName you entered is invalid. Please try again");
                }

                await connection.ExecuteAsync("sp_AssignProjectToEmployee", p, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<EmployeeSearchOutput> GetEmployeeSearch(EmployeeSearchDatabaseInput input)
        {
            //create the DyanmicParamter object to hold our input for the sproc
            var p = new DynamicParameters();

            //Add the sproc input params to p
            p.Add("@p_UserName", input.SearchedEmployeeUserName);

            //define your result outside of the using block
            EmployeeSearchOutput result;

            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                //using Dapper execute the "sp_EmployeeSearch" sproc
                result = await connection.QueryFirstAsync<EmployeeSearchOutput>("sp_EmployeeSearch", p, commandType: CommandType.StoredProcedure);
            }

            //return the sproc result
            return result;
        }
    }
}
