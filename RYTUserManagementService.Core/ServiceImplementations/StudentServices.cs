using RYTUserManagementService.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Domain.

namespace RYTUserManagementService.Core.ServiceImplementations
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepo _studentRepo;
        public StudentServices(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepo.GetAllStudent();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _studentRepo.GetStudentById(id);
        }
        public async Task<Student> GetStudentBySchoolIdAsync(int schoolId)
        {
            return await _studentRepo.GetStudentBySchoolId(schoolId);
        }
        public async Task<bool> AddStudent(Student student)
        {
            return await _studentRepo.CreateStudent(student);
        }
        public async Task<bool> UpdateStudent(Student student)
        {
            return await (_studentRepo.UpdateStudent(student));
        }
        public async Task<bool> DeleteStudent(Student student)
        {
            return await _studentRepo.DeleteStudent(student);
        }
    }
}
