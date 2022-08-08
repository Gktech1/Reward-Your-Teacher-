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
        Task<School> SchoolExists(int schoolId);
        Task<bool> CreateSchool(School school);
        Task<bool> UpdateSchool(School school);
        Task<bool> DeleteSchoolById(int schoolId);
        Task<bool> SaveChanges();
    }
}
