using System;

namespace Wallet.Dtos
{
    public class UserWalletDto
    {
        public int? BankId { get; set; }
        public string UserId { get; set; }
        public double Balance { get; set; }
        public string UserFullName { get; set; }
        public string Currency { get; set; }
        public bool Status { get; set; }

    }
}
