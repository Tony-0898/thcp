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
        [Display(Name = "Departamento de RRHH")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "El numero es obligatorio.")]
        [Display(Name = "Numero de Vacantes")]
        public int DepartmentNumero { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Detalles del puesto")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 100 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentDetalle { get; set; }

        public IEnumerable<Position> Positions { get; set; }
    }
}
