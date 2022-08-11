using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Model;

namespace Wallet.Data
{
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<UserWallet> Wallets { get; set; }
        public DbSet<UserTransaction> Transactions { get; set; }
        public DbSet<AccountDetail> AccountDetails { get; set; }
    }
}
