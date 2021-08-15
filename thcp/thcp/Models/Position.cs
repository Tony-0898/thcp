
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thcp.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [Display(Name = "Puesto")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Description { get; set; }

        public int DepartmetId { get; set; }

        [ForeignKey("DepartmetId")]
        public Department Department { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
