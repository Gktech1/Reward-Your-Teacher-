using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface ITeacherRepo
    {
        Task<Teacher> GetTeacher(int id);
        Task<Teacher> Save(Teacher input);
        Task<Teacher> DeleteTeacher(int id);
        Task<ICollection<Teacher>> GetAll();
        Task<Teacher> UpdateTeacher(int id);
    }
}
