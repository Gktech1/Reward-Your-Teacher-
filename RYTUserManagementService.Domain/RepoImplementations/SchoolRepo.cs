using RYTUserManagementService.Domain.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class SchoolRepo : ISchoolRepo
    {
        public class SchoolRepo : ISchoolRepo
        {
            private readonly ISchoolRepo<School, int> _schoolRepo;

            public TeacherRepo(ISchoolRepo<School, int> schoolRepo)
            {
                _schoolRepo = schoolRepo;
            }

            public async Task<School> GetSchool(int id)
            {
                return await _schoolRepo.FirstOrDefaultAsync(id);
            }

            public async Task<School> Save(School input)
            {
                return await _teacherRepo.InsertOrUpdateAsync(input);
            }

            public async Task<School> DeleteSchool(int id)
            {
                return await _schoolRepo.DeleteAsync(id);
            }

            public async Task<ICollection<School>> GetAll()
            {
                return await _schoolRepo.GetAllListAsync();
            }

            public async Task<School> UpdateSchool(int id)
            {
                return await _schoolRepo.UpdateAsync(id);
            }
        }
}
