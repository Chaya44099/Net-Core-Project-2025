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
    public class RoomsService : IRoomsService
    {
        readonly Irepository<RoomsEntity> _roomsRepository;
        public RoomsService(Irepository<RoomsEntity> roomsRepository)
        {
            _roomsRepository = roomsRepository;
        }
        public IEnumerable<RoomsEntity> GetAllData()
        {
            return _roomsRepository.GetAll();
        }
        public RoomsEntity GetRoomById(int id)
        {
            return _roomsRepository.GetById(id);
        }
        public bool AddRoom(RoomsEntity entity)
        {
            if (_roomsRepository.IsExist(entity) != -1)
                return false;
            return _roomsRepository.Add(entity);
        }
        public bool UpdateRoom(int id, RoomsEntity entity)
        {
            if (_roomsRepository.IsExist(entity) == -1)
                return false;
            return _roomsRepository.Update(id, entity);
        }
        public bool DeleteRoom(int id)
        {
            if (_roomsRepository.IsExist(GetRoomById(id)) == -1)
                return false;
            return _roomsRepository.Delete(id);

        }
    }
}
