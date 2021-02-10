using Microsoft.AspNetCore.Mvc;
using System;
using repository_profilo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace repository_profilo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase
    {
        // GET: api/<InquiryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InquiryController>/5
        [HttpGet("{codScheda}")]
        public TbSchedaUnico Get(int codScheda)
        {
            TbSchedaUnico scheda = new TbSchedaUnico();
            using (var context = new ProfiloContext())
            {
                scheda = context.TbSchedaUnico.Where(s => s.CodSchedaUnico == codScheda).ToList().First<TbSchedaUnico>();
            }
            
            return scheda;
        }

        // POST api/<InquiryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InquiryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InquiryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
