using Gym.Data;
using Gym.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    
        [Authorize(Roles = SD.Role_Admin)]
        public class CustomerDetailsController : Controller
        {
            private readonly ApplicationDbContext _db;
            public CustomerDetailsController(ApplicationDbContext db)
            {
                _db = db;
            }

            public IActionResult Index()
            {
                List<ApplicationUser> objApplicationUserList = _db.ApplicationUser.ToList();
                return View(objApplicationUserList);
            }

            public IActionResult Edit(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                ApplicationUser customerFromDB = _db.ApplicationUser.Find(id);

                if (customerFromDB == null)
                {
                    return NotFound();
                }
                return View(customerFromDB);
            }
            [HttpPost]
            public IActionResult Edit(ApplicationUser obj)
            {
                if (ModelState.IsValid)
                {
                    _db.ApplicationUser.Update(obj);
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

                ApplicationUser customerFromDB = _db.ApplicationUser.Find(id);
               
                if (customerFromDB == null)
                {
                    return NotFound();
                }
                return View(customerFromDB);
            }


            [HttpPost, ActionName("Delete")]
            public IActionResult DeletePOST(int? id)
            {
                Customer obj = _db.CustomerDetail.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.CustomerDetail.Remove(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
}
