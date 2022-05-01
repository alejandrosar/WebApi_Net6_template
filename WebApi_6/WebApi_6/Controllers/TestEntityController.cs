using BusinessLogic.TestEntityService;
using EntitiesDTOs.TestEntityDTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestEntityController : ControllerBase
    {
        private ITestEntityService service;
        public TestEntityController(ITestEntityService _service)
        {
            service = _service;
        }
        // GET: api/<TestEntityController>
        [HttpGet]
        public ActionResult<List<TestEntityToReturn_DTO>> Get()
        {
            return Ok(service.GetAll());
        }

        [HttpPost]
        public ActionResult<TestEntityToReturn_DTO> Post(TestEntityFullInput_DTO toPost)
        {
            return Ok(service.PostOne(toPost));
        }
       
    }
}
