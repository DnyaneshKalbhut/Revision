using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02CodeFirstApp.Models
{

    [Table("Empl")]
    public class Employee
    {

        [Key]
        [Column("Eid",TypeName ="int")]
        public int EId { get; set; }

        [Column("EName",TypeName ="varchar(50)")]
        public string EName { get; set; }

        [Column("EAddress", TypeName = "varchar(50)")]
        public string EAddress { get; set; } 
    }
}
