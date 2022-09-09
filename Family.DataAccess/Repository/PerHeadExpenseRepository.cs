using Family.DataAccess.Repository.IRepository;
using Family.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.DataAccess.Repository
{
    public class PerHeadExpenseRepository : Repository<PerHeadExpense>, IPerHeadExpense
    {
        private readonly ApplicationDbContext _db;
        public PerHeadExpenseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
        public void Update(PerHeadExpense obj)
        {
            _db.PerHeadExpenses.Update(obj);
        }
    }
}
