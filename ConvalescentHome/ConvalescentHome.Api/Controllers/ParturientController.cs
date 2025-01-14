using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.IService;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConvalescentHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParturientController : ControllerBase
    {
        readonly IParturientService _parturientService;
        public ParturientController(IParturientService parturientService)
        {
            _parturientService = parturientService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ParturientEntity>> Get()
        {
            return _parturientService.GetAllData().ToList();
        }

        // GET api/<ParturientController>/5
        [HttpGet("{id}")]
        public ActionResult<ParturientEntity> GetById(int id)
        {
            if (id < 0) return BadRequest();
            ParturientEntity result = _parturientService.GetParturientById(id);
            if (result == null) { return NotFound(); };
            return result;
        }

        // POST api/<ParturientController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] ParturientEntity parturient)
        {
         //   CheckValid _checkValid = new CheckValid();
         //   if (_checkValid.IsValidiIdentityNumber(parturient.Tz) && _checkValid.IsValidEmail(parturient.Mail))
                return _parturientService.AddParturient(parturient);
        //    else { return BadRequest(); }
            
        }

        // PUT api/<ParturientController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] ParturientEntity parturient)
        {
            return _parturientService.UpdateParturient(id, parturient);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _parturientService.DeleteParturient(id);
        }
    }
}
