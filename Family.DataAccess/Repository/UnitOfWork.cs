using Family.DataAccess.Repository.IRepository;
using Family.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            PersonInfo = new PersonInfoRepository(_db);
            PerHeadExpense = new PerHeadExpenseRepository(_db);
        }

        public IPersonInfo PersonInfo { get; private set; }
        public IPerHeadExpense PerHeadExpense { get; private set; }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
