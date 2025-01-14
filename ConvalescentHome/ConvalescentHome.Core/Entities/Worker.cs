using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvalescentHome.Core.Entities
{
    public enum Shift { Morning, Noon, Evennig }
    [Table("Worker")]
    public class WorkerEntity
    {
        [Key]
        public int IdTable { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Tz { get; set; }
        public string Mail { get; set; }
        public string Pel { get; set; }
        public string Address { get; set; }
        public Shift duty { get; set; }
        public string Role { get; set; }
        public int Seniority { get; set; }
        public int Weekly_Hours { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
    }
}
