using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoC1.Db;

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
    }
}
