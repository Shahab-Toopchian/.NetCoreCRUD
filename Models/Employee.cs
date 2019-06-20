using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName="nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName="nvarchar(10)")]
        [DisplayName("Code")]
        public string EmpCode { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string Position { get; set; }

        [Column(TypeName="nvarchar(100)")]
        [DisplayName("Office")]
         public string OfficeLocation { get; set; }
        
    }
}