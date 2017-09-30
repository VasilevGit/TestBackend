using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBackend.Models;

namespace TestBackend.Controllers
{
    public class ProjectController : ApiController
    {
        private static List<Project> _projects = new List<Project>() {
            new Project() {
                Id  = 1,
                Name = "Project 1",
                Description = "Description Project 1",
                State = State.Active
            },
            new Project() {
                Id  = 2,
                Name = "Project 2",
                Description = "Description Project 2",
                State = State.Active
            },
            new Project() {
                Id  = 3,
                Name = "Project 3",
                Description = "Description Project 3",
                State = State.Postponed
            },
            new Project() {
                Id  = 4,
                Name = "Project 4",
                Description = "Description Project 4",
                State = State.Closed
            }
        };

        // GET api/project
        public IEnumerable<Project> Get()
        {
            return _projects;
        }

        // GET api/project/2
        public Project Get(int id)
        {
            return _projects.Find(prj => prj.Id == id);
        }

        // POST api/project
        public void Post([FromBody]Project prj)
        {
            _projects.Add(prj);
        }

        // PUT api/project/2
        public void Put(int id, [FromBody]Project prj)
        {
            var entry = _projects.Find(p => p.Id == id);

            entry.Name = prj.Name;
            entry.Description = prj.Description;
            entry.State = prj.State;
        }

        // DELETE api/project/2
        public void Delete(int id)
        {
            _projects.RemoveAll(t => t.Id == id);
        }
    }
}
