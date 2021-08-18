  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thcp.Models
{
    public class Proyecto
    {

        [key]
        public int Id { get; set; }
        public string ProyectoId { get; set; }

        public int DepartmetId { get; set; }
        [ForeignKey("DepartmetId")]
        public Department Department { get; set; }

        public string ProyectoResidence { get; set; }
    }
}
