using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thcp.Models
{
    public class Department
    {
        [Key]
        public int DepartmetId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Departamento")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string DepartmentName { get; set; }

        public IEnumerable<Position> Positions { get; set; }
    }
}
