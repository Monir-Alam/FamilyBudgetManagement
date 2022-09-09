using Family.DataAccess;
using Family.DataAccess.Repository.IRepository;
using Family.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Controllers
{
    public class PerHeadExpenseController : Controller
    {
        private readonly IUnitOfWork _db;
        public PerHeadExpenseController(IUnitOfWork db)
        {
            _db = db;
        }


        //GETALL
        public IActionResult Index()
        {
            IEnumerable<PerHeadExpense> objExpenseList = _db.PerHeadExpense.GetAll();
            return View(objExpenseList);
        }



        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PerHeadExpense obj)
        {
            if (ModelState.IsValid)
            {
                _db.PerHeadExpense.Add(obj);
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

            var ExpenseFromDb = _db.PerHeadExpense.GetFirstOrDefault(u=>u.Id==id);
            if (ExpenseFromDb == null)
            {
                return NotFound();
            }
            return View(ExpenseFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PerHeadExpense obj)
        {
            if (ModelState.IsValid)
            {
                _db.PerHeadExpense.Update(obj);
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

            var ExpenseFromDb = _db.PersonInfo.GetFirstOrDefault(u => u.Id == id);
            if (ExpenseFromDb == null)
            {
                return NotFound();
            }
            return View(ExpenseFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.PerHeadExpense.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.PerHeadExpense.Remove(obj);
            _db.Save();
            return RedirectToAction("Index");
        }

    }
}
