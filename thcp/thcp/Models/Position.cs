
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
        [Display(Name = "Puesto al que aplica")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Description { get; set; }

        public int DepartmetId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Departamento de RRHH")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionDepartamento { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Detalles del Puesto")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionDetalles { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Tipo de Contrato")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionTipoContrato { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Beneficios de Ley")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionBeneficios { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Jornada Laboral")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionJornada { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Salario")]

        public int DescriptionSalario { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Perfil Deseado")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionPerfil { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Experiencia")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionExperiencia { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Zona de Ejecucion")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionZona { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Display(Name = "Direccion de Envio Curriculum")]
        [StringLength(2000, ErrorMessage = "No debe tener mas de 2000 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de cuatro caracteres.")]
        public string DescriptionContacto { get; set; }

    }
}
