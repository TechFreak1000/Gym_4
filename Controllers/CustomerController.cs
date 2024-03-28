using Microsoft.AspNetCore.Mvc;
using Gym.Data;
using Gym.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Authorization;

namespace Gym.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db) 
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            List<Customer> objCustomerList = _db.CustomerDetail.ToList();
            return View(objCustomerList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer obj)
        {
            if (ModelState.IsValid)
            {
                obj.PhoneNumber.ToString();
                _db.CustomerDetail.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Customer customerFromDB = _db.CustomerDetail.Find(id);
            Customer customerFromDB1 = _db.CustomerDetail.FirstOrDefault(u=>u.Id==id);
            Customer customerFromDB2 = _db.CustomerDetail.Where(u => u.Id == id).FirstOrDefault();

            if (customerFromDB == null)
            {
                return NotFound();
            }
            return View(customerFromDB);
        }
        [HttpPost]
        public IActionResult Edit(Customer obj)
        {
            if (ModelState.IsValid)
            {
                _db.CustomerDetail.Update(obj);
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

            Customer customerFromDB = _db.CustomerDetail.Find(id);
            Customer customerFromDB1 = _db.CustomerDetail.FirstOrDefault(u => u.Id == id);
            Customer customerFromDB2 = _db.CustomerDetail.Where(u => u.Id == id).FirstOrDefault();

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
