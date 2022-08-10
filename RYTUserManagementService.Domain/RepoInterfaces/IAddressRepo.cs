using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IAddressRepo
    {
        Task<Address> GetAddress(int id);

        Task<Address> Save(Address input);

        Task<Address> DeleteAddress(int id);
        Task<ICollection<Address>> GetAll();
        Task<Address> UpdateAddress(int id);
       
    }
}
