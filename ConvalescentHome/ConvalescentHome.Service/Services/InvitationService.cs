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
    public class InvitationService : IInvitationService
    {
        readonly Irepository<InvitationEntity> _invitationRepository;
        public InvitationService(Irepository<InvitationEntity> invitationRepository)
        {
            _invitationRepository = invitationRepository;
        }
        public IEnumerable<InvitationEntity> GetAllData()

        {
            return _invitationRepository.GetAll();
        }
        public InvitationEntity GetInvitationById(int id)
        {
            return _invitationRepository.GetById(id);
        }
        public bool AddInvitation(InvitationEntity entity)
        {
            if (_invitationRepository.IsExist(entity) != -1)
                return false;
            return _invitationRepository.Add(entity);
        }
        public bool UpdateInvitation(int id, InvitationEntity entity)
        {
            if (_invitationRepository.IsExist(entity) == -1)
                return false;
            return _invitationRepository.Update(id, entity);
        }
        public bool DeleteInvitation(int id)
        {
            if (_invitationRepository.IsExist(GetInvitationById(id)) == -1)
                return false;
            return _invitationRepository.Delete(id);

        }
    }
}
