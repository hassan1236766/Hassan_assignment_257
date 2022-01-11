using Hassan_257.Data;
using Hassan_257.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hassan_257.Controllers
{
    public class OrderController : Controller
    {
        private readonly SContext _context;
            public OrderController (SContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult Create(Omodel has)
        {

            _context.OModels.Add(has);
            _context.SaveChanges();
            return View(has);

        }
        
     
        public async Task<IActionResult> List()
        {
            var hum = await _context.OModels.ToListAsync();
            return View(hum);
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var OmInDb = await _context.OModels.FirstOrDefaultAsync(os => os.Id == id);
            if (OmInDb == null)
                return NotFound();
            _context.OModels.Remove(OmInDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ob = await _context.OModels.FirstOrDefaultAsync(os => os.Id == id);
            if (ob == null)
            {

                return NotFound();
            }
            return View(ob);
        }
    }
}
