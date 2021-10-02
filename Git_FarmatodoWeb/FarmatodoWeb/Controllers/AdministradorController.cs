using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FarmatodoWeb.Models;
using FarmatodoWeb.Data;
using FarmatodoWeb.Utils;
using Microsoft.EntityFrameworkCore;
using FarmatodoWeb.Filters;

namespace FarmatodoWeb.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly ILogger<AdministradorController> _logger;
        private readonly ApplicationDbContext _context;

        public AdministradorController(ILogger<AdministradorController> logger, ApplicationDbContext context/*, PersonaBase personaBase*/)
        {
            _logger = logger;
            _context = context;
        }

        [ServiceFilter(typeof(VerificarSesionAdministrador))]
        public IActionResult AdministradorV1(){
            return View();
        }

        [ServiceFilter(typeof(VerificarSesionAdministrador))]
        public IActionResult AdministradorV2(){
            return View();
        }
    }
}
