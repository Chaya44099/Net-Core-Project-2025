using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.IService;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConvalescentHome.Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        readonly IRoomsService _roomsService;
        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RoomsEntity>> Get()
        {
            return _roomsService.GetAllData().ToList();
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult<RoomsEntity> GetById(int id)
        {
            if (id < 0) return BadRequest();
            RoomsEntity result = _roomsService.GetRoomById(id);
            if (result == null) { return NotFound(); };
            return result;
        }

        // POST api/<RoomsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] RoomsEntity rooms)
        {
            return _roomsService.AddRoom(rooms);
        }


        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] RoomsEntity room)
        {
            return _roomsService.UpdateRoom(id, room);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _roomsService.DeleteRoom(id);
        }
    }
}
