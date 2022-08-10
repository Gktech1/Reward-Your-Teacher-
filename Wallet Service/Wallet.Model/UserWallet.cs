using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Model
{
    public class UserWallet
    {
        public UserWallet()
        {
            Transactions = new HashSet<UserTransaction>();
        }
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public double Balance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string Currency { get; set; }
        public bool Status { get; set; }
        public ICollection<UserTransaction> Transactions { get; set; }

    }
}
