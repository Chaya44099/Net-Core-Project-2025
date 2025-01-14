using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvalescentHome.Core.Entities
{
    [Table("Parturient")]
    public class ParturientEntity
    {
        [Key]
        public int IdTable { get; set; }
        public int Id { get; set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Pel { get; set; }
        public DateTime Date_of_the_birth { get; set; }
        public string Health_fund { get; set; }
        public int Birth_number { get; set; }
        public int Id_Room { get; set; }
        [ForeignKey(nameof(Id_Room))]
        public RoomsEntity Room { get; set; }
        public int Id_invitation { get; set; }
        [ForeignKey(nameof(Id_invitation))]
        public InvitationEntity Invitation { get; set; }


    }
}
