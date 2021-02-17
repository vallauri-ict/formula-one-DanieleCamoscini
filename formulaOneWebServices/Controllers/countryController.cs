using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaOneDLL;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaOneWebServices
{
    [Route("api/country")]
    [ApiController]
    public class countryController : ControllerBase
    {
        // GET: api/<countryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            DBtools db = new DBtools();
            return db.GetListCountry();
        }

        // GET api/<countryController>/5
        [HttpGet("{id}")]
        public Country Get(string id)
        {
            DBtools db = new DBtools();
            return db.GetCountryById(id);
        }

        // POST api/<countryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<countryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<countryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
