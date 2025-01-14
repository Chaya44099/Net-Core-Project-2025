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
    public class ParturientService : IParturientService
    {

        readonly Irepository<ParturientEntity> _parturientRepository;
        public ParturientService(Irepository<ParturientEntity> parturientRepository)
        {
            _parturientRepository = parturientRepository;
        }
        public IEnumerable<ParturientEntity> GetAllData()
        {
            return _parturientRepository.GetAll();
        }
        public ParturientEntity GetParturientById(int id)
        {
            return _parturientRepository.GetById(id);
        }
        public bool AddParturient(ParturientEntity entity)
        {
            if (_parturientRepository.IsExist(entity) != -1)
                return false;
            if (!CheckValid.IsValidiIdentityNumber(entity.Tz) || !CheckValid.IsValidEmail(entity.Mail))
                return false;
            return _parturientRepository.Add(entity);
        }
        public bool UpdateParturient(int id, ParturientEntity entity)
        {
            if (_parturientRepository.IsExist(entity) == -1)
                return false;
            return _parturientRepository.Update(id, entity);
        }
        public bool DeleteParturient(int id)
        {
            if (_parturientRepository.IsExist(_parturientRepository.GetById(id)) == -1)
                return false;
            return _parturientRepository.Delete(id);

        }
    }
}
