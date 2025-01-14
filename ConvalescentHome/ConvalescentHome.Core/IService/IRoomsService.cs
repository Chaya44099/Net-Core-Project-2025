using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Core.IService
{
    public interface IRoomsService
    {
        IEnumerable<RoomsEntity> GetAllData();
        RoomsEntity GetRoomById(int id);
        bool AddRoom(RoomsEntity entity);
        bool UpdateRoom(int id, RoomsEntity entity);
        bool DeleteRoom(int id);

    }
}
