using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Model.Enums;

namespace Wallet.Model
{

    public class UserTransaction
    {
        [Key]
        public Guid Id { get; set; }
        public TransactionStatus Status { get; set; } = TransactionStatus.Pending;
        public TransactionType Type { get; set; } = TransactionType.Funding;
        public string Amount { get; set; }   
        public Guid WalletId { get; set; }
#nullable enable
        public string? TransactionReference { get; set; }
        public string? Description { get; set; }
        public string? SenderOrReceiverWalletId { get; set; } 
        public Bank? UserBank { get; set; }
#nullable disable
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        [ForeignKey("WalletId")]
        public UserWallet Wallet { get; set; }

    }
}
