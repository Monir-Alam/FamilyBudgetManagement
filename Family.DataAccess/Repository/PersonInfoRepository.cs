using Family.DataAccess.Repository.IRepository;
using Family.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.DataAccess.Repository
{
    public class PersonInfoRepository : Repository<PersonInfo>, IPersonInfo
    {
        private readonly ApplicationDbContext _db;
        public PersonInfoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
        public void Update(PersonInfo obj)
        {
            _db.PersonInfos.Update(obj);
        }
    }
}
