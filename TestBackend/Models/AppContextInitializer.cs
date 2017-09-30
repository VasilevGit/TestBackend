using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestBackend.Models
{
    public class AppContextInitializer : CreateDatabaseIfNotExists<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            base.Seed(context);

            context.Configuration.ProxyCreationEnabled = true;
            context.Configuration.LazyLoadingEnabled = true;

            var project1 = new Project()
            {
                Name = "Project",
                Description = "Description",
                State = State.Active,
                Tasks = new List<Task>()
            };

            var project2 = new Project()
            {
                Name = "Project 2",
                Description = "Description of project 2",
                State = State.Active,
                Tasks = new List<Task>()
            };

            var task = new Task()
            {
                Name = "Task",
                Description = "Task description",
                State = State.Active,
                //EndDate = DateTime.Now,
                Project = project1
            };

            var task2 = new Task()
            {
                Name = "Task 2",
                Description = "Task2 description",
                State = State.Active,
                //EndDate = DateTime.Now,
                Project = project2
            };

            context.Projects.Add(project1);
            context.Projects.Add(project2);

            context.Tasks.Add(task);
            context.Tasks.Add(task2);

            context.SaveChanges();
        }
    }
}