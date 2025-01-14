using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.IService;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConvalescentHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {

        readonly IBabyService _babyService;
        public BabyController(IBabyService babyService)
        {
            _babyService = babyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BabyEntity>> Get()
        { 
            return _babyService.GetAllData().ToList();
        }

        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public ActionResult<BabyEntity> GetById(int id)
        {
            if (id < 0) return BadRequest();
            BabyEntity result = _babyService.GetBabyById(id);
            if (result == null) { return NotFound(); };
            return result;
        }
        // POST api/<BabyController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] BabyEntity baby)
        {
                 return _babyService.AddBaby(baby);
        }

        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] BabyEntity baby)
        {
            return _babyService.UpdateBaby(id, baby);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _babyService.DeleteBaby(id);
        }
    }
}
