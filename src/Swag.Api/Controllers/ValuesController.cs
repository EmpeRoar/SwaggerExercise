using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swag.Api.Models;
using Swag.Api.Services;

namespace Swag.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IPeopleService _peopleService;
        public ValuesController(IPeopleService peopleService){
            _peopleService = peopleService;
        }


        /// <summary>
        /// Get a People.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// Nothing piece of cigar
        ///
        /// </remarks>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpGet]
        [ProducesResponseType(typeof(Person), 201)]
        [ProducesResponseType(400)]
        public IEnumerable<Person> Get()
        {

            return _peopleService.GetPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        /// <summary>
        /// Create a People.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Value
        ///     {
        ///        "string": "Item1",
        ///     }
        ///
        /// </remarks>
        /// <returns>A newly created Value</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
