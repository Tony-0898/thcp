  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace thcp.Models
{
    public class Proyecto
    {

        [key]
        public  int Id { get; set; }
        public string DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public string DepartmentVacante { get; set; }

        public string  DepartmentResidencia { get; set; }
    }
}
