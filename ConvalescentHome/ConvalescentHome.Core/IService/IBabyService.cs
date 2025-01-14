using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConvalescentHome.Core.IService
{
    public interface IBabyService
    {
        IEnumerable<BabyEntity> GetAllData();
        BabyEntity GetBabyById(int id);
        bool AddBaby(BabyEntity entity);
        bool UpdateBaby(int id, BabyEntity entity);
        bool DeleteBaby(int id);

    }
}
