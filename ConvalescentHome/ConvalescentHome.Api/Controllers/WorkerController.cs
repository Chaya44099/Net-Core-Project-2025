using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.IService;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConvalescentHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        readonly IWorkerService _workerService;
        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<WorkerEntity>> Get()
        {
            return _workerService.GetAllData().ToList();
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public ActionResult<WorkerEntity> GetById(int id)
        {
            if (id < 0) return BadRequest();
            WorkerEntity result= _workerService.GetWorkerById(id);
            if (result == null) { return NotFound(); };
            return result;
        }

        // POST api/<WorkerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] WorkerEntity worker)
        {
          //  CheckValid _checkValid = new CheckValid();
          //  if (_checkValid.IsValidiIdentityNumber(worker.Tz)&&_checkValid.IsValidEmail(worker.Mail))
                return _workerService.AddWorker(worker);
           // else { return BadRequest(); }
   
        }


        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] WorkerEntity worker)
        {
            return _workerService.UpdateWorker(id,worker);
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return (_workerService.DeleteWorker(id));
        }
    }
}
