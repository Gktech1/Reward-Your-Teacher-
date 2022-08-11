﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Dtos
{
    public class UserWalletUpdateDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public double Balance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string Currency { get; set; }
        public bool Status = true;
    }
}