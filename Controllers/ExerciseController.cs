using Gym.Data;
using Gym.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class ExerciseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExerciseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Exercise> objExerciseList = _db.ExerciseDetail.ToList();
            return View(objExerciseList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Exercise obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExerciseDetail.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Exercise ExerciseFromDB = _db.ExerciseDetail.Find(id);
            Exercise ExerciseFromDB1 = _db.ExerciseDetail.FirstOrDefault(u => u.Id == id);
            Exercise ExerciseFromDB2 = _db.ExerciseDetail.Where(u => u.Id == id).FirstOrDefault();

            if (ExerciseFromDB == null)
            {
                return NotFound();
            }
            return View(ExerciseFromDB);
        }
        [HttpPost]
        public IActionResult Edit(Exercise obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExerciseDetail.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Exercise ExerciseFromDB = _db.ExerciseDetail.Find(id);
            Exercise ExerciseFromDB1 = _db.ExerciseDetail.FirstOrDefault(u => u.Id == id);
            Exercise ExerciseFromDB2 = _db.ExerciseDetail.Where(u => u.Id == id).FirstOrDefault();

            if (ExerciseFromDB == null)
            {
                return NotFound();
            }
            return View(ExerciseFromDB);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Exercise obj = _db.ExerciseDetail.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.ExerciseDetail.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}