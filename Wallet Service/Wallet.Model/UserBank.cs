using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Model
{
    public class UserBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long AccountNumber { get; set; }
        public string BankCode { get; set; }
        public int WalletId { get; set; }
        [ForeignKey("WalletId")]
        public UserWallet Wallet { get; set; }
        public AccountDetail AccountDetail { get; set; }
    }
}
