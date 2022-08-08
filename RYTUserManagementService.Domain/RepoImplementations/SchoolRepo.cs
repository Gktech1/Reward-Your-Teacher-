using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly UserManagementDbContext _db;

        public SchoolRepo(UserManagementDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CreateSchool(School school)
        {
            _db.Schools.Add(school);
            return await SaveChanges();
        }

        public async Task<bool> DeleteSchool(School school)
        {
            _db.Schools.Remove(school);
            return await SaveChanges();
        }

        public async Task<IEnumerable<School>> GetAllSchools()
        {
            return await _db.Schools.OrderBy(schools => schools.Id).ToListAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return await _db.SaveChangesAsync() >= 0;
        }

        public Task<bool> SchoolExists(string schoolName)
        {
            var schoolExists = _db.Schools.AnyAsync(schoolExists => schoolExists.SchoolName.ToLower().Trim() == schoolName.ToLower().Trim());
            return schoolExists;
        }

        public async Task<bool> UpdateSchool(School school)
        {
            _db.Schools.Update(school);
            return await SaveChanges();
        }
    }
}
