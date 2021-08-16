using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thcp.Common;
using thcp.Data;
using thcp.Models;

namespace thcp.Controllers
{
    public class ProyectosController : Controller

    {
        private readonly int RecordsPerPage = 10;

        private readonly ApplicationDbContext db;

        private Pagination<Proyecto> PaginationProjects;

        public ProyectosController(ApplicationDbContext db)

        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search, int page = 1)
        {
            int totalRecords = 0;

            if (search == null)
            {
                search = "";
            }

            //Obtener los resgistros totales
            totalRecords = await db.Proyectos.CountAsync(
                d => d.DepartmentName.Contains(search));

            //Obtener datos
            var projects = await db.Proyectos
                .Where(d => d.DepartmentName.Contains(search))
                .ToListAsync();

            var ProjectsResult = projects.OrderBy(o => o.DepartmentName)
                .Skip((page - 1) * RecordsPerPage)
                .Take(RecordsPerPage);
            //Obtener el total de pginas
            var totalPages = (int)Math.Ceiling((double)totalRecords / RecordsPerPage);

            //Instanciar la clase de paginacion

            PaginationProjects = new Pagination<Proyecto>()
            {
                RecordsPerPage = this.RecordsPerPage,
                TotalRecords = totalRecords,
                TotalPage = totalPages,
                CurrentPage = page,
                Seacrh = search,
                Result = ProjectsResult
            };

            return View(PaginationProjects);

        }


    }
}
