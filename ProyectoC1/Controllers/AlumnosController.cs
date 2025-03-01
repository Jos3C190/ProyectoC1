using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoC1.Db;
using ProyectoC1.Models;

namespace ProyectoC1.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AppDbContext _dbConn;
        public AlumnosController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }

        public IActionResult Index()
        {
            var alumnos = _dbConn.Alumnos.ToList();
            return View(alumnos);
        }

        [HttpGet]
        public IActionResult UpSert(int id)
        {
            if (id == 0)
            {
                Alumno alumno = new();
                return View(alumno);
            }
            else
            {
                Alumno alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId == id) ?? new();
                return View(alumno);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Alumno model)
        {
            if (model.AlumnoId == 0)
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Alumnos.Add(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                _dbConn.Alumnos.Update(model);
                _dbConn.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Alumno alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId == id) ?? new();
            alumno.IsActive = false;
            _dbConn.Alumnos.Update(alumno);
            _dbConn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
