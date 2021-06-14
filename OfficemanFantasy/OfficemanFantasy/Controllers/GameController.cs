using Abp.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using OfficemanFantasy.Domain;
using OfficemanFantasy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public IActionResult TakeDamage(int id, int damage)
        {
            Unit unit = _context.Units.FirstOrDefault(unit => unit.Id == id);

            if (unit != null)
            {
                unit.ApplyDamage(damage);
                _context.Update(unit);
                _context.SaveChanges();

                return Redirect($"/Game/UnitInfo?id={id}");
            }
            else
            {
                return View();
            }
        }
    }
    
}
