using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thcp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [Display(Name = "Nombres")]
        [MinLength(2, ErrorMessage = "Debe tener mas de dos caracteres.")]
        public string FirtsName { get; set; }

        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [Display(Name = "Apellidos")]
        [MinLength(2, ErrorMessage = "Debe tener mas de dos caracteres.")]
        public string LastName { get; set; }

        [StringLength(13, ErrorMessage = "No debe tener mas de 13 caracteres.")]
        [Display(Name = "Identidad")]
        [MinLength(13, ErrorMessage = "Debe tener mas de 13 caracteres.")]
        public string Indentity { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BirthDay { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Salario")]
        public decimal Salary { get; set; }

        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public Position Position { get; set; }
    }
}
