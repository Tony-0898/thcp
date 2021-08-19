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
        [Display(Name = "Nombre y Apellido")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "El numero  de cedula es obligatorio.")]
        [Display(Name = "Numero de Cedula")]
        public string DepartmentNumero { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria.")]
        [Display(Name = "Direccion de Residencia")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 100 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentDetalle { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Genero")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentSexo { get; set; }

        [Required(ErrorMessage = "El numero Telefonico es obligatorio.")]
        [Display(Name = "Numero telefonico")]
        public int DepartmentTelefono { get; set; }

        [Required(ErrorMessage = "Campo bligatorio.")]
        [Display(Name = "Edad")]
        public int DepartmentEdad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Nivel Educativo")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentEducacion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Experiencia laboral (ingresar sin experiencia, si no aplica) ")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentEspecialidad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Idioma")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentIdioma { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Pretencion Salarial")]
        public int DepartmentSalario { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Departamento de RRHH del Puesto")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentRecursos { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Vacante a la que aplica")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DepartmentPuesto { get; set; }


        public IEnumerable<Proyecto> proyectos { get; set; }
    }
}
