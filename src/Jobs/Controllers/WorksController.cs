using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jobs.Data;
using Jobs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Jobs.Entities;
using System.Net.WebSockets;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Diagnostics;

namespace Jobs.Controllers
{
    public class WorksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorksController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Works.ToListAsync());
        }

        public async Task<IActionResult> Search(string searchParam) {
            return View(await _context.Works.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works
                .FirstOrDefaultAsync(m => m.Id == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Title,Description, Address, Phone, StartTime, EndTime")] Work work, IFormFile formFile, string Price)
        {
            if (ModelState.IsValid)
            {
                if (formFile != null) {
                    MemoryStream memoryStream = new MemoryStream();
                    formFile.CopyTo(memoryStream);
                    string base64Data = Convert.ToBase64String(memoryStream.ToArray());
                    work.ImageUrl = string.Format("data:image/jpg;base64, {0}", base64Data);
                }

                work.User = User.Identity.Name;
                work.LastUpdate = DateTime.Now.ToString();
                if (decimal.TryParse(Price, out decimal result))
                {
                    work.Price = result;
                }
              
                _context.Add(work);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(work);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works.FindAsync(id);
            if (work == null)
            {
                return NotFound();
            }

            if (work.User != User.Identity.Name) {
                return this.Unauthorized();
            }

            return View(work);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Title,Description, Address, Phone, StartTime, EndTime, ImageUrl")] Work work, IFormFile formFile)
        {
            if (id != work.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (formFile != null) {
                        MemoryStream memoryStream = new MemoryStream();
                        formFile.CopyTo(memoryStream);
                        string base64Data = Convert.ToBase64String(memoryStream.ToArray());
                        work.ImageUrl = string.Format("data:image/jpg;base64, {0}", base64Data);
                    }

                    work.User = User.Identity.Name;
                    work.LastUpdate = DateTime.Now.ToString();

                    _context.Update(work);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkExists(work.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(work);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var work = await _context.Works
                .FirstOrDefaultAsync(m => m.Id == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var work = await _context.Works.FindAsync(id);
            _context.Works.Remove(work);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkExists(int id)
        {
            return _context.Works.Any(e => e.Id == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string Message)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, Message = Message });
        }
    }
}
