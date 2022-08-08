using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Model
{
     public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string StudentId { get; set; }
        public enum Status { a,b }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string WalletId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

    }
}
