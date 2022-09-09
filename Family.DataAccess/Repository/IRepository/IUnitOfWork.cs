using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPersonInfo PersonInfo { get; }
        IPerHeadExpense PerHeadExpense { get; }


        void Save();
    }
}
