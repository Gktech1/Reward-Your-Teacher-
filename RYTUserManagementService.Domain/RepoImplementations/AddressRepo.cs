using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class AddressRepo
    {
        private readonly IAddressRepo<Address, int> _addressRepo;

        public AddressRepo(IAddressRepo<Address, int> addressRepo)
        {
            _addressRepo = addressRepo;
        }

        public async Task<Address> GetAddress(int id)
        {
            return await _addressRepo.FirstOrDefaultAsync(id);
        }

        public async Task<Address> Save(Address input)
        {
            return await _addressRepo.InsertOrUpdateAsync(input);
        }

        public async Task<Address> DeleteAddress(int id)
        {
            return await _addressRepo.DeleteAsync(id);
        }

        public async Task<ICollection<Address>> GetAll()
        {
            return await _addressRepo.GetAllListAsync();
        }

        public async Task<Address> UpdateAddress(int id)
        {
            return await _addressRepo.UpdateAsync(id);
        }
    }
}
