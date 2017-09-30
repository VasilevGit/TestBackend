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
        AppContext _db = new AppContext();

        // GET api/project
        public IEnumerable<Project> Get()
        {
            return _db.Projects;
        }

        // GET api/project/2
        public Project Get(int id)
        {
            return _db.Projects.Find(id);
        }

        // POST api/project
        public void Post([FromBody]Project prj)
        {
            _db.Projects.Add(prj);
            _db.SaveChanges();
        }

        // PUT api/project/2
        public void Put(int id, [FromBody]Project prj)
        {/*
            var entry = _projects.Find(p => p.Id == id);

            entry.Name = prj.Name;
            entry.Description = prj.Description;
            entry.State = prj.State;
            */
        }

        // DELETE api/project/2
        public void Delete(int id)
        {
            var entry = _db.Projects.Find(id);
            _db.Projects.Remove(entry);
        }
    }
}
