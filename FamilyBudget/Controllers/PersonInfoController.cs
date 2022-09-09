using Family.DataAccess;
using Family.DataAccess.Repository.IRepository;
using Family.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Controllers
{
    public class PersonInfoController : Controller
    {
        private readonly IUnitOfWork _db;
        public PersonInfoController(IUnitOfWork db)
        {
            _db = db;
        }


        //GETALL
        public IActionResult Index()
        {
            IEnumerable<PersonInfo> objPersonList = _db.PersonInfo.GetAll();
            return View(objPersonList);
        }



        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonInfo obj)
        {
            if (ModelState.IsValid)
            {
                _db.PersonInfo.Add(obj);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }



        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var PersonFromDb = _db.PersonInfo.GetFirstOrDefault(u=>u.Id==id);
            if (PersonFromDb == null)
            {
                return NotFound();
            }
            return View(PersonFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PersonInfo obj)
        {
            if (ModelState.IsValid)
            {
                _db.PersonInfo.Update(obj);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }



        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var PersonFromDb = _db.PersonInfo.GetFirstOrDefault(u => u.Id == id);
            if (PersonFromDb == null)
            {
                return NotFound();
            }
            return View(PersonFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.PersonInfo.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.PersonInfo.Remove(obj);
            _db.Save();
            return RedirectToAction("Index");
        }

    }
}
