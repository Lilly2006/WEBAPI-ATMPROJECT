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
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionDetails>().Property(x => x.AccountNumber).HasColumnType("long").HasPrecision(17, 3);
        }*/

        public DbSet<CustomerDetails> customerDetails { get; set; }
        public DbSet<TransactionDetails> transactionDetails { get; set; }
    }
}
