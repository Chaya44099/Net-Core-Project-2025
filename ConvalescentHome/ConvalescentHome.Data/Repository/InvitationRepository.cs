using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Data.Repository
{
    public class InvitationRepository:Irepository<InvitationEntity>
    {
        readonly DataContext _dataContext;
        public InvitationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<InvitationEntity> GetAll()
        {
            return _dataContext.invitations.ToList();
        }
        public InvitationEntity GetById(int id)
        {
            return _dataContext.invitations.FirstOrDefault(c => c.Id == id);

        }
        public int IsExist(InvitationEntity i)
        {
            return _dataContext.invitations.ToList().FindIndex(b => b.Id == i.Id);
        }
        public bool Add(InvitationEntity i)
        { 
            try
            {
                _dataContext.invitations.Add(i);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(int id, InvitationEntity i)
        {
            try
            {   //לבדוק אם צריך לעשות את זה?
                int index = IsExist(i);
                if (index == -1)
                    return false;
                //לבדוק מה צריך לשנות פה 
                //האם תעודת זהות גם אפשר לשנות,מין,ID
                if (i.Id != _dataContext.invitations.ToList()[index].Id)
                    _dataContext.invitations.ToList()[index].Id = i.Id;
                if (i.Yoledet_Id != _dataContext.invitations.ToList()[index].Yoledet_Id)
                    _dataContext.invitations.ToList()[index].Yoledet_Id = i.Yoledet_Id;
                if (i.Room_Id != _dataContext.invitations.ToList()[index].Room_Id)
                    _dataContext.invitations.ToList()[index].Room_Id = i.Room_Id;
                if (i.Amount_Of_Days != _dataContext.invitations.ToList()[index].Amount_Of_Days)
                    _dataContext.invitations.ToList()[index].Amount_Of_Days = i.Amount_Of_Days;
                if (i.pay != _dataContext.invitations.ToList()[index].pay)
                    _dataContext.invitations.ToList()[index].pay = i.pay;
                if (i.Invantion_Date != _dataContext.invitations.ToList()[index].Invantion_Date)
                    _dataContext.invitations.ToList()[index].Invantion_Date = i.Invantion_Date;
                if (i.Date_arive != _dataContext.invitations.ToList()[index].Date_arive)
                    _dataContext.invitations.ToList()[index].Date_arive = i.Date_arive;
                if (i.Invantion_Leave != _dataContext.invitations.ToList()[index].Invantion_Leave)
                    _dataContext.invitations.ToList()[index].Invantion_Leave = i.Invantion_Leave;
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
                _dataContext.invitations.Remove(_dataContext.invitations.Where(c => c.Id == id).FirstOrDefault());
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
