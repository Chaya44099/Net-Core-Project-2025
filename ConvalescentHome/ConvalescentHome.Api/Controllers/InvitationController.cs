using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.IService;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConvalescentHome.Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        readonly IInvitationService _invitationService;
        public InvitationController(IInvitationService invitationService)
        {
            _invitationService = invitationService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<InvitationEntity>> Get()
        { 
            return _invitationService.GetAllData().ToList();
        }

        // GET api/<InvantionController>/5
        [HttpGet("{id}")]
        public ActionResult<InvitationEntity> GetById(int id)
        {
            if (id < 0) return BadRequest();
            InvitationEntity result = _invitationService.GetInvitationById(id);
            if (result == null) { return NotFound(); };
            return result;
        }
        // POST api/<InvantionController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] InvitationEntity invitation)
        {   
                return _invitationService.AddInvitation(invitation);
        }

        // PUT api/<InvantionController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] InvitationEntity invitation)
        {
            return _invitationService.UpdateInvitation(id, invitation);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _invitationService.DeleteInvitation(id);
        }
    }
}
