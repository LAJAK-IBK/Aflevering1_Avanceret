using Aflevering1_Avanceret.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Aflevering1_Avanceret.Controllers
{
    public class TaskController : Controller
    {
        //
        private readonly TaskDbContext _dbContext;
        public TaskController(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tasks = _dbContext.Tasks.ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            var taskId = _dbContext.Tasks.Select(x => x.Id).Max() + 1;
            task.Id = taskId;
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _dbContext.Tasks.Find(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var task = _dbContext.Tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _dbContext.Tasks.Find(id);
            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var task = _dbContext.Tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }
    }
}
