using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using ConvalescentHome.Core.IService;


namespace ConvalescentHome.Service.Services
{
    public class BabyService : IBabyService
    {
        readonly Irepository<BabyEntity> _babyrepository;
        public BabyService(Irepository<BabyEntity> babyrepository)
        {
            _babyrepository = babyrepository;
        }
        public IEnumerable<BabyEntity> GetAllData()
        {
            return _babyrepository.GetAll();
        }
        public BabyEntity GetBabyById(int id)
        {
            return _babyrepository.GetById(id);
        }
        public bool AddBaby(BabyEntity entity)
        {
            if( _babyrepository.IsExist(entity)!=-1)
                return false;
            if(!CheckValid.IsValidiIdentityNumber(entity.Tz))
                return false;
            return _babyrepository.Add(entity);
        }
        public bool UpdateBaby(int id, BabyEntity entity)
        {
            if( _babyrepository.IsExist(entity)==-1)
                return false;
            return _babyrepository.Update(id, entity);
        }
        public bool DeleteBaby(int id)
        {
            if(_babyrepository.IsExist(_babyrepository.GetById(id))==-1)
                return false;
            return _babyrepository.Delete(id);

        }
    }
}