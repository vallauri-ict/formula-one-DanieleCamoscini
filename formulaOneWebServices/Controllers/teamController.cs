using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using FormulaOneDLL;
using Microsoft.AspNetCore.Mvc;

namespace formulaOneWebServices
{
    [Route("api/team")]
    [ApiController]
    public class teamController : ControllerBase
    {
        // GET: api/team
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            DBtools db = new DBtools();
            return db.GetListTeam();
        }

        // GET: api/team/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            DBtools db = new DBtools();
            return db.GetTeamById(id);
        }

        // POST: api/team
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/team/5
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
