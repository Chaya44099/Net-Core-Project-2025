using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Core.IService
{
    public interface IWorkerService
    {
        IEnumerable<WorkerEntity> GetAllData();
        WorkerEntity GetWorkerById(int id);
        bool AddWorker(WorkerEntity entity);
        bool UpdateWorker(int id, WorkerEntity entity);
        bool DeleteWorker(int id);
    }
}
