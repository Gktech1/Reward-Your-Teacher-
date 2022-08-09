using Microsoft.AspNetCore.Mvc;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Dtos;
using Wallet.Model;

namespace Wallet.Core.Interfaces
{
	public interface IWalletServices
	{
		Task<ExecutionResponse<UserWalletDto>> CreateWalletAsync(UserWalletDto userWallet);
		Task<ExecutionResponse<UserWalletDto>> GetUserWalletAsync(Guid id);
	}


	
}
