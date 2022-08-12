using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Model
{
    [NotMapped]
    public class Bank
    {
        
        public Guid BankId { get; set; }
    }
}
