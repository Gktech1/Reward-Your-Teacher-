using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IStudentSchoolRepo
    {
        Task<Student> GetStudentInASchool(int id);
        Task<ICollection<Student>> GetAllStudentInASchool(School school);
    }
}
