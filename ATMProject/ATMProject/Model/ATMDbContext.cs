using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ATMProject.Model
{
    public class ATMDbContext:DbContext
    {
        public ATMDbContext(DbContextOptions<ATMDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerDetails> customerDetails { get; set; }
    }
}
