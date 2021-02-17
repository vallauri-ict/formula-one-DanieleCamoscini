using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FormulaOneDLL;

namespace formulaOneWebServices
{
    [Route("api/driver")]
    [ApiController]
    public class driverController : ControllerBase
    {
        // GET: api/driver
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            DBtools db = new DBtools();
            return db.getListDriver();
        }

        // GET: api/driver/5
        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            DBtools db = new DBtools();
            return db.getDriverById(id); 
        }
        // POST: api/driver
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/driver/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
