using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using ConvalescentHome.Core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Service.Services
{
    public class WorkerService : IWorkerService
    {

        readonly Irepository<WorkerEntity> _workerRepository;
        public WorkerService(Irepository<WorkerEntity> workerRepository)
        {
            _workerRepository = workerRepository;
        }
        public IEnumerable<WorkerEntity> GetAllData()
        {
            return _workerRepository.GetAll();
        }
        public WorkerEntity GetWorkerById(int id)
        {
            return _workerRepository.GetById(id);
        }
        public bool AddWorker(WorkerEntity entity)
        {
            if (_workerRepository.IsExist(entity) != -1)
                return false;
            if (!CheckValid.IsValidiIdentityNumber(entity.Tz) || !CheckValid.IsValidEmail(entity.Mail))
                return false;
            return _workerRepository.Add(entity);
        }
        public bool UpdateWorker(int id, WorkerEntity entity)
        {
            if (_workerRepository.IsExist(entity) == -1)
                return false;
            return _workerRepository.Update(id, entity);
        }
        public bool DeleteWorker(int id)
        {
            if (_workerRepository.IsExist(_workerRepository.GetById(id)) == -1)
                return false;
            return _workerRepository.Delete(id);

        }
    }
}

