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

            public IActionResult Edit(string Id)
            { 
                if (Id  == null)
                {
                    return NotFound();
                }

                ApplicationUser customerFromDB = _db.ApplicationUser.Find(Id);

                if (customerFromDB == null)
                {
                    return NotFound();
                }
                return View(customerFromDB);
            }

            [HttpPost]
            public IActionResult Edit(ApplicationUser obj)
            {
                //if (ModelState.IsValid)
                //{
                    _db.ApplicationUser.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               // }
               // return View();
            }

            //public IActionResult Delete(string? Id)
            //{
            //    if (Id == null )
            //    {
            //        return NotFound();
            //    }

            //    ApplicationUser customerFromDB = _db.ApplicationUser.Find(Id);
               
            //    if (customerFromDB == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(customerFromDB);
            //}


           
            public IActionResult DeletePOST(string? Id)
            {
                ApplicationUser obj = _db.ApplicationUser.Find(Id);
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.ApplicationUser.Remove(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
}
