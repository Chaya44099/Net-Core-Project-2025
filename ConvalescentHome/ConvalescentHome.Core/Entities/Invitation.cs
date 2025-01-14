using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvalescentHome.Core.Entities
{
    public enum Pay { Credit, Check, Cash }
    [Table("Invitation")]
    public class InvitationEntity
    {
        [Key]
        public int IdTable { get; set; }
        public int Id { get; set; }
        public int Yoledet_Id { get; set; }
        [ForeignKey(nameof(Yoledet_Id))]
        public ParturientEntity Yoledet { get; set; }
        public int Room_Id { get; set; }
        [ForeignKey(nameof(Room_Id))]
        public RoomsEntity Room { get; set; }
        public int Amount_Of_Days { get; set; }
        public Pay pay { get; set; }
        public DateTime Invantion_Date { get; set; }
        public DateTime Date_arive { get; set; }
        public DateTime Invantion_Leave { get; set; }
    }
}
