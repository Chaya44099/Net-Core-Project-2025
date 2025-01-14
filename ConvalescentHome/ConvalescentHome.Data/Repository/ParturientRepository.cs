using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Data.Repository
{
    public class ParturientRepository:Irepository<ParturientEntity>
    {
        readonly DataContext _dataContext;
        public ParturientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ParturientEntity> GetAll()
        {
            return _dataContext.Parturients.ToList();
        }
        public ParturientEntity GetById(int id)
        {
            //var data = _dataContextBaby.LoadData();
            //if (data == null)
            //    return null;
            return _dataContext.Parturients.FirstOrDefault(c => c.Id == id);

        }
        public int IsExist(ParturientEntity parturient)
        {
            return _dataContext.Parturients.ToList().FindIndex(b => b.Tz == parturient.Tz);
        }
        public bool Add(ParturientEntity p)
        {
            try
            {
                _dataContext.Parturients.Add(p);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(int id, ParturientEntity p)
        { 
            try
            {   //לבדוק אם צריך לעשות את זה?
                int index = IsExist(p);
                if (index == -1)
                    return false;
                //לבדוק מה צריך לשנות פה 
                //האם תעודת זהות גם אפשר לשנות,מין,ID
                if (p.Id != _dataContext.Parturients.ToList()[index].Id)
                    _dataContext.Parturients.ToList()[index].Id = p.Id;
                if (p.Tz != _dataContext.Parturients.ToList()[index].Tz)
                    _dataContext.Parturients.ToList()[index].Tz = p.Tz;
                if (p.Name != _dataContext.Parturients.ToList()[index].Name)
                    _dataContext.Parturients.ToList()[index].Name = p.Name;
                if (p.Address != _dataContext.Parturients.ToList()[index].Address)
                    _dataContext.Parturients.ToList()[index].Address = p.Address;
                if (p.Age != _dataContext.Parturients.ToList()[index].Age)
                    _dataContext.Parturients.ToList()[index].Age = p.Age;
                if (p.Mail != _dataContext.Parturients.ToList()[index].Mail)
                    _dataContext.Parturients.ToList()[index].Mail = p.Mail;
                if (p.Date_of_the_birth != _dataContext.Parturients.ToList()[index].Date_of_the_birth)
                    _dataContext.Parturients.ToList()[index].Date_of_the_birth = p.Date_of_the_birth;
                if (p.Health_fund != _dataContext.Parturients.ToList()[index].Health_fund)
                    _dataContext.Parturients.ToList()[index].Health_fund = p.Health_fund;
                if (p.Pel != _dataContext.Parturients.ToList()[index].Pel)
                    _dataContext.Parturients.ToList()[index].Pel = p.Pel;
                if (p.Birth_number != _dataContext.Parturients.ToList()[index].Birth_number)
                    _dataContext.Parturients.ToList()[index].Birth_number = p.Birth_number;
                if (p.Id_Room != _dataContext.Parturients.ToList()[index].Id_Room)
                    _dataContext.Parturients.ToList()[index].Id_Room = p.Id_Room;
                if (p.Id_invitation != _dataContext.Parturients.ToList()[index].Id_invitation)
                    _dataContext.Parturients.ToList()[index].Id_invitation = p.Id_invitation;
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
                _dataContext.Parturients.Remove(_dataContext.Parturients.Where(c => c.Id == id).FirstOrDefault());
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
