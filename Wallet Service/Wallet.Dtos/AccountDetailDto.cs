using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Dtos
{
    public class AccountDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long AccountNumber { get; set; }
        public string Bank { get; set; }
        public string userId { get; set; }
    }
}
