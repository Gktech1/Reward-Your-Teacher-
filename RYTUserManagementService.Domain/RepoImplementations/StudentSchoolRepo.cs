using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class StudentSchoolRepo : IStudentSchoolRepo
    {
        private readonly IStudentRepo<StudentRepo, int> _studentSchoolRepo;

        public StudentRepo(IStudentRepo<StudentRepo, int> studentSchoolRepo)
        {
            _studentSchoolRepo = studentSchoolRepo;
        }

        public async Task<Student> GetStudentInASchool(int id)
        {
            return await _studentSchoolRepo.GetStudent(x => x.School.Id == x.id);
        }

        public async Task<ICollection<Student>> GetAllStudentInASchool(School school)
        {
            return await _studentSchoolRepo.GetAll.Where(x => x.School.Id == x.Id);
        }

    }
}
