using System;
using System.Collections.Generic;
using System.Text;
using Budgetify.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Budgetify.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<DebtCategory> DebtCategory { get; set; }
    }
}
