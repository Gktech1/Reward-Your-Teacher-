using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface ITeacherSchoolRepo
    {
        Task<Teacher> GetTeacherInASchool(int id);
        Task<ICollection<Teacher>> GetAllTeacherInASchool(School school);
    }
}
