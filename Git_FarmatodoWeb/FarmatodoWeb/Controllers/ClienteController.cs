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
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ApplicationDbContext _context;

        public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext context/*, PersonaBase personaBase*/)
        {
            _logger = logger;
            _context = context;
        }

        [ServiceFilter(typeof(VerificarSesionCliente))]
        public IActionResult ClienteV1(){
            return View();
        }

        [ServiceFilter(typeof(VerificarSesionCliente))]
        public IActionResult ClienteV2(){
            return View();
        }
    }
}
