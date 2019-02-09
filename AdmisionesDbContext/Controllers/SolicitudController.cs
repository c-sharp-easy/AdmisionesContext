using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdmisionesDbContext.Models;

namespace AdmisionesDbContext.Controllers
{
    public class SolicitudController : Controller
    {

        private readonly DBADMISIONESContext _db;

        public SolicitudController(DBADMISIONESContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registrar()
        {
            return View();
        }

    }
}