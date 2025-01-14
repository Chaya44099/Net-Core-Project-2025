using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Data.Repository
{
    public class BabyRepository : Irepository<BabyEntity>
    {
        readonly DataContext _dataContext;
        public BabyRepository(DataContext dataContext)
        {

            _dataContext = dataContext;

        }
        public List<BabyEntity> GetAll()
        {
            return _dataContext.babies.ToList();
        }
        public BabyEntity GetById(int id)
        {
            return _dataContext.babies.FirstOrDefault(c => c.Id == id);
        }
        public int IsExist(BabyEntity baby)
        {
            return _dataContext.babies.ToList().FindIndex(b => b.Tz == baby.Tz);
        }
        public bool Add(BabyEntity b)
        {
            try
            {
                _dataContext.babies.Add(b);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(int id, BabyEntity e)
        {
            try
            {
                //לבדוק אם צריך לעשות את זה?
               int index=IsExist(e);
                if(index==-1)
                    return false;
                //לבדוק מה צריך לשנות פה 
                //האם תעודת זהות גם אפשר לשנות,מין,ID
                if (e.Id != _dataContext.babies.ToList()[index].Id)
                    _dataContext.babies.ToList()[index].Id = e.Id;
                if (e.Tz != _dataContext.babies.ToList()[index].Tz)
                    _dataContext.babies.ToList()[index].Tz = e.Tz;
                if (e.WeightNow != _dataContext.babies.ToList()[index].WeightNow)
                    _dataContext.babies.ToList()[index].WeightNow= e.WeightNow;
                if (e.DateBirth != _dataContext.babies.ToList()[index].DateBirth)
                    _dataContext.babies.ToList()[index].DateBirth = e.DateBirth;
                if (e.WeightBirth != _dataContext.babies.ToList()[index].WeightBirth)
                    _dataContext.babies.ToList()[index].WeightBirth = e.WeightBirth;
                if (e.MomId != _dataContext.babies.ToList()[index].MomId)
                    _dataContext.babies.ToList()[index].MomId = e.MomId;
                if (e.Gender != _dataContext.babies.ToList()[index].Gender)
                    _dataContext.babies.ToList()[index].Gender = e.Gender;
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                _dataContext.babies.Remove(_dataContext.babies.Where(c => c.Id == id).FirstOrDefault());
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
