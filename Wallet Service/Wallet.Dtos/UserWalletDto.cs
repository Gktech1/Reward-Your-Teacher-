using System;

namespace Wallet.Dtos
{
    public class UserWalletDto
    {
        public int UserId { get; set; }
        public double Balance { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string Currency { get; set; }
        public string bankCode { get; set; }
    }
}
