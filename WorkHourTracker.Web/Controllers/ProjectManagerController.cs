using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkHourTracker.Web.Models;
using WorkHourTracker.Web.Infrastructure;
using WorkHourTracker.Model.Entities;
using WorkHourTracker.Domain.Interfaces;
using WorkHourTracker.Domain.Domains;

namespace WorkHourTracker.Web.Controllers
{
    public class ProjectManagerController : Controller
    {
        private readonly IProjectManagerDomain _IProjectManagerDomain;

        public ProjectManagerController()
        {
            _IProjectManagerDomain = new ProjectManagerDomain();
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method will return the View (or page) where the Project Manager
        /// is able to create a new project
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //this is here to prevent XSS (cross site scripting attacks)
        public async Task<IActionResult> SaveNewProject(CreateProjectInput newProjectInput)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var resultList = new WorkHourTrackerListResult() { Errors = new List<string>(), WorkHourTrackList = new List<dynamic>() };

            //the request is valid. Now, transform it into CreateProjectDatabaseInput
            var databaseInput = new CreateProjectDatabaseInput(newProjectInput.ProjectName,
                                                               newProjectInput.ProjectCodeName,
                                                               TempData.Peek("userName").ToString());


            try
            {
                //send the request to the Domain layer
                await _IProjectManagerDomain.CreateNewProject(databaseInput);
                resultList.Errors.Add($"Project: {databaseInput.ProjectName} Project CodeName: {databaseInput.ProjectCodeName} has been created. Please assign the project to indivduals to being working on it.");
                TempData.Add("CreateProject", resultList.Errors);
            }
            catch (Exception)
            {

                throw;
            }


            return RedirectTo("ProjectManager", "CreateProject");

        }



        /// <summary>
        /// This method will return the View where the project manager
        /// can assign a project to an employee
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> AssignProject()
        {
            return View();
        }

        /// <summary>
        /// Use this method to direct to another controller / action
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="actionMethodName"></param>
        /// <returns></returns>
        public IActionResult RedirectTo(string controllerName, string actionMethodName)
        {
            return RedirectToRoute(new
            {
                controller = controllerName,
                action = actionMethodName
            });
        }
    }
}