using System;
using Xunit;
using WorkHourTracker.Data.Repository;
using WorkHourTracker.Model.Entities;
using System.Threading.Tasks;

namespace WorkHourTracker.Data.Test
{
  public class ProjectManagerRepositoryTest
    {
        private readonly ProjectManagerRepository _projectManagerRepository;

        public ProjectManagerRepositoryTest()
        {
            _projectManagerRepository = new ProjectManagerRepository();
        }

        [Fact]
        public async Task CreateNewProject_Success()
        {
            //Arrange
            var input = new CreateProjectDatabaseInput("Project X", "X", "AVandelay");

            //Act
            await _projectManagerRepository.CreateNewProject(input);
            //Assert
        }
    }
}
