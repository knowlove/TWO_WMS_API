using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TWO_WMS_API.Controllers
{
    public class DhEmpController : ApiController
    {
        // GET: api/DhEmp
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DhEmp/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DhEmp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DhEmp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DhEmp/5
        public void Delete(int id)
        {
        }
        Emp_Dal ed = new Emp_Dal();
        // GET api/
        [HttpGet]
        public List<Emp_Model> Getc(string Cgdh, string Gys, string Pl, string Cgr, string Rkzt)
        {
            return ed.Show(Cgdh, Gys, Pl, Cgr, Rkzt);
        }
        [HttpGet]
        public List<Emp_Model> GetAll()
        {
            return ed.GetAll();
        }
        [HttpGet]
        public List<Emp_Model> GetXqy(int id)
        {
            return ed.GetXqy(id);
        }
        [HttpPost]
        public int DelDhEmp(int id)
        {
            return ed.DelDhEmp(id);
        }
        public int UpEmp(string Gys, string Xhqy, string Cgsl, string Cgdj, string Je, string Sl, string Rq, string Bz, string id) {
            return ed.UpEmp (Gys, Xhqy, Cgsl, Cgdj, Je, Sl, Rq, Bz, id);
        }
        public int AddEmp(string DhCgdh, string DhGys, string DhPl, string DhRq, string DhName, string DhType, string DhYlbm, string DhYlmc, string DhWq, string DhYlGg, string DhCgsl, string DhBz, string DhHq, string DhJe, string DhSl, string DhDj) {

            return ed.AddDhEmp(DhCgdh, DhGys, DhPl, DhRq, DhName, DhType, DhYlbm, DhYlmc, DhWq, DhYlGg, DhCgsl, DhBz, DhHq, DhJe, DhSl, DhDj);
        }
    }
}
