using Microsoft.AspNetCore.Mvc;
using OfficemanFantasy.Domain;
using OfficemanFantasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Controllers
{
    public class GameController : Controller
    {
            private AppDbContext _context;

            public GameController(AppDbContext context)
            {
                _context = context;
            }
            
            public IActionResult Index()
            {
                ViewData["Units"] = _context.Units.ToArray();
                return View();
            }

            public IActionResult UnitInfo(int id)
            {
                ViewData["Unit"] = _context.Units.FirstOrDefault(unit => unit.Id == id);
                return View();
            }
    }
    
}
