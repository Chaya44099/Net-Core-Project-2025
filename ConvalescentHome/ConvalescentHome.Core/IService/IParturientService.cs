using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Core.IService
{
    public interface IParturientService
    {
        IEnumerable<ParturientEntity> GetAllData();
        ParturientEntity GetParturientById(int id);
        bool AddParturient(ParturientEntity entity);
        bool UpdateParturient(int id, ParturientEntity entity);
        bool DeleteParturient(int id);

    }
}
