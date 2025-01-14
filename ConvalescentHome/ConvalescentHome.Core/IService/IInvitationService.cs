using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Core.IService
{
    public interface IInvitationService
    {
        IEnumerable<InvitationEntity> GetAllData();
        InvitationEntity GetInvitationById(int id);
        bool AddInvitation(InvitationEntity entity);
        bool UpdateInvitation(int id, InvitationEntity entity);
        bool DeleteInvitation(int id);

    }
}
