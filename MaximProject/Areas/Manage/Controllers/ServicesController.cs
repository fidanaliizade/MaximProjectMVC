using MaximProject.Areas.Manage.ViewModels;
using MaximProject.DAL;
using MaximProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaximProject.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;

        public ServicesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> services = await _db.Services.ToListAsync();
            return View(services);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServicesCreateVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            };
            Service service = new Service()
            {
                Title = vm.Title,
                Description = vm.Description

            };
            await _db.Services.AddAsync(service);
            await _db.SaveChangesAsync();   
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            Service service = await _db.Services.FindAsync(id);

            ServicesUpdateVM updateVM = new ServicesUpdateVM()
            {
                Title= service.Title,
                Description= service.Description,
               
            };
            return View(updateVM);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, ServicesUpdateVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            };
            Service oldService = await _db.Services.FindAsync(id);
            oldService.Title = vm.Title;
            oldService.Description = vm.Description;
            await _db.SaveChangesAsync();   
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(int id)
        {

            Service service = await _db.Services.FindAsync(id);
            _db.Services.Remove(service);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
