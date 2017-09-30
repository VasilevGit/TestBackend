using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBackend.Models;

namespace TestBackend.Controllers
{
    public class TaskController : ApiController
    {
        AppContext _db = new AppContext();

        // GET api/task
        public IEnumerable<Task> Get()
        {
            return _db.Tasks.ToList();
        }

        // GET api/task/2
        public Task Get(int id)
        {
            return _db.Tasks.Find(id);
        }

        // POST api/task
        public void Post([FromBody]Task task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        // PUT api/task/2
        public void Put(int id, [FromBody]Task task)
        {

        }

        // DELETE api/task/2
        public void Delete(int id)
        {

        }
    }
}
