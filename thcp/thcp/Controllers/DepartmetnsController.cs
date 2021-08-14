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
    public class DepartmetnsController : Controller
    {
        private readonly int RecordsPerPage = 10;

        private readonly ApplicationDbContext db;

        private Pagination<Department> PaginationDepartments;

        public DepartmetnsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [Route("/Departments")]
        [Route("/Departments/{search}")]
        [Route("/Departments/{search}/{page}")]
        public async Task<IActionResult> Index(string search, int page = 1)
        {
            int totalRecords = 0;

            if (search == null)
            {
                search = "";
            }

            //Obtener los resgistros totales
            totalRecords = await db.Departments.CountAsync(
                d => d.DepartmentName.Contains(search));

            //Obtener datos
            var departments = await db.Departments
                .Where(d => d.DepartmentName.Contains(search))
                .ToListAsync();

            var departmentsResult = departments.OrderBy(o => o.DepartmentName)
                .Skip((page - 1) * RecordsPerPage)
                .Take(RecordsPerPage);
            //Obtener el total de pginas
            var totalPages = (int)Math.Ceiling((double)totalRecords / RecordsPerPage);

            //Instanciar la clase de paginacion

            PaginationDepartments = new Pagination<Department>() 
            {
                RecordsPerPage = this.RecordsPerPage,
                TotalRecords = totalRecords,
                TotalPage = totalPages,
                CurrentPage = page,
                Seacrh = search,
                Result = departmentsResult
            };

            return View(PaginationDepartments);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Departments.FirstOrDefaultAsync(d => d.DepartmetId == id);
            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);

        }

        //Crear por medio de vista
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Add(department);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        //Departamentos/Edit/1
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Departments.FindAsync(id);

            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department depart)
        {
            if (id != depart.DepartmetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(depart);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(depart);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Departments.FirstOrDefaultAsync(d => d.DepartmetId == id);
            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var depart = await db.Departments.FindAsync(id);
            db.Departments.Remove(depart);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
