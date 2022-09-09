﻿using Family.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.DataAccess.Repository.IRepository
{
    public interface IPerHeadExpense : IRepository<PerHeadExpense>
    {
        void Update(PerHeadExpense obj);
      


    }
}
