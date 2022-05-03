using BusinessLogic.LongFile;
using EntitiesDTOs.LongFileDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private ILongFileService service;
        public FilesController(ILongFileService _service)
        {
            service = _service;
        }

        // GET: api/<Files>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET api/<Files>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Files>
        [HttpPost]
        public void Post([FromForm] LongFileInput_DTO LFI_DTO)
        {

            service.PostLongFile(LFI_DTO);
            
        }

        // PUT api/<Files>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Files>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
