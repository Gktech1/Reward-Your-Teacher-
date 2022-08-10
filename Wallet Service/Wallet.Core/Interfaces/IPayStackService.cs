using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Dtos.PaymentDtos;

namespace Wallet.Core.Interfaces
{
    public interface IPayStackService
    {
        Task<PayStackLinkResponseDto> GetPaymentLink(PayStackPaymentDto details, string userId);
        Task<bool> ConfirmTransactionById(string transactionId);
        Task<bool> ConfirmTransactionByRef(string txRef);
    }
}
