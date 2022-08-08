using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> StudentExists(int studentId);
        Task<bool> CreateStudent(Student student);
        Task<bool> UpdateStudent(Student student);
        void  DeleteStudent(Student student);
        Task<bool> SaveChanges();



    }
}
