using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace ConvalescentHome.Core.Entities
{
    public enum Gender { Female, Male }
    [Table("Baby")]
    public class BabyEntity
    {
        [Key]
        public int IdTable { get; set; }
        public int Id { get; set; }
        public int MomId { get; set; }
        [ForeignKey(nameof(MomId))]
        ParturientEntity Mom { get; set; }
        public string Tz { get; set; }
        public DateTime DateBirth { get; set; }
        [Column(TypeName="decimal(18,4)")]
        public decimal WeightBirth { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal WeightNow { get; set; }
        public Gender Gender { get; set; }

        
    }
}
