using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface ISchoolRepo
    {
        Task<IEnumerable<School>> GetAllSchools();
        Task<bool> SchoolExists(string schoolName);
        Task<bool> CreateSchool(School school);
        Task<bool> UpdateSchool(School school);
        Task<bool> DeleteSchool(School school);
        Task<bool> SaveChanges();
    }
}
