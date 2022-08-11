using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.TypeRepository
{
    public class SchoolRepository : GenericRepository <CreateSchoolDto>, ISchoolRepository
    {
        public SchoolRepository(UserManagementDbContext context) : base(context) { }
    }
}
