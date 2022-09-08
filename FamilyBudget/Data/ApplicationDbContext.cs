﻿using FamilyBudget.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<PerHeadExpense> PerHeadExpenses { get; set; }
    }
}
