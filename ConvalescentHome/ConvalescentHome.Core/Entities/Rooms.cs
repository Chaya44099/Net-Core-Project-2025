using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvalescentHome.Core.Entities
{
    public enum Status { Available, Not_Available }
    public enum Type { Private, Not_private }
    [Table("Rooms")]
    public class RoomsEntity
    {
        [Key]
        public int IdTable { get; set; }
        public int Id { get; set; }
        public int Floor { get; set; }
        public int Number_Room { get; set; }
        public Status status { get; set; }
        public Type kind { get; set; }




    }
}
