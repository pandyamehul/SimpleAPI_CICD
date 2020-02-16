using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Get API Value
        /// </summary>
        /// <returns>Returns the array of string</returns>
        /// <remarks>This API will get all the values that are there in array</remarks>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Dot net", "Enabled CI/CD", "This is .net core demo", "this is update to the api" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Mehul Pandya";
            // return "Invalid text - to fail test case";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //code to be added here to add to the DB
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //Put code to be added here
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Delete code to be added here 
        }
    }
}
