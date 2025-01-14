using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Data.Repository
{
    public class WorkerRepository:Irepository<WorkerEntity>
    {
        readonly DataContext _dataContext;
        public WorkerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<WorkerEntity> GetAll()
        {
            return _dataContext.workers.ToList();
        }
        public WorkerEntity GetById(int id)
        {
            //var data = _dataContextBaby.LoadData();
            //if (data == null)
            //    return null;
            return _dataContext.workers.FirstOrDefault(c => c.Id == id);
        }
        public int IsExist(WorkerEntity worker)
        {
            return _dataContext.workers.ToList().FindIndex(b => b.Tz == worker.Tz);
        }
        public bool Add(WorkerEntity w)
        {
            try
            {
                _dataContext.workers.Add(w);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(int id, WorkerEntity w)
        {
            try
            {   //לבדוק אם צריך לעשות את זה?
                int index = IsExist(w);
                if (index == -1)
                    return false;
                //לבדוק מה צריך לשנות פה 
                //האם תעודת זהות גם אפשר לשנות,מין,ID
                if (w.Id != _dataContext.workers.ToList()[index].Id)
                    _dataContext.workers.ToList()[index].Id = w.Id;
                if (w.Tz != _dataContext.workers.ToList()[index].Tz)
                    _dataContext.workers.ToList()[index].Tz = w.Tz;
                if (w.Name != _dataContext.workers.ToList()[index].Name)
                    _dataContext.workers.ToList()[index].Name = w.Name;
                if (w.Address != _dataContext.workers.ToList()[index].Address)
                    _dataContext.workers.ToList()[index].Address = w.Address;
                if (w.Age != _dataContext.workers.ToList()[index].Age)
                    _dataContext.workers.ToList()[index].Age = w.Age;
                if (w.Mail != _dataContext.workers.ToList()[index].Mail)
                    _dataContext.workers.ToList()[index].Mail = w.Mail;
                if (w.duty != _dataContext.workers.ToList()[index].duty)
                    _dataContext.workers.ToList()[index].duty = w.duty;
                if (w.Role != _dataContext.workers.ToList()[index].Role)
                    _dataContext.workers.ToList()[index].Role = w.Role;
                if (w.Pel != _dataContext.workers.ToList()[index].Pel)
                    _dataContext.workers.ToList()[index].Pel = w.Pel;
                if (w.Seniority != _dataContext.workers.ToList()[index].Seniority)
                    _dataContext.workers.ToList()[index].Seniority = w.Seniority;
                if (w.Weekly_Hours != _dataContext.workers.ToList()[index].Weekly_Hours)
                    _dataContext.workers.ToList()[index].Weekly_Hours = w.Weekly_Hours;
                if (w.Salary != _dataContext.workers.ToList()[index].Salary)
                    _dataContext.workers.ToList()[index].Salary = w.Salary;
                if (w.Gender != _dataContext.workers.ToList()[index].Gender)
                    _dataContext.workers.ToList()[index].Gender = w.Gender;
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
                _dataContext.workers.Remove(_dataContext.workers.Where(c => c.Id == id).FirstOrDefault());
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
