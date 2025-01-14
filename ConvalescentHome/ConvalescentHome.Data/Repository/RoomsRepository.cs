using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Data.Repository
{
    public class RoomsRepository:Irepository<RoomsEntity>
    {
        readonly DataContext _dataContext;
        public RoomsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<RoomsEntity> GetAll()
        {
            return _dataContext.rooms.ToList();
        }
        public RoomsEntity GetById(int id)
        {
            return _dataContext.rooms.FirstOrDefault(c => c.Id == id);
        }
        public int IsExist(RoomsEntity room)
        {
            return _dataContext.invitations.ToList().FindIndex(b => b.Id == room.Id);
        }
        public bool Add(RoomsEntity r)
        {
            try
            {
                _dataContext.rooms.Add(r);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(int id, RoomsEntity r)
        {
            //לבדוק אם צריך לעשות את זה?
            int index = IsExist(r);
            if (index == -1)
                return false;
            //לבדוק מה צריך לשנות פה 
            //האם תעודת זהות גם אפשר לשנות,מין,ID
            try
            {
                if (r.Id != _dataContext.rooms.ToList()[index].Id)
                    _dataContext.babies.ToList()[index].Id = r.Id;
                if (r.Floor != _dataContext.rooms.ToList()[index].Floor)
                    _dataContext.rooms.ToList()[index].Floor = r.Floor;
                if (r.Number_Room != _dataContext.rooms.ToList()[index].Number_Room)
                    _dataContext.rooms.ToList()[index].Number_Room = r.Number_Room;
                if (r.status != _dataContext.rooms.ToList()[index].status)
                    _dataContext.rooms.ToList()[index].status = r.status;
                if (r.kind != _dataContext.rooms.ToList()[index].kind)
                    _dataContext.rooms.ToList()[index].kind = r.kind;
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
                _dataContext.rooms.Remove(_dataContext.rooms.Where(c => c.Id == id).FirstOrDefault());
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
